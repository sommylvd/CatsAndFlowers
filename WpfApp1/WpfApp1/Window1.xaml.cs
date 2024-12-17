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
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            ImageBrush myBrushMeadow = new ImageBrush();
            myBrushMeadow.ImageSource =
                new BitmapImage(new Uri("C:\\Users\\STUDENT\\Documents\\CatsAndFlowers\\WpfApp1\\WpfApp1\\assetscats\\projcats\\meadow.jpg", UriKind.Absolute));
            this.Background = myBrushMeadow;
        }
        private void OnForestImageClick(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.WindowState = WindowState.Maximized;
            this.Close();
            mainWindow.Show();
        }

    }
}
