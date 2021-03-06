﻿using System;
using System.Waf.Foundation;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace TumblThree.Domain.Models
{
    [Serializable]
    public abstract class Blog : Model, IBlog
    {

        private string name;
        private string url;
        private uint downloadedImages;
        private uint totalCount;
        private uint rating;
        private DateTime dateAdded;
        private DateTime lastCompleteCrawl;
        private bool online;
        private IList<string> links;
        private Exception loadError;

        protected Blog()
        {
            this.name = null;
            this.url = null;
            this.downloadedImages = 0;
            this.totalCount = 0;
            this.rating = 0;
            this.dateAdded = System.DateTime.Now;
            this.lastCompleteCrawl = System.DateTime.MinValue;
            this.online = false;
            this.links = new ObservableCollection<string>();
        }

        public string Name
        {
            get { return name; }
            set { SetProperty(ref name, value); }
        }

        public string Url
        {
            get { return url; }
            set { SetProperty(ref url, value); }
        }

        public uint DownloadedImages
        {
            get { return downloadedImages; }
            set { SetProperty(ref downloadedImages, value); }
        }

        public uint TotalCount
        {
            get { return totalCount; }
            set { SetProperty(ref totalCount, value); }
        }

        public uint Rating
        {
            get { return rating; }
            set { SetProperty(ref rating, value); }
        }

        public DateTime DateAdded
        {
            get { return dateAdded; }
            set { SetProperty(ref dateAdded, value); }
        }

        public DateTime LastCompleteCrawl
        {
            get { return lastCompleteCrawl; }
            set { SetProperty(ref lastCompleteCrawl, value); }
        }

        public bool Online
        {
            get { return online; }
            set { SetProperty(ref online, value); }
        }

        public Exception LoadError
        {
            get { return loadError; }
            set { SetProperty(ref loadError, value); }
        }

        public IList<string> Links
        {
            get { return links; }
            set { SetProperty(ref links, value); }
        }
    }
}
