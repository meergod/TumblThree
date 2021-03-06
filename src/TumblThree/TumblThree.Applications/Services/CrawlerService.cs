﻿using System.ComponentModel.Composition;
using System.Windows.Input;
using System.Waf.Foundation;
using TumblThree.Domain.Models;

namespace TumblThree.Applications.Services
{
    [Export(typeof(ICrawlerService)), Export]
    public class CrawlerService : Model, ICrawlerService
    {
        private ICommand addBlogCommand;
        private ICommand removeBlogCommand;
        private ICommand showFilesCommand;
        private ICommand enqueueSelectedCommand;
        private ICommand removeBlogFromQueueCommand;
        private ICommand crawlCommand;
        private ICommand pauseCommand;
        private ICommand resumeCommand;
        private ICommand stopCommand;
        private ICommand listenClipboardCommand;
        private bool isCrawl;
        private bool isPaused;
        private string newBlogUrl;

        public ICommand AddBlogCommand
        {
            get { return addBlogCommand; }
            set { SetProperty(ref addBlogCommand, value); }
        }

        public ICommand RemoveBlogCommand
        {
            get { return removeBlogCommand; }
            set { SetProperty(ref removeBlogCommand, value); }
        }

        public ICommand ShowFilesCommand
        {
            get { return showFilesCommand; }
            set { SetProperty(ref showFilesCommand, value); }
        }

        public ICommand EnqueueSelectedCommand
        {
            get { return enqueueSelectedCommand; }
            set { SetProperty(ref enqueueSelectedCommand, value); }
        }

        public ICommand RemoveBlogFromQueueCommand
        {
            get { return removeBlogFromQueueCommand; }
            set { SetProperty(ref removeBlogFromQueueCommand, value); }
        }

        public ICommand ListenClipboardCommand
        {
            get { return listenClipboardCommand; }
            set { SetProperty(ref listenClipboardCommand, value); }
        }

        public ICommand CrawlCommand
        {
            get { return crawlCommand; }
            set { SetProperty(ref crawlCommand, value); }
        }

        public ICommand PauseCommand
        {
            get { return pauseCommand; }
            set { SetProperty(ref pauseCommand, value); }
        }

        public ICommand ResumeCommand
        {
            get { return resumeCommand; }
            set { SetProperty(ref resumeCommand, value); }
        }

        public ICommand StopCommand
        {
            get { return stopCommand; }
            set { SetProperty(ref stopCommand, value); }
        }

        public bool IsCrawl
        {
            get { return isCrawl; }
            set { SetProperty(ref isCrawl, value); }
        }

        public bool IsPaused
        {
            get { return isPaused; }
            set { SetProperty(ref isPaused, value); }
        }

        public string NewBlogUrl
        {
            get { return newBlogUrl; }
            set { SetProperty(ref newBlogUrl, value); }
        }
    }
}
