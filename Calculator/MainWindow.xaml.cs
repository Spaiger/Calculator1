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
        float fis,memory, sqrt, perc, def;
        int cou;
        bool bd = false;
        private bool abs = true;
        private bool zero = true;
        private bool ecv = false;
        private bool zn = false;
        private bool cl = true;
        private bool fp = true;
        private void Button_Click_1(object sender, RoutedEventArgs e) //Number 1
        {
            if (bd) return;
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
            if (bd) return;
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
            if (bd) return;
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
            if (bd) return;
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
            if (bd) return;
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
            if (bd) return;
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
            if (bd) return;
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
            if (bd) return;
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
            if (bd) return;
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
            cl = false;
        }
        private void Button_Click_0(object sender, RoutedEventArgs e) //Number 0
        {
            if (bd) return;
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
            if (bd) return;
            if (zap)
            {
                return;
            }
            Console.Text += ",";
            zap = true;
        }
        private void Button_Click_plus(object sender, RoutedEventArgs e) //Operation plus
        {
            if (bd) return;
            if (fp)
            {
                def = float.Parse(Console.Text);
                ShowSteps.Text += def.ToString() + "+";
                fp = false;
                zn = false;
                zap = false;
                cl = true;
                cou = 1;
                return;
            }
            fis = float.Parse(Console.Text);
            switch (cou)
            {
                case 1:
                    def += fis;
                    Console.Text = def.ToString();
                    break;
                case 2:
                    def -= fis;
                    Console.Text = def.ToString();
                    break;
                case 3:
                    def *= fis;
                    Console.Text = def.ToString();
                    break;
                case 4:
                    def /= fis;
                    Console.Text = def.ToString();
                    break;
            }
            if (zn)                                         //Добавление в предыдущие шаги
            {
                ShowSteps.Text += "+";
            }
            else
            {
                ShowSteps.Text += fis.ToString() + "+";
            }
            cou = 1;
            zn = false;
            zap = false;
            cl = true;
        }
        private void Button_Click_minus(object sender, RoutedEventArgs e) //Operation minus
        {
            if (bd) return;
            if (fp)
            {
                def = float.Parse(Console.Text);
                ShowSteps.Text += def.ToString() + "-";
                fp = false;
                zn = false;
                zap = false;
                cl = true;
                cou = 2;
                return;
            }
            fis = float.Parse(Console.Text);
            switch (cou)
            {
                case 1:
                    def += fis;
                    Console.Text = def.ToString();
                    break;
                case 2:
                    def -= fis;
                    Console.Text = def.ToString();
                    break;
                case 3:
                    def *= fis;
                    Console.Text = def.ToString();
                    break;
                case 4:
                    def /= fis;
                    Console.Text = def.ToString();
                    break;
            }
            if (zn)                                         //Добавление в предыдущие шаги
            {
                ShowSteps.Text += "-";
            }
            else
            {
                ShowSteps.Text += fis.ToString() + "-";
            }
            cou = 2;
            zn = false;
            zap = false;
            cl = true;
        }
        private void Button_Click_multiplie(object sender, RoutedEventArgs e) //Operation multiplie
        {
            if (bd) return;
            if (fp)
            {
                def = float.Parse(Console.Text);
                ShowSteps.Text += def.ToString() + "*";
                fp = false;
                zn = false;
                zap = false;
                cl = true;
                cou = 3;
                return;
            }
            fis = float.Parse(Console.Text);
            switch (cou)
            {
                case 1:
                    def += fis;
                    Console.Text = def.ToString();
                    break;
                case 2:
                    def -= fis;
                    Console.Text = def.ToString();
                    break;
                case 3:
                    def *= fis;
                    Console.Text = def.ToString();
                    break;
                case 4:
                    def /= fis;
                    Console.Text = def.ToString();
                    break;
            }
            if (zn)                                         //Добавление в предыдущие шаги
            {
                ShowSteps.Text += "*";
            }
            else
            {
                ShowSteps.Text += fis.ToString() + "*";
            }
            cou = 3;
            zn = false;
            zap = false;
            cl = true;
        }
        private void Button_Click_delim(object sender, RoutedEventArgs e) //Operation delim
        {
            if (bd) return;
            if (fp)
            {
                def = float.Parse(Console.Text);
                ShowSteps.Text += def.ToString() + "/";
                fp = false;
                zn = false;
                zap = false;
                cl = true;
                cou = 4;
                return;
            }
            fis = float.Parse(Console.Text);
            switch (cou)
            {
                case 1:
                    def += fis;
                    Console.Text = def.ToString();
                    break;
                case 2:
                    def -= fis;
                    Console.Text = def.ToString();
                    break;
                case 3:
                    def *= fis;
                    Console.Text = def.ToString();
                    break;
                case 4:
                    def /= fis;
                    Console.Text = def.ToString();
                    break;
            }
            if (zn)                                         //Добавление в предыдущие шаги
            {
                ShowSteps.Text += "/";
            }
            else
            {
                ShowSteps.Text += fis.ToString() + "/";
            }
            cou = 4;
            zn = false;
            zap = false;
            cl = true;
        }
        private void Button_Click_ecv(object sender, RoutedEventArgs e) //Равно
        {
            if (!ecv)
            {
                fis = float.Parse(Console.Text);
                ShowSteps.Clear();
                switch (cou)
                {
                    case 1:
                        def += fis;
                        Console.Text = def.ToString();
                        cou = 1;
                        break;
                    case 2:
                        def -= fis;
                        Console.Text = def.ToString();
                        cou = 2;
                        break;
                    case 3:
                        def *= fis;
                        Console.Text = def.ToString();
                        cou = 3;
                        break;
                    case 4:
                        def /= fis;
                        Console.Text = def.ToString();
                        cou = 4;
                        break;
                    default:
                        Console.Text = def.ToString();
                        break;
                }
                zero = true;
                ecv = true;
                zn = false;
                zap = false;
                fp = true;
                bd = false;
                return;
            }
            else
            {
                switch (cou)
                {
                    case 1:
                        def += fis;
                        Console.Text = def.ToString();
                        cou = 1;
                        break;
                    case 2:
                        def -= fis;
                        Console.Text = def.ToString();
                        cou = 2;
                        break;
                    case 3:
                        def *= fis;
                        Console.Text = def.ToString();
                        cou = 3;
                        break;
                    case 4:
                        def /= fis;
                        Console.Text = def.ToString();
                        cou = 4;
                        break;
                    case 5:
                        Button_Click_sqrt(buttonSqrt, null);
                        cou = 5;
                        break;
                    case 6:
                        Button_Click_1naX(button1naX, null);
                        cou = 6;
                        break;
                    default:
                        return;
                }

            }
            bd = false;
            zn = false;
            zap = false;
            fp = true;
        }
        /*private void Operations(float t) //Проведение вычисления
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
        }*/
        private void Button_Click_C(object sender, RoutedEventArgs e) //Полная очистка
        {
            if (bd) return;
            fis = 0;
            perc = 0;
            sqrt = 0;
            cou = 0;
            def = 0;
            Console.Text = "0";
            ShowSteps.Clear();
            zero = true;
            ecv = false;
            cl = true;
            fp = true;
            zn = false;
            zap = false;
        }
        private void Button_Click_CE(object sender, RoutedEventArgs e) //Очистка ввода
        {
            if (bd) return;
            Console.Text = "0";
            zero = true;
            cl = true;
        }
        private void Button_Click_Eraser(object sender, RoutedEventArgs e) //Стереть один знак с конца
        {
            if (bd) return;
            int len = Console.Text.Length - 1;
            if (len == 0)
            {
                Console.Text = "0";
                zero = true;
                return;
            }
            string text = Console.Text;
            Console.Clear();
            for (int i = 0; i < len; i++)
            {
                Console.Text += text[i];
            }
        }
        private void Button_Click_abs(object sender, RoutedEventArgs e) //Изменение знака числа
        {
            if (bd) return;
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
            if (abs)
            {
                Console.Text = "-" + Console.Text;
                
            }
            else if(!abs)
            {
                Console.Text = Console.Text.TrimStart(minus);
                
            }
        }
        private void Button_Click_sqrt(object sender, RoutedEventArgs e) //Взятие квадратного корня из числа
        {
            if (bd) return;
            cou = 5;
            sqrt = float.Parse(Console.Text);
            if (fp)
            {
                def = float.Parse(Convert.ToString(Math.Sqrt(sqrt)));
            }
            else
            {
                def += float.Parse(Convert.ToString(Math.Sqrt(sqrt)));
            }
            Console.Text = Convert.ToString(Math.Sqrt(sqrt));
            ShowSteps.Text += "sqrt(" + sqrt + ")";
            zn = true;
            zap = false;
            fp = false;
        }
        private void Button_Click_percent(object sender, RoutedEventArgs e) //Операции с процентами от числа
        {
            if (bd) return;
            perc = (def / 100) * float.Parse(Console.Text);
            Console.Text = Convert.ToString(perc);
            ShowSteps.Text += Console.Text;
            zap = false;

        }
        private void Button_Click_1naX(object sender, RoutedEventArgs e) //Деление 1 на введёное число
        {
            if (bd) return;
            cou = 6;
            float naX = float.Parse(Console.Text);
            ShowSteps.Text += "reciproc(" + naX + ")";
            if (fp)
            {
                def = 1 / naX;
            }
            else
            {
                def += 1 / naX;
            }
            Console.Text = Convert.ToString(1/naX);
            zn = true;
            zap = false;
            fp = false;
        }
        private void Button_Click_MC(object sender, RoutedEventArgs e) //Очистка памяти
        {
            if (bd) return;
            memory = 0;
            MemoryShow.Clear();
        }
        private void Button_Click_MR(object sender, RoutedEventArgs e) //Вывод из памяти
        {
            if (bd) return;
            Console.Clear();
            Console.Text = memory.ToString();
        }
        private void Button_Click_MS(object sender, RoutedEventArgs e) //Сохранение в память
        {
            if (bd) return;
            memory = float.Parse(Console.Text);
            MemoryShow.Text = "M";
            cl = true;
        }
        private void Button_Click_Mplus(object sender, RoutedEventArgs e) //Прибавление к памяти
        {
            if (bd) return;
            memory += float.Parse(Console.Text);
        }
        private void Button_Click_Mminus(object sender, RoutedEventArgs e) //Вычитание из памяти
        {
            if (bd) return;
            memory -= float.Parse(Console.Text);
        }
        private void Grid_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.Key == Key.NumPad0) || (e.Key == Key.D0))
            {
                Button_Click_0(button0, null);
            } //Number 0
            if ((e.Key == Key.NumPad1) || (e.Key == Key.D1))
            {
                Button_Click_1(button1, null);
            } //Number 1
            if ((e.Key == Key.NumPad2) || (e.Key == Key.D2))
            {
                Button_Click_2(button2, null);
            } //Number 2
            if ((e.Key == Key.NumPad3) || (e.Key == Key.D3))
            {
                Button_Click_3(button3, null);
            } //Number 3
            if ((e.Key == Key.NumPad4) || (e.Key == Key.D4))
            {
                Button_Click_4(button4, null);
            } //Number 4
            if ((e.Key == Key.NumPad5) || (e.Key == Key.D5 && e.KeyboardDevice.Modifiers != ModifierKeys.Shift))
            {
                Button_Click_5(button5, null);
            } //Number 5
            if ((e.Key == Key.NumPad6) || (e.Key == Key.D6))
            {
                Button_Click_6(button6, null);
            } //Number 6
            if ((e.Key == Key.NumPad7) || (e.Key == Key.D7))
            {
                Button_Click_7(button7, null);
            } //Number 7
            if ((e.Key == Key.NumPad8) || (e.Key == Key.D8 && e.KeyboardDevice.Modifiers != ModifierKeys.Shift))
            {
                Button_Click_8(button8, null);
            } //Number 8
            if ((e.Key == Key.NumPad9) || (e.Key == Key.D9))
            {
                Button_Click_9(button9, null);
            } //Number 9
            if ((e.Key == Key.Multiply) || (e.KeyboardDevice.Modifiers == ModifierKeys.Shift && e.Key == Key.D8))
            {
                Button_Click_multiplie(buttonMultiplie, null);
            } //Умножение
            if (e.Key == Key.D5 && e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
            {
                Button_Click_percent(buttonPerc, null);
            } //Процент
            if (e.Key == Key.OemMinus)
            {
                Button_Click_minus(buttonMinus, null);
            } //Минус в верхнем ряду
            if (e.Key == Key.OemPlus && e.KeyboardDevice.Modifiers != ModifierKeys.Shift)
            {
                Button_Click_plus(buttonPlus, null);
            } //Плюс в верхнем ряду
            if (e.Key == Key.OemPlus && e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
            {
                Button_Click_ecv(buttonEnter, null);
            } //Равно в верхнем ряду
            if (e.Key == Key.Enter)
            {
                //bd = true;
                Button_Click_ecv(buttonEnter, null);
            } //Равно
            if (e.Key == Key.Back) 
            {
                Button_Click_Eraser(buttonBackspace, null); //Почему-то не работает!!!!!
            } //Стереть один знак с конца
            if (e.Key == Key.Add) 
            {
                Button_Click_plus(buttonPlus, null);
            } //Плюс
            if (e.Key == Key.Subtract) //Минус
            {
                Button_Click_minus(buttonMinus, null);
            }
            if (e.Key == Key.Divide) //Деление
            {
                Button_Click_delim(buttonDelim, null);
            }
            if (e.Key == Key.OemComma || e.Key == Key.Decimal) //Запятая
            {
                Button_Click_zap(buttonDot, null);
            }
            
        }//Использование клавиш клавиатуры 
    }
}
