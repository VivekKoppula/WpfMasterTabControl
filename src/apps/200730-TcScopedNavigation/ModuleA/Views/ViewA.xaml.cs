using SimplePrismShell.Core;
using System.Windows.Controls;

namespace ModuleA.Views
{
    /// <summary>
    /// Interaction logic for ViewA.xaml
    /// </summary>
    public partial class ViewA : UserControl, ICreateRegionManagerScope
    {
        public ViewA()
        {
            InitializeComponent();
        }
        public bool CreateRegionManagerScope
        {
            get { return true; }
        }
    }
}
