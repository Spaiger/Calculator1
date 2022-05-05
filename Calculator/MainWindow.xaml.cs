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
        private void Button_Click_zap(object sender, RoutedEventArgs e) //Запятая
        {
            if (zap)
            {
                return;
            }
            Console.Text += ",";
            zap = true;
        }
        private void Button_Click_plus(object sender, RoutedEventArgs e) //Operation plus
        {
            fis = float.Parse(Console.Text);
            cou = 1;
            /*if (!tap_plus)
            {
                fis = float.Parse(Console.Text);
                shows = fis;
            }
            if (tap_plus)
            {
                thi = float.Parse(Console.Text);
                shows = thi;
                operations(thi);
            }*/
            Console.Clear();
            if (zn)                                         //Добавление в предыдущие шаги
            {
                ShowSteps.Text += "+" + fis.ToString();
            }
            else
            {
                ShowSteps.Text += fis.ToString() + "+";
            }
            abs = true;
            zn = false;
            zap = false;
            cl = true;
            /*tap_plus = true;
            tap_minus = false;
            tap_multiplie = false;
            tap_delim = false;*/
        }
        private void Button_Click_minus(object sender, RoutedEventArgs e) //Operation minus
        {
            fis = float.Parse(Console.Text);
            Console.Clear();
            cou = 2;
            if (zn)                                         //Добавление в предыдущие шаги
            {
                ShowSteps.Text += "-" + fis.ToString();
            }
            else
            {
                ShowSteps.Text += fis.ToString() + "-";
            }
            abs = true;
            zn = false;
            zap = false;
            cl = true;
            /*tap_plus = false;
            tap_minus = true;
            tap_multiplie = false;
            tap_delim = false;*/
        }
        private void Button_Click_multiplie(object sender, RoutedEventArgs e) //Operation multiplie
        {
            fis = float.Parse(Console.Text);
            Console.Clear();
            cou = 3;
            if (zn)                                         //Добавление в предыдущие шаги
            {
                ShowSteps.Text += "*" + fis.ToString();
            }
            else
            {
                ShowSteps.Text += fis.ToString() + "*";
            }
            abs = true;
            zn = false;
            zap = false;
            cl = true; ;
            /*tap_plus = false;
            tap_minus = false;
            tap_multiplie = true;
            tap_delim = false;*/
        }
        private void Button_Click_delim(object sender, RoutedEventArgs e) //Operation delim
        {
            fis = float.Parse(Console.Text);
            Console.Clear();
            cou = 4;
            if (zn)                                         //Добавление в предыдущие шаги
            {
                ShowSteps.Text += "/" + fis.ToString();
            }
            else
            {
                ShowSteps.Text += fis.ToString() + "/";
            }
            abs = true;
            zap = false;
            zn = false;
            cl = true;
            /*tap_plus = false;
            tap_minus = false;
            tap_multiplie = false;
            tap_delim = true;*/
        }
        float c;
        private void Button_Click_ecv(object sender, RoutedEventArgs e) //Равно
        {
            float t = float.Parse(Console.Text);
            int i = 0;
            if (!ecv)
            {
                c = t;
                zero = true;
                ecv = true;
                if (i == 0)
                {
                    ShowSteps.Clear();
                    operations(t);
                }
                i++;
            }
            if (ecv)
            {
                ShowSteps.Clear();
                operations(c);
            }
            fis = float.Parse(Console.Text);
            zn = false;
            zap = false;
        }
        private void operations(float t) //Проведение вычисления
        {
            switch (cou)
            {
                case 1:
                    sec = fis + t;
                    Console.Text = sec.ToString();
                    break;
                case 2:
                    sec = fis - t;
                    Console.Text = sec.ToString();
                    break;
                case 3:
                    sec = fis * t;
                    Console.Text = sec.ToString();
                    break;
                case 4:
                    sec = fis / t;
                    Console.Text = sec.ToString();
                    break;
                default:
                    break;
            }
        }
        private void Button_Click_C(object sender, RoutedEventArgs e) //Полная очистка
        {
            fis = 0;
            sec = 0;
            thi = 0;
            perc = 0;
            sqrt = 0;
            cou = 0;
            Console.Text = "0";
            ShowSteps.Clear();
            cl = true;
            zn = false;
            zap = false;
        }
        private void Button_Click_CE(object sender, RoutedEventArgs e) //Очистка ввода
        {
            Console.Text = "0";
            zero = true;
            cl = true;
        }
        private void Button_Click_Eraser(object sender, RoutedEventArgs e) //Стереть один знак с конца
        {
            int len = Console.Text.Length - 1;
            string text = Console.Text;
            Console.Clear();
            for (int i = 0; i < len; i++)
            {
                Console.Text += text[i];
            }
        }
        private void Button_Click_abs(object sender, RoutedEventArgs e) //Изменение знака числа
        {
            char[] minus = {'-'};
            if (Console.Text == "0")
            {
                return;
            }
            if (Console.Text[0] == '-')
            {
                abs = false;
            }
            else
            {
                abs = true;
            }
            if (abs) //&& Console.Text[0] != '-')
            {
                Console.Text = "-" + Console.Text;
                //abs = false;
            }
            else if(!abs )//&& Console.Text[0] == '-')
            {
                Console.Text = Console.Text.TrimStart(minus);
                //abs = true;
            }
        }
        private void Button_Click_sqrt(object sender, RoutedEventArgs e) //Взятие квадратного корня из числа
        {
            sqrt = float.Parse(Console.Text);
            Console.Text = Convert.ToString(Math.Sqrt(sqrt));
            ShowSteps.Text += "sqrt(" + sqrt + ")";
            zn = true;
            zap = false;
        }
        private void Button_Click_percent(object sender, RoutedEventArgs e) //Операции с процентами от числа
        {
            perc = (fis / 100) * float.Parse(Console.Text);
            Console.Text = Convert.ToString(perc);
            ShowSteps.Text += Console.Text;
            zap = false;

        }
        private void Button_Click_1naX(object sender, RoutedEventArgs e) //Деление 1 на введёное число
        {
            float naX = float.Parse(Console.Text);
            ShowSteps.Text += "reciproc(" + naX + ")";
            float prom = 1 / naX;
            Console.Text = prom.ToString();
            zn = true;
            zap = false;
        }
        private void Button_Click_MC(object sender, RoutedEventArgs e) //Очистка памяти
        {
            memory = 0;
            MemoryShow.Clear();
        }
        private void Button_Click_MR(object sender, RoutedEventArgs e) //Вывод из памяти
        {
            Console.Clear();
            Console.Text = memory.ToString();
        }
        private void Button_Click_MS(object sender, RoutedEventArgs e) //Сохранение в память
        {
            memory = float.Parse(Console.Text);
            MemoryShow.Text = "M";
            cl = true;
        }
        private void Button_Click_Mplus(object sender, RoutedEventArgs e) //Прибавление к памяти
        {
            memory += float.Parse(Console.Text);
        }
        private void Button_Click_Mminus(object sender, RoutedEventArgs e) //Вычитание из памяти
        {
            memory -= float.Parse(Console.Text);
        }
    }
}
