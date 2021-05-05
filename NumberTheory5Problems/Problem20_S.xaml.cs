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
    /// Interaction logic for Problem20_S.xaml
    /// </summary>
    public partial class Problem20_S : Window
    {
        public Problem20_S()
        {
            InitializeComponent();
        }

        private void Button_Next_Click(object sender, RoutedEventArgs e)
        {
            Textbox_Output.Text = "";
            //Textbox_Output.Text = divisorsOfN(Convert.ToDouble(Textbox_n.Text)).ToString();
            double i = 1;
            double n = Convert.ToDouble(Textbox_n.Text);

            while(i < n + 1)
            {
                if(divisorsOfN(i) == divisorsOfN(i + 1))
                {
                    Textbox_Output.Text += "d(" + i + ") = " + divisorsOfN(i) + " and " + "d(" + i + " + 1) = " + divisorsOfN(i + 1) + " Twins" + Environment.NewLine;
                }
                if (divisorsOfN(i) == divisorsOfN(i + 1) & divisorsOfN(i) == divisorsOfN(i + 2))
                {
                    Textbox_Output.Text += "d(" + i + ") = " + divisorsOfN(i) + " , " + "d(" + i + " + 1) = " + divisorsOfN(i + 1) + " and d(" + i + " + 2) = " + divisorsOfN(i + 2) + " Triplets" + Environment.NewLine;
                }
                if (divisorsOfN(i) == divisorsOfN(i + 1) & divisorsOfN(i) == divisorsOfN(i + 2) && divisorsOfN(i) == divisorsOfN(i + 3))
                {
                    Textbox_Output.Text += "d(" + i + ") = " + divisorsOfN(i) + " , " + "d(" + i + " + 1) = " + divisorsOfN(i + 1) + ",  d(" + i + " + 2) = " + divisorsOfN(i + 2) + "and  d(" + i + " + 3) = " + divisorsOfN(i + 3) + " Quadruplets" + Environment.NewLine;
                }
                if (divisorsOfN(i) == divisorsOfN(i + 1) & divisorsOfN(i) == divisorsOfN(i + 2) && divisorsOfN(i) == divisorsOfN(i + 3) && divisorsOfN(i) == divisorsOfN(i + 4))
                {
                    Textbox_Output.Text += "d(" + i + ") = " + divisorsOfN(i) + " , " + "d(" + i + " + 1) = " + divisorsOfN(i + 1) + ",  d(" + i + " + 2) = " + divisorsOfN(i + 2) + ",  d(" + i + " + 3) = " + divisorsOfN(i + 3) + "and  d(" + i + " + 4) = " + divisorsOfN(i + 4) + " Quaintuplets" + Environment.NewLine;
                }
                i++;
            }
        }

        public static double divisorsOfN(double n)
        {
            double i = 1;
            double totalDivs = 0;

            while (i < n + 1)
            {
                if (n % i == 0)
                {
                    totalDivs += 1;
                }
                i++;
            }

            return totalDivs;
        }
    }
}
