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

namespace LAB01_Solutions
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double income = double.Parse(tbIncome.Text);
                double paid = double.Parse(tbPaid.Text);
                uint percent = uint.Parse(tbTax.Text);

                uint computed = (uint)((paid / income) * 100);

                MessageBox.Show(computed < percent ? "Undperpaid" : computed == percent ? "Equal Paid" : "OverPaid");
            }
            catch(FormatException)
            {
                MessageBox.Show("Invalid Inputs");
            }
            catch(OverflowException)
            {
                MessageBox.Show("Too Big Numbers");
            }
            e.Handled = true;
        }
    }
}
