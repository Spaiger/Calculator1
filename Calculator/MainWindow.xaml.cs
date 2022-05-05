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

namespace Calculator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private bool zap = false;
        float fis, sec, thi, memory, sqrt, perc;
        int cou;
        private bool abs = true;
        private bool zero = true;
        private bool ecv = false;
        private bool zn = false;
        private bool cl;
        private void Button_Click_1(object sender, RoutedEventArgs e) //Number 1
        {
            if (zero)
            {
                Console.Clear();
            }
            if (cl)
            {
                Console.Clear();
            }
            Console.Text += "1";
            zero = false;
            ecv = false;
            cl = false;

        }
        private void Button_Click_2(object sender, RoutedEventArgs e) //Number 2
        {
            if (zero)
            {
                Console.Clear();
            }
            if (cl)
            {
                Console.Clear();
            }
            Console.Text += "2";
            zero = false;
            ecv = false;
            cl = false;

        }
        private void Button_Click_3(object sender, RoutedEventArgs e) //Number 3
        {
            if (zero)
            {
                Console.Clear();
            }
            if (cl)
            {
                Console.Clear();
            }
            Console.Text += "3";
            zero = false;
            ecv = false;
            cl = false;

        }
        private void Button_Click_4(object sender, RoutedEventArgs e) //Number 4
        {
            if (zero)
            {
                Console.Clear();
            }
            if (cl)
            {
                Console.Clear();
            }
            Console.Text += "4";
            zero = false;
            ecv = false;
            cl = false;

        }
        private void Button_Click_5(object sender, RoutedEventArgs e) //Number 5
        {
            if (zero)
            {
                Console.Clear();
            }
            if (cl)
            {
                Console.Clear();
            }
            Console.Text += "5";
            zero = false;
            ecv = false;
            cl = false;

        }
        private void Button_Click_6(object sender, RoutedEventArgs e) //Number 6
        {
            if (zero)
            {
                Console.Clear();
            }
            if (cl)
            {
                Console.Clear();
            }
            Console.Text += "6";
            zero = false;
            ecv = false;
            cl = false;

        }
        private void Button_Click_7(object sender, RoutedEventArgs e) //Number 7
        {
            if (zero)
            {
                Console.Clear();
            }
            if (cl)
            {
                Console.Clear();
            }
            Console.Text += "7";
            zero = false;
            ecv = false;
            cl = false;

        }
        private void Button_Click_8(object sender, RoutedEventArgs e) //Number 8
        {
            if (zero)
            {
                Console.Clear();
            }
            if (cl)
            {
                Console.Clear();
            }
            Console.Text += "8";
            zero = false;
            ecv = false;
            cl = false;

        }
        private void Button_Click_9(object sender, RoutedEventArgs e) //Number 9
        {
            if (zero)
            {
                Console.Clear();
            }
            if (cl)
            {
                Console.Clear();
            }
            Console.Text += "9";
            zero = false;
            ecv = false;

        }
        private void Button_Click_0(object sender, RoutedEventArgs e) //Number 0
        {
            if (zero)
            {
                Console.Clear();
            }
            if (cl)
            {
                Console.Clear();
            }
            Console.Text += "0";
            zero = false;
            ecv = false;
            cl = false;
        }
        
    }
}
