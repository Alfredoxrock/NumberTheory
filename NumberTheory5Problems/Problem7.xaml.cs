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
    /// Interaction logic for Problem7.xaml
    /// </summary>
    public partial class Problem7 : Window
    {
        public Problem7()
        {
            InitializeComponent();
        }

        private void Button_Next1_Click_1(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Problem7_S a = new Problem7_S();
            a.ShowDialog();
            this.Close();
        }
    }
}
