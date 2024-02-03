using SimplePrismShell.Core;

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
    }
}
