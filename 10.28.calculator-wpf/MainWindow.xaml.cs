using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
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

namespace _10._28.calculator_wpf
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

        private void button0_Click(object sender, RoutedEventArgs e)
        {
            if (numberBox.Text != "0")
            {
                numberBox.Text += "0";
            }
        }
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (numberBox.Text == "0")
            {
                numberBox.Text = String.Empty;
            }
            numberBox.Text += "1";
        }
        private void button2_Click(object sender, RoutedEventArgs e)
        {
            if (numberBox.Text == "0")
            {
                numberBox.Text = String.Empty;
            }
            numberBox.Text += "2";
        }
        private void button3_Click(object sender, RoutedEventArgs e)
        {
            if (numberBox.Text == "0")
            {
                numberBox.Text = String.Empty;
            }
            numberBox.Text += "3";
        }
        private void button4_Click(object sender, RoutedEventArgs e)
        {
            if (numberBox.Text == "0")
            {
                numberBox.Text = String.Empty;
            }
            numberBox.Text += "4";
        }
        private void button5_Click(object sender, RoutedEventArgs e)
        {
            if (numberBox.Text == "0")
            {
                numberBox.Text = String.Empty;
            }
            numberBox.Text += "5";
        }
        private void button6_Click(object sender, RoutedEventArgs e)
        {
            if (numberBox.Text == "0")
            {
                numberBox.Text = String.Empty;
            }
            numberBox.Text += "6";
        }
        private void button7_Click(object sender, RoutedEventArgs e)
        {
            if (numberBox.Text == "0")
            {
                numberBox.Text = String.Empty;
            }
            numberBox.Text += "7";
        }
        private void button8_Click(object sender, RoutedEventArgs e)
        {
            if (numberBox.Text == "0")
            {
                numberBox.Text = String.Empty;
            }
            numberBox.Text += "8";
        }
        private void button9_Click(object sender, RoutedEventArgs e)
        {
            if (numberBox.Text == "0")
            {
                numberBox.Text = String.Empty;
            }
            numberBox.Text += "9";
        }

        private void buttonDiv_Click(object sender, RoutedEventArgs e)
        {
            equationBox.Text += numberBox.Text;
            equationBox.Text += "/";
            numberBox.Text = "0";
        }

        private void buttonMul_Click(object sender, RoutedEventArgs e)
        {
            equationBox.Text += numberBox.Text;
            equationBox.Text += "*";
            numberBox.Text = "0";
        }

        private void buttonMinus_Click(object sender, RoutedEventArgs e)
        {
            equationBox.Text += numberBox.Text;
            equationBox.Text += "-";
            numberBox.Text = "0";
        }

        private void buttonPlus_Click(object sender, RoutedEventArgs e)
        {
            equationBox.Text += numberBox.Text;
            equationBox.Text += "+";
            numberBox.Text = "0";
        }

        private void buttonDot_Click(object sender, RoutedEventArgs e)
        {
            if (!numberBox.Text.Contains("."))
            {
                numberBox.Text += ".";
            }
        }

        private void buttonEq_Click(object sender, RoutedEventArgs e)
        {
            equationBox.Text += numberBox.Text;
            numberBox.Text = new DataTable().Compute(equationBox.Text, null).ToString().Replace(',', '.');
            equationBox.Text = String.Empty;
        }

        private void buttonBackspace_Click(object sender, RoutedEventArgs e)
        {
            if (numberBox.Text.Length <= 1)
            {
                numberBox.Text = "0";
            }
            else
            {
                numberBox.Text = numberBox.Text.Remove(numberBox.Text.Length - 1);
            }
        }

        private void buttonCE_Click(object sender, RoutedEventArgs e)
        {
            numberBox.Text = "0";
        }

        private void buttonC_Click(object sender, RoutedEventArgs e)
        {
            numberBox.Text = "0";
            equationBox.Text=String.Empty;
        }
    }
}
