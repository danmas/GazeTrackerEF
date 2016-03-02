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

namespace App1ForEF
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

        private void Button_MouseMove(object sender, MouseEventArgs e)
        {
            Point pt = e.GetPosition(this);
            if (sender is Button)
            {
                if (B00.Name == ((Button)sender).Name)
                {
                    Console.WriteLine("!!!!!!!! B00 " + sender.ToString() + "!!! " + String.Format("X: {0}, Y: {1}", pt.X, pt.Y));
                } else if (B01.Name == ((Button)sender).Name)
                {
                    Console.WriteLine("!!!!!!!! B01 " + sender.ToString() + "!!! " + String.Format("X: {0}, Y: {1}", pt.X, pt.Y));
                }
                else if (B10.Name == ((Button)sender).Name)
                {
                    Console.WriteLine("!!!!!!!! B10 " + sender.ToString() + "!!! " + String.Format("X: {0}, Y: {1}", pt.X, pt.Y));
                } else if (B11.Name == ((Button)sender).Name)
                {
                    Console.WriteLine("!!!!!!!! B11 " + sender.ToString() + "!!! " + String.Format("X: {0}, Y: {1}", pt.X, pt.Y));
                }
            }

        }

    }
}
