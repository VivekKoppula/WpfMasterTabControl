using ModuleA.Views;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public ShellWindowViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;
            WindowTitle = "Main Shell Window";
            NavigateCommand = new DelegateCommand<string>(Navigate);
        }
        void Navigate(string navigationPath)
        {
            if(navigationPath == "ViewA")
                _regionManager.RegisterViewWithRegion("TabRegion", typeof(ViewA));
            if (navigationPath == "ViewB")
                _regionManager.RegisterViewWithRegion("TabRegion", typeof(ViewB));
        }
    }
}
