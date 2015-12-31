namespace TumblrPicDownloader
{
    using System;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;
    using System.Net;
    using System.Text;
    using System.Threading.Tasks;

    public class TumblrPicDownloader
    {
        private const string EndString = "\"";
        private const string EmptyPageKeyword = "\"posts\":[]";
        private const string UrlPageWord = "page/";
        private const string JsonEnd = "/json";

        private int imageCounter;
        private HashSet<string> urls;
        private double totalSize;
        private int maxPage;
        private int imagesDownloaded;
        private ILogger l;
        private object sizeLock;
        private int lastPageInBlog;
        private int currentPage;
        private PicSize size;
        private string startString;
        private Dictionary<string, bool> fileTypes;
        private string counterFormat;

        private ConcurrentDictionary<string, bool> filesLeft;

        private IList<WebClient> clientList;
        private bool isAborted;

        public TumblrPicDownloader(ILogger logger)
        {
            this.InitializeStartParametrs(logger);           
        }

        public int MaxPage
        {
            get { return this.maxPage; }
            set { this.maxPage = value; }
        }

        public bool SkipSameFiles { get; set; }

        public string ShowSizeSoFar
        {
            get { return ShowSize(this.totalSize); }
        }

        public double TotalSizeSoFar
        {
            get { return this.totalSize;  }
        }

        public int PicsDownloadedSoFar
        {
            get { return this.imagesDownloaded / 2; }
        }

        public int LastPageOnBlog
        {
            get 
            {
                if (this.lastPageInBlog == 0)
                {
                    return -1;
                }

                return this.lastPageInBlog;
            }
        }

        public PicSize PictureSize
        {
            get
            { 
                return this.size; 
            }

            set 
            { 
                this.size = value;
                this.startString = "\"photo-url-" + (int)this.size + "\":\"";
            }
        }

        public string ImageTextName { get; set; }

        public Dictionary<string, bool> FileTypes
        {
            get { return this.fileTypes; }
            set { this.fileTypes = value; }
        }

        public int StartPage
        {
            get 
            { 
                return this.currentPage; 
            }

            set 
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Start page must be >= 0.");
                }

                if (value > this.MaxPage)
                {
                    throw new ArgumentException("Start page must be <= Max page.");
                }

                this.currentPage = value; 
            }
        }      

        public int CounterFormat
        {
            get 
            { 
                return this.counterFormat.Length; 
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Counter Format must be > 0.");
                }

                this.counterFormat = new string('0', value);
            }
        }

        public int ShowFoundedImages
        {
            get
            {
                lock (this.sizeLock)
                {
                    return this.imageCounter - 1;
                }
            }
        }

        public int BadFiles { get; private set; }

        public FilenameType FilenameType { get; set; }

        public static string ShowSize(double len)
        {
            string[] sizes = { "B", "KB", "MB", "GB" };
            int order = 0;
            while (len >= 1024 && order + 1 < sizes.Length)
            {
                order++;
                len = len / 1024;
            }

            return string.Format("{0:0.##} {1}", len, sizes[order]);
        }

        public void Abort()
        {
            this.isAborted = true;

            this.AbortSeason();

            this.l.Log("End.");
            this.InitializeStartParametrs(this.l);
        }

        public void AbortSeason()
        {
            for (int i = 0; i < this.clientList.Count; i++)
            {
                this.clientList[i].CancelAsync();
                this.clientList[i].Dispose();
            }

            this.BadFiles = 0;
        }

        public async void Start(string url, string destinationFolder)
        {
            this.isAborted = false;
            this.BadFiles = 0;

            try
            {
                var allPagesProcessed = await this.GetPageURLsAsync(url, destinationFolder);
                this.l.Log("All pages processed: " + allPagesProcessed);
            }
            catch (Exception e)
            {
                this.l.Log(e.Message);
            }
        }

        private static string GetAsString(string path)
        {
            string content = string.Empty;
            using (WebClient client = new WebClient())
            {
                client.Encoding = Encoding.UTF8;
                content = client.DownloadString(path);
            }

            return content;
        }

        private void InitializeStartParametrs(ILogger logger)
        {
            this.urls = new HashSet<string>();
            this.imageCounter = 1;
            this.totalSize = 0;
            this.MaxPage = int.MaxValue;
            this.SkipSameFiles = true;
            this.imagesDownloaded = 0;
            this.l = logger;
            this.sizeLock = new object();
            this.lastPageInBlog = 0;
            this.PictureSize = PicSize.Size1280;
            this.ImageTextName = string.Empty;
            this.StartPage = 0;
            this.startString = "\"photo-url-" + (int)this.size + "\":\"";
            this.fileTypes = new Dictionary<string, bool>
            {
                { "jpg", true },
                { "png", true },
                { "gif", true }
            };

            this.CounterFormat = 4;
            this.FilenameType = FilenameType.Counter;
            this.clientList = new List<WebClient>();
            this.isAborted = true;
            this.filesLeft = new ConcurrentDictionary<string, bool>();
        }

        private Task<bool> GetPageURLsAsync(string url, string destinationFolder)
        {
            Task<bool> parsePageURLsTask = Task.Run(
                () => this.ParsePageURLs(url, destinationFolder));

            return parsePageURLsTask;
        }

        private bool ParsePageURLs(string url, string destinationFolder)
        {
            string workingUrl = url + UrlPageWord;

            while (true)
            {
                if (this.isAborted)
                {
                    this.l.Log("Aborted on page " + this.currentPage + ".");
                    break;
                }

                if (this.currentPage == 1)
                {
                    this.currentPage = 2;
                }

                string currentUrl = workingUrl + this.currentPage.ToString() + JsonEnd;
                string html = GetAsString(currentUrl);

                if (this.currentPage > this.maxPage || html.IndexOf(EmptyPageKeyword) != -1)
                {
                    this.l.Log("Page " + this.currentPage + " do not exists.");
                    this.lastPageInBlog = this.currentPage - 1; 
                    break;
                }

                this.l.Log(
                    "Page " + 
                    this.currentPage + 
                    " located on " + 
                    currentUrl.Substring(0, currentUrl.Length - JsonEnd.Length));

                this.currentPage++;

                this.ParseImagesUrls(html, destinationFolder);
            }

            return true;
        }

        private void ParseImagesUrls(string html, string destinationFolder)
        {
            int startingPosition = 0;
            int start, temp, end;

            while (true)
            {
                start = html.IndexOf(this.startString, startingPosition) + this.startString.Length;

                if (startingPosition < start && start > this.startString.Length)
                {
                    startingPosition = start;
                }
                else
                {
                    break;
                }

                end = html.IndexOf(EndString, start);
                string currentImageUrl = html.Substring(start, end - start)
                    .Replace("\\", string.Empty);
                string currentFileType = currentImageUrl.Substring(currentImageUrl.Length - 3)
                    .ToLower();

                if (!this.fileTypes.ContainsKey(currentFileType) || 
                    !this.fileTypes[currentFileType])
                {
                    continue;
                }

                if (this.SkipSameFiles)
                {
                    temp = this.urls.Count;
                    this.urls.Add(currentImageUrl);

                    // Check if the same image url already exist -> skip it.
                    if (temp == this.urls.Count)
                    {
                        continue;
                    }
                }
                              
                string fileEnd = currentImageUrl.Substring(currentImageUrl.LastIndexOf('.'));
                string fileName = this.GetImageName(
                    this.imageCounter, this.counterFormat, fileEnd, currentImageUrl);
                string downloadedImage = destinationFolder + "\\" + fileName;

                Tuple<string, string, string> pictureDetails = new Tuple<string, string, string>(
                    fileName, currentImageUrl, downloadedImage);
                object pictureDetailsPackage = (object)pictureDetails;

                this.filesLeft.TryAdd(downloadedImage, false);

                this.imageCounter++;

                using (ExtendedWebClient client = new ExtendedWebClient())
                {
                    this.clientList.Add(client);
                    client.DownloadFileCompleted += new AsyncCompletedEventHandler(this.Completed);
                    client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(
                        this.DownloadProgressCallback);
                    client.DownloadFileAsync(new Uri(currentImageUrl), downloadedImage, pictureDetailsPackage);
                }                
            }
        }

        private void DownloadProgressCallback(object sender, DownloadProgressChangedEventArgs e)
        {
            if (e.ProgressPercentage == 100)
            {
                this.AddCurentImageSizeToTotal(e.TotalBytesToReceive);
            }
        }

        private void Completed(object sender, AsyncCompletedEventArgs e)
        {
            Tuple<string, string, string> pictureDetails = (Tuple<string, string, string>)e.UserState;

            if (e.Cancelled || this.isAborted)
            {
                this.l.Log("File skiped " + pictureDetails.Item1);
                File.Delete(pictureDetails.Item3);
                return;
            }

            if (e.Error != null)
            {
                this.BadFiles += 1;
                this.l.Log("Bad file " + pictureDetails.Item1);

                File.Delete(pictureDetails.Item3);
                this.filesLeft.Remove(pictureDetails.Item3);

                return;
            }

            this.filesLeft.Remove(pictureDetails.Item3);
            this.l.Log("Downloaded " + pictureDetails.Item1);
        }

        private string GetImageName(int counter, string format, string fileEnd, string imageUrl)
        {
            if (this.FilenameType == FilenameType.Counter)
            {
                return counter.ToString(format) + fileEnd;
            }
            else if (this.FilenameType == FilenameType.CounterAndPageNumber)
            {
                int pageNumber = this.currentPage;
                if (pageNumber > 1)
                {
                    pageNumber--;
                }

                return counter.ToString(format) + "_" + pageNumber + fileEnd;
            }
            else if (this.FilenameType == FilenameType.Original)
            {
                int start = imageUrl.LastIndexOf("/");
                return imageUrl.Substring(start + 1);
            }
            else 
            {
                return this.ImageTextName + counter.ToString(format) + fileEnd;
            }
        }    

        private void AddCurentImageSizeToTotal(double currentSize)
        {
            lock (this.sizeLock)
            {
                this.totalSize += currentSize / 2;
                this.imagesDownloaded++;
            }
        }
    }  
}