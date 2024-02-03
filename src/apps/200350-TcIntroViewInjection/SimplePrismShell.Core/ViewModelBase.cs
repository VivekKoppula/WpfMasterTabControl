using Prism.Mvvm;
using Prism.Regions;


namespace SimplePrismShell.Core
{
    public class ViewModelBase : BindableBase
    {
        string _title = default!;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }
    }
}
