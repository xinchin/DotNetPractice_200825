using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Microsoft.Win32;
//using System.Windows.Forms;

namespace WpfApp1.Demo
{
    /// <summary>
    /// Window3.xaml 的互動邏輯
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog ofd = new Microsoft.Win32.OpenFileDialog();
            if (true == ofd.ShowDialog())
            {
                System.Windows.MessageBox.Show(ofd.FileName);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            System.Windows.Controls.PrintDialog dlg = new System.Windows.Controls.PrintDialog();
            if (true == dlg.ShowDialog())
            {
                System.Windows.MessageBox.Show("......Print......");
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

            FontDialog dlg = new FontDialog();
            if (System.Windows.Forms.DialogResult.OK == dlg.ShowDialog())
            {
                System.Windows.MessageBox.Show("Font setted");
            }

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.Windows.MessageBox.Show("Color OK");
            }
        }
    }
}
