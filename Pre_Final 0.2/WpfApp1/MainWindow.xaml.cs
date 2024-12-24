using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        public Player player;
        Window1 craftMedow;
        Window2 Shop;
        public MainWindow()
        {
            InitializeComponent();
            player = new Player("Alex");
            player.Money = 1000;
            DataContext = player;
            Shop = new Window2(this,craftMedow);
            craftMedow = new Window1(this,Shop,ref player);
            
           
            _timer = new DispatcherTimer
            {
                Interval = TimeSpan.FromSeconds(0.09) // Интервал
            };
            _timer.Tick += Timer_Tick;
        }
        
        
        private void MeadowImage_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Shop.WindowState = WindowState.Maximized; 
            craftMedow.Show();
            this.Hide();
        }
        private void ShopImage_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Shop.Show();
            this.Hide();
        }
        private void BushImage_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            SvetzelImage.Visibility = Visibility.Visible;
            _timer.Stop(); 
            _timer.Start();
            player.PickFlower();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            SvetzelImage.Visibility = Visibility.Collapsed;
            _timer.Stop();
        }
        
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            craftMedow.Close();
            Process.GetCurrentProcess().Kill();
        }
    }
}
