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
using System.Globalization;


namespace Kalkulačka
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        string priklad = "";
        public MainWindow()
        {
           InitializeComponent();
            var window = Window.GetWindow(this);
            window.KeyDown += HandleKeyPress;

        }
        private void HandleKeyPress(object sender, KeyEventArgs e)
        {
            
            if (e.Key == Key.NumPad0)
            {
                priklad += "0";
                String.Text = priklad;
            }
            else if (e.Key == Key.NumPad1)
            {
                priklad += "1";
                String.Text = priklad;
            }
            else if (e.Key == Key.NumPad2)
            {
                priklad += "2";
                String.Text = priklad;
            }
            else if (e.Key == Key.NumPad3)
            {
                priklad += "3";
                String.Text = priklad;
            }
            else if (e.Key == Key.NumPad4)
            {
                priklad += "4";
                String.Text = priklad;
            }
            else if (e.Key == Key.NumPad5)
            {
                priklad += "5";
                String.Text = priklad;
            }
            else if (e.Key == Key.NumPad6)
            {
                priklad += "6";
                String.Text = priklad;
            }
            else if (e.Key == Key.NumPad7)
            {
                priklad += "7";
                String.Text = priklad;
            }
            else if (e.Key == Key.NumPad8)
            {
                priklad += "8";
                String.Text = priklad;
            }
            else if (e.Key == Key.NumPad9)
            {
                priklad += "9";
                String.Text = priklad;
            }
            else if (e.Key == Key.Divide)
            {
                priklad += "/";
                String.Text = priklad;
            }
            else if (e.Key == Key.Multiply)
            {
                priklad += "*";
                String.Text = priklad;
            }
            else if (e.Key == Key.Subtract)
            {
                priklad += "-";
                String.Text = priklad;
            }
            else if (e.Key == Key.Add)
            {
                priklad += "+";
                String.Text = priklad;
            }
            else if (e.Key == Key.Decimal)
            {
                priklad += ",";
                String.Text = priklad;
            }
            else if (e.Key == Key.Return)
            {
                Ask_Click(sender,e);
            }
            else if (e.Key == Key.Back)
            {
                if (priklad == "")
                {
                    
                }
                else
                {
                    priklad = priklad.Substring(0, priklad.Length - 1);
                    String.Text = priklad;
                }
            }

        
        }
        private void Ask_Click(object sender, RoutedEventArgs e)
        {
            priklad = priklad.Replace(" ", "");
            priklad = priklad.Replace("+", " + ");
            priklad = priklad.Replace("-", " - ");
            priklad = priklad.Replace("*", " * ");
            priklad = priklad.Replace("/", " / ");
            string[] numbers = priklad.Split(" ");
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] != "")
                {                
                    if (numbers[i] == "*")
                    {
                        int k = Plus(i, numbers);
                        double d = double.Parse(numbers[k]);
                        int j = Minus(i, numbers);
                        double p = double.Parse(numbers[j]);
                        numbers[i] = Convert.ToString(p * d);
                        numbers[k] = "";
                        numbers[j] = "";
                    }
                    if (numbers[i] == "/")
                    {
                        int k = Plus(i, numbers);
                        double d = double.Parse(numbers[k]);
                        int j = Minus(i, numbers);
                        double p = double.Parse(numbers[j]);
                        numbers[i] = Convert.ToString(p / d);
                        numbers[k] = "";
                        numbers[j] = "";
                    }
                }                
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] != "")
                {
                    if (numbers[i] == "+")
                    {
                        int k = Plus(i, numbers);
                        double d = double.Parse(numbers[k]);
                        int j = Minus(i, numbers);
                        double p = double.Parse(numbers[j]);
                        numbers[i] = Convert.ToString(p + d);
                        numbers[k] = "";
                        numbers[j] = "";
                    }
                    if (numbers[i] == "-")
                    {
                        int k = Plus(i, numbers);
                        double d = double.Parse(numbers[k]);
                        int j = Minus(i, numbers);
                        double p = double.Parse(numbers[j]);
                        numbers[i] = Convert.ToString(p - d);
                        numbers[k] = "";
                        numbers[j] = "";
                    }
                }
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] != "")
                {
                    Vysledek.Text = numbers[i];
                }
               
            }
            
        }

        private void String_TextChanged(object sender, TextChangedEventArgs e)
        {
            priklad = String.Text;
        }
        public int Minus(int i, string[] a)
        {
            while (true)
            {
                try
                {
                    double d = double.Parse(a[--i]);
                    return i;
                }
                catch (Exception)
                {
                    
                }
            }            
        }
        public int Plus(int i, string[] a)
        {
            while (i <= a.Length)
            {
                try
                {
                    double d = double.Parse(a[++i]);
                    return i;
                }
                catch (Exception)
                {
                    
                }
            }
            return -1;
        }

        private void Sev_Click(object sender, RoutedEventArgs e)
        {
            priklad += "7";
            String.Text = priklad;
        }

        private void Eig_Click(object sender, RoutedEventArgs e)
        {
            priklad += "8";
            String.Text = priklad;
        }

        private void Nin_Click(object sender, RoutedEventArgs e)
        {
            priklad += "9";
            String.Text = priklad;
        }

        private void Div_Click(object sender, RoutedEventArgs e)
        {
            priklad += "/";
            String.Text = priklad;
        }

        private void Fou_Click(object sender, RoutedEventArgs e)
        {
            priklad += "4";
            String.Text = priklad;
        }

        private void Fiv_Click(object sender, RoutedEventArgs e)
        {
            priklad += "5";
            String.Text = priklad;
        }

        private void Six_Click(object sender, RoutedEventArgs e)
        {
            priklad += "6";
            String.Text = priklad;
        }

        private void Tim_Click(object sender, RoutedEventArgs e)
        {
            priklad += "*";
            String.Text = priklad;
        }

        public void One_Click(object sender, RoutedEventArgs e)
        {
            priklad += "1";
            String.Text = priklad;
        }

        private void Two_Click(object sender, RoutedEventArgs e)
        {
            priklad += "2";
            String.Text = priklad;
        }

        private void Thr_Click(object sender, RoutedEventArgs e)
        {
            priklad += "3";
            String.Text = priklad;
        }

        private void Min_Click(object sender, RoutedEventArgs e)
        {
            priklad += "-";
            String.Text = priklad;
        }

        private void Plu_Click(object sender, RoutedEventArgs e)
        {
            priklad += "+";
            String.Text = priklad;
        }

        private void Zer_Click(object sender, RoutedEventArgs e)
        {
            priklad += "0";
            String.Text = priklad;
        }

        private void Dot_Click(object sender, RoutedEventArgs e)
        {
            priklad += ",";
            String.Text = priklad;
        }


    }
}
