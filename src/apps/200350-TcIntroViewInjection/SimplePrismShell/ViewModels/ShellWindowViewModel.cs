using DryIoc;
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
        private readonly IContainer _container;

        public ShellWindowViewModel(IRegionManager regionManager, IContainer container)
        {
            _regionManager = regionManager;
            _container = container;
            WindowTitle = "Main Shell Window";
            NavigateCommand = new DelegateCommand<string>(Navigate);
        }
        void Navigate(string navigationPath)
        {
            var region = _regionManager.Regions["TabRegion"];
            if (navigationPath == "ViewA")
            {
                var view = _container.Resolve<ViewA>();
                region.Add(view);
            }
            if (navigationPath == "ViewB")
            {
                var view = _container.Resolve<ViewB>();
                region.Add(view);
            }
        }
    }
}
