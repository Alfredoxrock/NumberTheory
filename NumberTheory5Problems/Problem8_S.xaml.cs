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
    /// Interaction logic for Problem8_S.xaml
    /// </summary>
    public partial class Problem8_S : Window
    {
        public Problem8_S()
        {
            InitializeComponent();
        }

        private void Button_Next_Click(object sender, RoutedEventArgs e)
        {
            double nMax = Convert.ToDouble(Textbox_n.Text);
            double kMax = Convert.ToDouble(Textbox_k.Text);
            double powN = Convert.ToDouble(Textbox_powN.Text);
            double powK = Convert.ToDouble(Textbox_PowK.Text);
            double i = 1;
            double j = 1;
            Textbox_Output.Text = "";

            while(i < nMax + 1)
            {
                
                while(j < kMax + 1)
                {
                    Textbox_Output.Text += areTheyEqual(i, j, powN, powK);
                    //MessageBox.Show("(" + i + "," + j + ")");
                    j++;
                    
                }
                j = 1;
                i++;
            }

            
        }

        

        public string areTheyEqual(double n, double k, double pow_N, double pow_K)
        {
            double i = 1;
            double j = 1;
            double sumN = 0;
            double sumK = 0;
            double powN = pow_N;
            double powK = pow_K;

            while(i < n + 1)
            {
                sumN += Math.Pow(i, powN);
                i++;
            }

            while(j < k + 1)
            {
                sumK += Math.Pow(j, powK);
                j++;
            }

            if(sumN == 1 && sumK == 1 && sumN == sumK)
            {
                return n + "^" + powN +
                    " = " + sumN.ToString() + " equal to " + k + "^" + powK + " = " + sumK + Environment.NewLine;
            }
            else if(sumN == sumK)
            {
                return "1^" + powN + " + 2^" + powN + " +...+ " + n + "^" + powN +
                   " = " + sumN.ToString() + " equal to " + "1^" + powK + " + 2^"
                   + powK + " +...+ " + k + "^" + powK + " = " + sumK + Environment.NewLine;
            }
            else
            {
                //return "not equal" + "sumN= " + " " + n + " " + " powerN " + powN + "----" + +sumN + "  " + "sumk=" + sumK;
                //return "n= " + n + " -- " + "powN= " + powN + " -" + sumN + "-"+ "k= " + k + " -- " + "powk= " + powK + " -" +sumK + "-";
                return "";
            }

        }

        private void Button_Next1_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Problem9 a = new Problem9();
            a.ShowDialog();
            this.Close();
        }
    }
}
