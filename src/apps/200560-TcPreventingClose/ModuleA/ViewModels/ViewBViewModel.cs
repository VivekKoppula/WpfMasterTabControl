using Prism.Regions;
using SimplePrismShell.Core;

namespace ModuleA.ViewModels
{
    public class ViewBViewModel : ViewModelBase, IConfirmNavigationRequest
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

        public void ConfirmNavigationRequest(NavigationContext navigationContext, System.Action<bool> continuationCallback)
        {
            continuationCallback(false);
        }
    }
}
