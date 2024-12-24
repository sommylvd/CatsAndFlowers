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
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        MainWindow flowerMed;
        Window1 craftMed;
        public Window2(MainWindow flowerMed, Window1 craftMed)
        {
            InitializeComponent();
            this.flowerMed = flowerMed;
            this.craftMed = craftMed;
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            flowerMed.WindowState = WindowState.Maximized;
            this.Hide();
            flowerMed.Show();
        }
        private void ExitImage_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            
            flowerMed.Show();
            this.Hide();
        }
        private void BuyImage_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            MessageBox.Show("Кнопка нажата, но пока ничего не происходит ");
        }
    }
}
