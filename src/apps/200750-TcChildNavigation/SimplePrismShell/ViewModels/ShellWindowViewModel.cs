using DryIoc;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;

namespace SimplePrismShell.ViewModels
{
    public class ShellWindowViewModel : BindableBase
    {

        private string _windowTitle = default!;
        public string WindowTitle
        {
            get { return _windowTitle; }
            set { SetProperty(ref _windowTitle, value); }
        }
        public DelegateCommand<string> NavigateCommand { get; set; } = default!;
        private readonly IRegionManager _regionManager;
        private readonly IContainer _container;

        public ShellWindowViewModel(IRegionManager regionManager, IContainer container)
        {
            _regionManager = regionManager;
            _container = container;
            WindowTitle = "Main Shell Window";
            NavigateCommand = new DelegateCommand<string>(Navigate);
        }
        private void Navigate(string navigationPath)
        {
            _regionManager.RequestNavigate("TabRegion", navigationPath);
        }
    }
}
