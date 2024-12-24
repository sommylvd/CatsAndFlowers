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
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        Player player;
        MainWindow flowerMEd;
        Window2 Shop;
        public Window1(MainWindow flowerMEd, Window2 shop,ref Player player)
        {
            InitializeComponent();
            this.flowerMEd = flowerMEd;
            Shop = shop;
            this.player = player;
            DataContext = player;
            
          
        }
        private void OnForestImageClick(object sender, RoutedEventArgs e)
        {
            flowerMEd.player=player;
            flowerMEd.WindowState = WindowState.Maximized;
            this.Hide();
            flowerMEd.Show();
        }
        private void ShopImage_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Shop.Show();
            this.Hide();
        }

        private void Grid_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            player.CraftWreathEasy();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }
    }
}
