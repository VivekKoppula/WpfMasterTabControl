using Prism.Commands;
using Prism.Regions;
using SimplePrismShell.Core;

namespace ModuleA.ViewModels
{
    public class ViewAViewModel : ViewModelBase, IRegionManagerAware
    {
        private string _welcomeMessage = "Hello from ViewAViewModel";
        public string WelcomeMessage
        {
            get { return _welcomeMessage; }
            set { SetProperty(ref _welcomeMessage, value); }
        }
        public DelegateCommand<string> NavigateCommand { get; set; }
        public IRegionManager RegionManager { get; set; } = default!;

        public ViewAViewModel()
        {
            Title = "View A";
            NavigateCommand = new DelegateCommand<string>(Navigate);
        }

        private void Navigate(string navigationPath)
        {
            RegionManager.RequestNavigate("ChildRegion", navigationPath);
        }
    }
}
