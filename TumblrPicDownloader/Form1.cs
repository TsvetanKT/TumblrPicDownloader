namespace TumblrPicDownloader
{
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Windows.Forms;
    using Ionic.Utils;

    public partial class Form1 : Form
    {
        private const string AuthorUrl = @"https://github.com/TsvetanKT";
        private const int TimerTick = 1;

        private TumblrPicDownloader tpd;
        private string blogName = null;
        private Timer timer1;
        private string destinationFolder;
        private double timeElasted;
        private string tumblrBlog;
        private bool badUserData;
        private bool isRunning;

        public Form1()
        {
            this.InitializeComponent();

            var logger = new TextBoxLogger(this, this.richTextBoxLogger);
            this.tpd = new TumblrPicDownloader(logger);
            var wat = textBoxOutput;
        }

        private static string CreateDirIfNotExist(string subName, string inputDir, bool doesSubExists)
        {
            string answer = inputDir;
            if (doesSubExists)
            {
                answer += "\\" + subName;
            }

            Directory.CreateDirectory(answer);
            return answer;
        }

        private void SelectFolderButton_Click(object sender, EventArgs e)
        {
            var dlg1 = new FolderBrowserDialogEx();
            dlg1.Description = "Select a folder to extract to:";
            dlg1.ShowNewFolderButton = true;
            dlg1.ShowEditBox = true;
            dlg1.SelectedPath = folderTextBox.Text;
            dlg1.ShowFullPathInEditBox = true;
            dlg1.RootFolder = System.Environment.SpecialFolder.MyComputer;

            // Show the FolderBrowserDialog.
            DialogResult result = dlg1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string url = dlg1.SelectedPath;
                folderTextBox.Text = url;
                label1.Text = url.Substring(url.LastIndexOf("\\") + 1);
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (this.isRunning == false)
            {
                this.SetBlogName();

                this.SetDestinationFolder();

                this.SetPagesToDownload();

                this.SetPictureSizes();

                this.SetFileTypes();

                this.SetNamingType();

                if (this.badUserData)
                {
                    this.badUserData = false;
                    return;
                }

                this.SetCounterFormat();

                this.richTextBoxLogger.ResetText();
                this.tpd.SkipSameFiles = this.checkBoxSkipSameFiles.Checked;
                this.isRunning = true;

                this.InitTimer();

                this.tpd.Start(this.tumblrBlog, this.destinationFolder);
                this.startButton.Text = "Cancel";
            }
            else
            {
                this.tpd.Abort();
                this.isRunning = false;
                this.startButton.Text = "Go";
            }           
        }

        private void SetCounterFormat()
        {
            this.tpd.CounterFormat = (int)numericCounterFormat.Value;
        }

        private void SetDestinationFolder()
        {
            if (folderTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Bad destination folder");
                this.badUserData = true;
                return;
            }

            this.destinationFolder = CreateDirIfNotExist(
                this.blogName, 
                folderTextBox.Text, 
                subfolderCheck.Checked);
        }

        private void SetBlogName()
        {
            if (tumblrUrlTextbox.Text == string.Empty)
            {
                MessageBox.Show("Bad tumblr page");
                this.badUserData = true;
                return;
            }

            this.tumblrBlog = this.TumblrBlogLocator(this.tumblrUrlTextbox.Text);
            tumblrUrlTextbox.Text = this.tumblrBlog;
        }

        private void SetFileTypes()
        {
            if (this.checkBox7.Checked == false &&
                this.checkBox8.Checked == false &&
                this.checkBox9.Checked == false)
            {
                MessageBox.Show("At lest one file type must be selected");
                this.badUserData = true;
                return;
            }

            this.tpd.FileTypes["jpg"] = this.checkBox7.Checked;
            this.tpd.FileTypes["png"] = this.checkBox8.Checked;
            this.tpd.FileTypes["gif"] = this.checkBox9.Checked;
        }

        private void SetNamingType()
        {
            if (this.radioButton5.Checked == true)
            {
                this.tpd.FilenameType = FilenameType.Counter;
            }
            else if (this.radioButton4.Checked == true)
            {
                this.tpd.FilenameType = FilenameType.Original;
            }
            else if (this.radioButton6.Checked == true)
            {
                this.tpd.FilenameType = FilenameType.CounterAndPageNumber;
            }
            else
            {
                this.tpd.FilenameType = FilenameType.TextAndCounter;
                this.tpd.ImageTextName = this.textBox3.Text;
            }
        }

        private void SetPictureSizes()
        {
            var checkedButton = groupBox2.Controls.OfType<RadioButton>()
                                      .FirstOrDefault(r => r.Checked);

            this.tpd.PictureSize = (PicSize)int.Parse(checkedButton.Text);
        }

        private void SetPagesToDownload()
        {
            if (radioAllPages.Checked == true)
            {
                this.tpd.StartPage = 0;
                this.tpd.MaxPage = int.MaxValue;
            }
            else if (radioFirstXPages.Checked == true)
            {
                this.tpd.StartPage = 0;
                this.tpd.MaxPage = (int)firstXPagesNumeric.Value;
            }
            else
            {
                int userStartPage = (int)this.startPageNumeric.Value;
                int userEndPage = (int)this.untilPageNumeric.Value;

                if (userStartPage > userEndPage)
                {
                    MessageBox.Show("Start page must be lesser than Until page");
                    this.badUserData = true;
                    return;
                }

                this.tpd.StartPage = (userStartPage == 1) ? 0 : userStartPage;
                this.tpd.MaxPage = (userEndPage == 1) ? 0 : userEndPage;
            }
        }

        private string TumblrBlogLocator(string input)
        {
            input = input.ToLower();
            char[] separators = new char[] { '.', '/', ' ' };
            var separated = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            string url = null;

            if (separated.Length == 1)
            {
                url = separated[0];
            }
            else
            {
                for (int i = 1; i < separated.Length; i++)
                {
                    if (separated[i] == "tumblr")
                    {
                        url = separated[i - 1];
                    }
                }
            }

            // SET URL for sub folder
            this.blogName = url;

            return "http://" + url + ".tumblr.com/";
        }

        private void InitTimer()
        {
            this.timer1 = new Timer();
            this.timer1.Tick += new EventHandler(this.Timer1_Tick);
            this.timer1.Interval = 1000 * TimerTick;
            this.timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (this.isRunning == false)
            {
                this.timer1.Dispose();
                return;
            }

            this.UpdateInformationBox();

            if (this.tpd.PicsDownloadedSoFar + this.tpd.BadFiles == 
                this.tpd.ShowFoundedImages && 
                this.tpd.LastPageOnBlog > 0)
            {
                this.UpdateInformationBox();
                textBoxOutput.Text += "    END";

                this.timer1.Stop();
                this.timeElasted = 0;
                this.isRunning = false;
                this.tpd.Abort();
                this.startButton.Text = "Go";
            }   
        }

        private void UpdateInformationBox()
        {
            string pagesProcessed = (this.tpd.LastPageOnBlog >= 0)
                ? this.tpd.LastPageOnBlog + " (Last)"
                : this.tpd.StartPage.ToString();

            string picsDownloaded = (this.tpd.BadFiles == 0)
                ? this.tpd.PicsDownloadedSoFar.ToString()
                : this.tpd.PicsDownloadedSoFar.ToString() + " (" + this.tpd.BadFiles + ")";

            var nl = Environment.NewLine;
            var totalSize = this.tpd.ShowSizeSoFar.Split(
                new char[] { ' ' }, 
                StringSplitOptions.RemoveEmptyEntries);

            double currentSize = double.Parse(totalSize[0]);

            this.timeElasted += TimerTick;
            double avarageSpeed = Math.Round(
                this.tpd.TotalSizeSoFar / this.timeElasted, 
                2, 
                MidpointRounding.AwayFromZero);

            var sb = new StringBuilder();
            sb.AppendLine("Size so far: " + this.tpd.ShowSizeSoFar);
            sb.AppendLine("Folder processed: " + pagesProcessed);
            sb.AppendLine("Found pictures so far: " + this.tpd.ShowFoundedImages);
            sb.AppendLine("Downloaded pictures so far: " + picsDownloaded);
            sb.AppendLine("Avarage speed: " +
                TumblrPicDownloader.ShowSize(avarageSpeed) + 
                "/s");

            sb.AppendLine("Pictures per second: " +
                 Math.Round(
                 this.tpd.PicsDownloadedSoFar / this.timeElasted, 
                 1, 
                 MidpointRounding.AwayFromZero));

            sb.AppendLine("Time elapsed: " + this.timeElasted + " seconds");

            textBoxOutput.Text = sb.ToString();
        }

        private void OpenFolderButton_Click(object sender, EventArgs e)
        {
            if (this.destinationFolder != null && this.destinationFolder != string.Empty)
            {
                Process.Start(this.destinationFolder);
            }
            else if (folderTextBox.Text != string.Empty)
            {
                try
                {
                    Process.Start(folderTextBox.Text);
                }
                catch (Win32Exception ex)
                {
                    MessageBox.Show("Bad folder url" + Environment.NewLine + "Code: " + ex.ErrorCode);
                    return;
                }               
            }         
        }

        private void RadioFirstXPages_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioFirstXPages.Checked == true)
            {
                this.firstXPagesNumeric.Enabled = true;
            }
            else
            {
                this.firstXPagesNumeric.Enabled = false;
            }
        }

        private void RadioStartFromPage_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioStartFromPage.Checked == true)
            {
                this.untilPageNumeric.Enabled = true;
                this.startPageNumeric.Enabled = true;
            }
            else
            {
                this.untilPageNumeric.Enabled = false;
                this.startPageNumeric.Enabled = false;
            }
        }

        private void RadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton4.Checked == true)
            {
                this.numericCounterFormat.Enabled = false;
            }
            else
            {
                this.numericCounterFormat.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // Load default downloading folder
            this.folderTextBox.Text = Properties.Settings.Default.defaultFolder;

            // Load default counter format
            this.numericCounterFormat.Value = Properties.Settings.Default.counterFormat;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.counterFormat = (int)this.numericCounterFormat.Value;
            Properties.Settings.Default.defaultFolder = this.folderTextBox.Text;
            Properties.Settings.Default.Save();
            this.tpd.AbortSeason();
        }

        private void RichTextBoxLogger_TextChanged(object sender, EventArgs e)
        {
            richTextBoxLogger.SelectionStart = richTextBoxLogger.Text.Length;
            richTextBoxLogger.ScrollToCaret();
        }

        private void RichTextBoxLogger_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            Process.Start(e.LinkText);
        }

        private void RadioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton7.Checked == true)
            {
                this.textBox3.Enabled = true;
            }
            else
            {
                this.textBox3.Enabled = false;
            }
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(AuthorUrl);
        }
    }
}