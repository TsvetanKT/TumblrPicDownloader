namespace TumblrPicDownloader
{
    using System;
    using System.Net;

    public class ExtendedWebClient : WebClient
    {
        public ExtendedWebClient()
        {
            this.ConnectionLimit = 10000;
        }

        public int ConnectionLimit { get; set; }

        protected override WebRequest GetWebRequest(Uri address)
        {
            var request = base.GetWebRequest(address) as HttpWebRequest;

            if (request != null)
            {
                request.ServicePoint.ConnectionLimit = this.ConnectionLimit;
            }

            return request;
        }
    }
}