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
    /// Interaction logic for Problem7_S.xaml
    /// </summary>
    public partial class Problem7_S : Window
    {
        public Problem7_S()
        {
            InitializeComponent();
        }

        private void Button_Next_Click(object sender, RoutedEventArgs e)
        {
            //string textB = isSemiPerfect(int.Parse(TextBox_n1.Text)).ToString();
            //string textN = TextBox_n1.Text;
            //int dog = 104 % 1;
            //Textbox_Output.Text = textN + " sum of n = " + textB;
            //Textbox_Output.Text = isSemiPerfect(int.Parse(TextBox_n1.Text)).ToString();
            //Textbox_Output.Text = isSemiPerfect(int.Parse(TextBox_n1.Text)).ToString();
            //if(isSemiPerfectIrreducible(int.Parse(TextBox_n1.Text)) == 0){
            //    Textbox_Output.Text = TextBox_n1.Text + " is an irreducible semiperferct integer";
            //}
            //else
            //{
            //    Textbox_Output.Text = TextBox_n1.Text + " is not an irreducible semiperferct integer";
            //}
            int i = 1;
            Textbox_Output.Text = "";
            while (i < int.Parse(TextBox_n1.Text))
            {
                
                if(isSemiPerfect(i) != 0)
                {
                    Textbox_Output.Text += "The number " + isSemiPerfect(i).ToString() + "is semi-perfect" + Environment.NewLine;
                    
                }
                i++;
            }

        }

        public static int isSemiPerfectIrreducible(int n)
        {
            int sum = 0;
            int output = 0;
            int y = 2;
            int irreducible = 0;

            while (y < n)
            {
                
                if (n % y == 0)
                {
                    if(isSemiPerfect(y) != 0 && isSemiPerfect(n) == n)
                    {
                        
                        //MessageBox.Show("y = " + isSemiPerfect(y).ToString());
                        
                    }
                    else
                    {
                        irreducible += 1;
                        //MessageBox.Show("No");
                        MessageBox.Show(irreducible.ToString());
                    }
                }
                y++;
            }

            MessageBox.Show(isSemiPerfect(y).ToString() + " -- " + n);

            
            MessageBox.Show(irreducible.ToString());

            if (irreducible == 1)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public static int isSemiPerfect(int n)
        {
            int sum = 0;
            int output = 0;
            int i = 1;
            int j = 1;
            int notyet = 0;

            while (i < n)
            {
                if (n % i == 0)
                {
                    sum += i;
                    //MessageBox.Show(sum.ToString());
                    
                }

                if (sum == n)
                {
                    output = sum;
                }
                else
                {
                    notyet = sum;
                }
               
                i++;
            }


            if (output != n)
            {
                while (j < n)
                {
                    if (n % j == 0)
                    {
                        sum -= j;
                        if (sum != n)
                        {
                            sum += j;
                        }
                        else
                        {
                            output = sum;

                        }
                    }

                    j++;
                }
            }

            if(output != sum)
            {
                output = 0;
            }

            return output;


        }

        private void Button_Next_Copy_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Problem8 a = new Problem8();
            a.ShowDialog();
            this.Close();
        }
    }
}
