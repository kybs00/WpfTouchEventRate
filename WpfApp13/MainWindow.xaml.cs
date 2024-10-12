using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp13
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            TouchDown += MainWindow_TouchDown;
            TouchMove += MainWindow_TouchMove;
            TouchUp += MainWindow_TouchUp;
        }
        private int _count = 0;
        private int _startTick;

        private void MainWindow_TouchMove(object sender, System.Windows.Input.TouchEventArgs e)
        {
            _count++;
        }

        private void MainWindow_TouchDown(object sender, System.Windows.Input.TouchEventArgs e)
        {
            _startTick = Environment.TickCount;
        }

        private void MainWindow_TouchUp(object sender, System.Windows.Input.TouchEventArgs e)
        {
            Debug.WriteLine($"{_count}个点，帧率：{_count* 1000 / (Environment.TickCount - _startTick)}");
        }
    }
}