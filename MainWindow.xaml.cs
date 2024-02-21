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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        arthimetics arthi;
        public MainWindow()
        {
            InitializeComponent();
            arthi = new arthimetics();
        }
        private void main(object sender, RoutedEventArgs e)
        {
            Button x = sender as Button;
            tbxScreen.Text += x.Content;
            arthi.main(sender, e, tbxScreen.Text);
        }
    }
}
