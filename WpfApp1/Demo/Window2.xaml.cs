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

namespace WpfApp1.Demo
{
    /// <summary>
    /// Window2.xaml 的互動邏輯
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.frame.Source = new Uri(@"Page1.xaml ", UriKind.RelativeOrAbsolute);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.frame.Source = new Uri(@"Page2.xaml", UriKind.RelativeOrAbsolute);

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.frame.Source = new Uri(@"Page3.xaml", UriKind.RelativeOrAbsolute);

        }
    }
}
