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

namespace NumberTheory5Problems
{
    /// <summary>
    /// Interaction logic for Problem9_S.xaml
    /// </summary>
    public partial class Problem9_S : Window
    {
        public Problem9_S()
        {
            InitializeComponent();
        }

        private void Button_Next_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show(Convert.ToDouble(Textbox_n.Text).ToString());
            /*if(isPrime(Convert.ToDouble(Textbox_n.Text)) < 1)
            {
                Textbox_Output.Text = Textbox_n.Text + " is prime.";
            }
            else
            {
                Textbox_Output.Text = Textbox_n.Text + " is not prime." + Environment.NewLine;
                Textbox_Output.Text += isPrime(Convert.ToDouble(Textbox_n.Text)).ToString();


            }*/
            Textbox_Output.Text = "";
            double i = 2;
            double a = Convert.ToDouble(Textbox_a.Text);
            double p = Convert.ToDouble(Textbox_p.Text);

            while (i < a)
            {
                Textbox_Output.Text += formula(i, p);
                i++;
            }
            

            
            
            
        }

        public static string formula(double a, double p)
        {
            double m = 0;
            double fact = 0;
            double i = 1;
            double factR = 1;
            double total = 0;

            m = a * p;
            fact = m - 1;

            while(i < fact + 1)
            {
                factR = factR * i;
                i++;
            }

            total += factR % Math.Pow(p, a);

            return "(" + a + "*" + p + "-1" + ")! (mod " + p + "^" + a + ") = " + total + Environment.NewLine;
        }

        public static double isPrime(double n)
        {
            double sum = 0;
            double i = 2;
            while (i < n)
            {
                if(n % i == 0)
                {
                    sum += 1;
                }
                else
                {
                    sum += 0;
                }
                i++;
            }

            MessageBox.Show(sum.ToString());

            if(sum > 0)
            {
                return n;
            }
            else
            {
                return 0;
            }
        }

        private void Button_Next1_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Problem20 a = new Problem20();
            a.ShowDialog();
            this.Close();
        }
    }
}
