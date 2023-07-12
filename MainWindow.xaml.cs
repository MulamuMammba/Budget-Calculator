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

namespace POE
{
 
    public partial class MainWindow : Window
    {
        public static double monthly_income, tax, Groceries, waterAndLights, travelCosts, phone, 
            otherExpenses, remainingAmount, third_income, sum;
        public MainWindow()
        {
            InitializeComponent();
          
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (tx1.Text.Length == 0 || tx2.Text.Length == 0)
            {
                MessageBox.Show("The is a missing field, please fill on all fields");
            }
            else if (tx3.Text.Length == 0 || tx4.Text.Length == 0)
            {
                MessageBox.Show("The is a missing field, please fill on all fields");
            }
            else if (tx5.Text.Length == 0 || tx6.Text.Length == 0 || tx7.Text.Length == 0)
            {
                MessageBox.Show("The is a missing field, please fill on all fields");
            }
            else
            {
                Selection sel = new Selection();
                Close();
                monthly_income = double.Parse(tx1.Text);
                tax = double.Parse(tx2.Text);
                Groceries = double.Parse(tx3.Text);
                waterAndLights = double.Parse(tx4.Text);
                travelCosts = double.Parse(tx5.Text);
                phone = double.Parse(tx6.Text);
                otherExpenses = double.Parse(tx7.Text);
                remainingAmount = monthly_income - tax - Groceries - waterAndLights - travelCosts - phone - otherExpenses;
                third_income = remainingAmount * 0.75;
                sum = Groceries + waterAndLights + travelCosts + phone + otherExpenses;
                sel.lb2.Content = remainingAmount;
                sel.ShowDialog();
            }
        }
    }
}
