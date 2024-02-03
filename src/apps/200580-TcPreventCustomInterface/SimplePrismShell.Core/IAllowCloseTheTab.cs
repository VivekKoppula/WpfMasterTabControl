using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePrismShell.Core
{
    //Here in this interface there are two method, but we need only one.
    //Accordingly the folloing method can be adjusted. Comment out one, and use just one.
    public interface IAllowCloseTheTab
    {
        void CheckCloseTab(Action<bool> continuationCallback);
        bool CheckCloseTab();
    }
}
