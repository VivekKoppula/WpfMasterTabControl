using Prism.Commands;
using SimplePrismShell.Core;

namespace SimplePrismShell.ViewModels
{
    public class ShellWindowViewModel : ViewModelBase
    {

        private string _windowTitle = default!;
        public string WindowTitle
        {
            get { return _windowTitle; }
            set { SetProperty(ref _windowTitle, value); }
        }

        public DelegateCommand<string> NavigateCommand { get; set; } = default!;

        public ShellWindowViewModel()
        {
            WindowTitle = "Main Shell Window";
            NavigateCommand = new DelegateCommand<string>(Navigate);
        }

        void Navigate(string navigationPath)
        {

        }
    }
}
