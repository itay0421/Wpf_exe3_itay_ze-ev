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

namespace Wpf_exe3_itay_ze_ev
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void checkBox1_Checked(object sender, RoutedEventArgs e)
        {
            A1.Visibility = System.Windows.Visibility.Visible;

        }

        private void checkBox1_Unchecked(object sender, RoutedEventArgs e)
        {
            A1.Visibility = System.Windows.Visibility.Hidden;

        }

        private void checkBox2_Checked(object sender, RoutedEventArgs e)
        {
            A2.Visibility = System.Windows.Visibility.Visible;
        }

        private void checkBox2_Unchecked(object sender, RoutedEventArgs e)
        {
            A2.Visibility = System.Windows.Visibility.Hidden;
        }

        

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string str = textbox1.Text;
            if (str == "נסראללה")
            {
                textbox1.Foreground = Brushes.Red; 
            }
            else textbox1.Foreground = Brushes.Black ;
            //dfdfxcd

        }
    }
}
