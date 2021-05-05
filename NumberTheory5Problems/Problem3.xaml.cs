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
using System.Windows.Shapes;
using System.Windows.Threading;

namespace NumberTheory5Problems
{
    /// <summary>
    /// Interaction logic for Problem3.xaml
    /// </summary>
    public partial class Problem3 : Window
    {
        public static System.Timers.Timer _timer;
        public Problem3()
        {
            InitializeComponent();
        }

        private void Button_Next_Click(object sender, RoutedEventArgs e)
        {
            //Textbox_Output.Text = "RUNNING PROGRAM";
            int n = 1;
            string mytext = "";
            //int o = int.Parse(TextBox_n.Text);
            Textbox_Output.Text = "";

            //value = n / 10;
            //Textbox_Output.Text = Factorial(1).ToString() + " " + Factorial(4).ToString() + " " + Factorial(5).ToString();
            //Textbox_Output.Text = value.ToString();
            //Textbox_Output.Text = Output(n);
            while (n < int.Parse(TextBox_n.Text))
            {
                Textbox_Output.Text += Output(n);
                n++;
            }

            //Textbox_Output.Text = o.ToString();

            //Textbox_Output.Text = Output(145);

            //System.Threading.Thread.Sleep(200);
            //Textbox_Output.Text = "Factorial of " + n.ToString() + " = " + Factorial(n);
            Dispatcher.Invoke(new Action(() => { }), DispatcherPriority.ContextIdle, null);
          
            //Textbox_Output.Text = "DONE RUNNING";
        }


        public static string Output(int n)
        {
            string output = "";
            int sum = 0;
            int total = n;
            int tempDigit = 0;
            string parts = "";
            string no = "Didn't work";

            while (n > 0)
            {
                tempDigit = n % 10;
                parts += "!" + tempDigit + " ";
                sum = sum + Factorial(tempDigit);
                n = n / 10;
            }

            if (total == sum)
            {

                return output += total + " = " + Reverse(parts) + " = " + sum + Environment.NewLine;
            }
            else
            {
                return "";
            }
            

        }

        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public static int Factorial(int n)
        {
            int index = 1;
            int fact = 1;
            while (index < n + 1)
            {
                fact = fact * index;
                index++;
            }
            return fact;
        }

        private void Button_Check_Click(object sender, RoutedEventArgs e)
        {
            Textbox_Output.Text = "";
            int k = int.Parse(Textbox_k.Text);
            int i = 1;
            while (i < k + 1)
            {
                Textbox_Output.Text += checks(int.Parse(Textbox_nn.Text), i);
                i++;
            }

        }

        public string checks(int n, int k)
        {
            string output = "";
            n = int.Parse(Textbox_nn.Text);
            k = int.Parse(Textbox_k.Text);
            int i = 1;
            int sum = 0;
            while (i < k + 1)
            {
                sum += Convert.ToInt32(Math.Pow(n, i));
                i++;
            }
            if (Factorial(n) == sum)
            {
                return output += "K! = " + Factorial(n) + "  and the sum of " + TextBox_n.Text + " raise to " + Textbox_k + " = " + sum + Environment.NewLine;
            }
            else
            {
                return "no" + Environment.NewLine;
            }
        }

        private void Button_Next1_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Problem7 a = new Problem7();
            a.ShowDialog();
            this.Close();
        }
    }
}
