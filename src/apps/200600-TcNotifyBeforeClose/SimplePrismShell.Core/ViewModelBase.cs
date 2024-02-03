using Prism.Mvvm;
using Prism.Regions;
using System;

namespace SimplePrismShell.Core
{
    public class ViewModelBase : BindableBase, INavigationAware, IAllowCloseTheTab, INoitifyOnTabClose
    {
        string _title = default!;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public virtual void CheckCloseTab(Action<bool> continuationCallback)
        {
            continuationCallback(true);
        }

        public virtual bool CheckCloseTab()
        {
            return true;
        }

        public virtual bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }

        public virtual void OnNavigatedFrom(NavigationContext navigationContext)
        {

        }

        public void OnNavigatedTo(NavigationContext navigationContext)
        {

        }

        public virtual void OnTabClose(NavigationContext navigationContext)
        {

        }
    }
}
