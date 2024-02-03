using Prism;
using Prism.Mvvm;
using Prism.Regions;
using System;

namespace SimplePrismShell.Core
{
    public class ViewModelBase : BindableBase, INavigationAware, IActiveAware
    {
        private string _title = default!;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private bool _isActive;
        public bool IsActive
        {
            get { return _isActive; }
            set { 
                SetProperty(ref _isActive, value);
                if (IsActive)
                {
                    Title = "I'am active";
                }
                else
                {
                    Title = "I'am not active";
                }
            }
        }

        public event EventHandler? IsActiveChanged;

        public virtual bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {

        }

        public void OnNavigatedTo(NavigationContext navigationContext)
        {

        }
    }
}
