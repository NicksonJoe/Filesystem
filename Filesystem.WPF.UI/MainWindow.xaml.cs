using Filesystem.Shared.ViewModels;

namespace Filesystem.WPF.UI
{
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
        }
    }
}
