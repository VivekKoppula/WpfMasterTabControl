using SimplePrismShell.Core;

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
    }
}
