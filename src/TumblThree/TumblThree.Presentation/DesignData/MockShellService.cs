﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Waf.Foundation;
using TumblThree.Applications;
using TumblThree.Applications.Properties;
using TumblThree.Applications.Services;

namespace TumblThree.Presentation.DesignData
{
    public class MockShellService : Model, IShellService
    {
        public MockShellService()
        {
            Settings = new AppSettings();
        }


        public AppSettings Settings { get; set; }

        public object ShellView { get; set; }

        public object ContentView { get; set; }

        public object DetailsView { get; set; }

        public object QueueView { get; set; }


        public IReadOnlyCollection<Task> TasksToCompleteBeforeShutdown { get; set; }

        public bool IsApplicationBusy { get; set; }


        public event CancelEventHandler Closing;


        public void ShowError(Exception exception, string displayMessage)
        {
        }

        public void ShowDetailsView()
        {
        }

        public void ShowQueueView()
        {
        }

        public void ShowSettingsView()
        {
        }

        public void ShowAboutView()
        {
        }

        public void AddTaskToCompleteBeforeShutdown(Task task)
        {
        }

        public ClipboardMonitor ClipboardMonitor { get; set; }


        public IDisposable SetApplicationBusy()
        {
            return null;
        }

        protected virtual void OnClosing(CancelEventArgs e)
        {
            Closing?.Invoke(this, e);
        }
    }
}
