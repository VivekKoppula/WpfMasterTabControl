using Prism.Regions;

namespace SimplePrismShell.Core
{
    public interface INoitifyOnTabClose
    {
        void OnTabClose(NavigationContext navigationContext);
    }
}
