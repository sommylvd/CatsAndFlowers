﻿using System;
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
        public Window2()
        {
            InitializeComponent();
            ImageBrush myBrushShop = new ImageBrush();
            myBrushShop.ImageSource =
                new BitmapImage(new Uri("C:\\Users\\STUDENT\\Documents\\CatsAndFlowers\\WpfApp1\\WpfApp1\\assetscats\\backgroudsshop.png", UriKind.Absolute));
            this.Background = myBrushShop;
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Maximized;
            this.Topmost = true;
        }
    }
}
