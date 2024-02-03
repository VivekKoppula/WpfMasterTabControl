using Prism.Commands;
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

        private readonly IRegionManager _regionManager;

        public DelegateCommand<string> NavigateCommand { get; set; }

        public ViewAViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;

            Title = "View A";
            NavigateCommand = new DelegateCommand<string>(Navigate);
        }

        private void Navigate(string navigationPath)
        {
            _regionManager.RequestNavigate("ChildRegion", navigationPath);
        }
    }
}
