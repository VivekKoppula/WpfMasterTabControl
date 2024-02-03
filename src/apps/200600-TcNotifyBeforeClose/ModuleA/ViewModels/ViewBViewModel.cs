using Prism.Regions;
using SimplePrismShell.Core;
using System;

namespace ModuleA.ViewModels
{
    public class ViewBViewModel : ViewModelBase
    {
        private string _welcomeMessage = "Hello from ViewBViewModel";
        public string WelcomeMessage
        {
            get { return _welcomeMessage; }
            set { SetProperty(ref _welcomeMessage, value); }
        }
        public ViewBViewModel()
        {
            Title = "View B";
        }
        public override bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return false;
        }
        public override void CheckCloseTab(Action<bool> continuationCallback)
        {
            // Set the following preventClose variable using what ever logic you see fit.
            var preventClose = false;

            continuationCallback(preventClose);
        }

        public override bool CheckCloseTab()
        {
            // Set the following preventClose variable using what ever logic you see fit.
            var preventClose = false;

            return preventClose;
        }
    }
}
