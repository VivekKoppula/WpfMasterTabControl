using Prism.Regions;
using SimplePrismShell.Core;
using System.Diagnostics;

namespace ModuleA.ViewModels
{
    public class ViewAViewModel : ViewModelBase
    {
        private string _welcomeMessage = "Hello from ViewAViewModel";
        public string WelcomeMessage
        {
            get { return _welcomeMessage; }
            set { SetProperty(ref _welcomeMessage, value); }
        }

        public ViewAViewModel()
        {
            Title = "View A";
        }

        public override bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }

        public override void OnNavigatedFrom(NavigationContext navigationContext)
        {
            Debugger.Break(); // This method is called when the region is navigated away from this view.
        }

        public override void OnTabClose(NavigationContext navigationContext)
        {
            // In here, you can do something, before the tab gets closed.
            Debugger.Break();// This method is called when the tab is being closed.
        }
    }
}
