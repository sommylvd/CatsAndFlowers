using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DispatcherTimer _timer;
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            _timer = new DispatcherTimer
            {
                Interval = TimeSpan.FromSeconds(0.09) // Интервал
            };
            _timer.Tick += Timer_Tick;
        }
        private void MeadowImage_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.WindowState = WindowState.Maximized; 
            window1.Show();
            this.Close();
        }
        private void ShopImage_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Window2 window2 = new Window2();
            window2.Show();
            this.Close();
        }
        private void BushImage_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            SvetzelImage.Visibility = Visibility.Visible;
            _timer.Stop(); 
            _timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            SvetzelImage.Visibility = Visibility.Collapsed;
            _timer.Stop();
        }
    }
}
