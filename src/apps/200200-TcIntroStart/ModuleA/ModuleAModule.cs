using ModuleA.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace ModuleA
{
    public class ModuleAModule : IModule
    {

        public void OnInitialized(IContainerProvider containerProvider)
        {
            // The OnInitialized method will guarantee that the shell has been loaded and that the region has been created at this point
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            //containerRegistry.RegisterForNavigation<ViewA>();
            containerRegistry.Register<ViewA>();
            containerRegistry.Register<ViewB>();
        }
    }
}
