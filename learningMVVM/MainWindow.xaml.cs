using learningMVVM.ViewModel;
using System.Windows;

namespace learningMVVM
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //绑定数据，为前端binding 提供数据
            DataContext = new MainViewModel();
        }
    }
}
