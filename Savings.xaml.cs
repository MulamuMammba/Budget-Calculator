using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace POE
{
    public partial class Savings : Window
    {
        public static double PrincipleAmount, duration ;
        public Savings()
        {
            InitializeComponent();
        }

        private void Button_Click_Cancel(object sender, RoutedEventArgs e)
        {
            Selection select = new Selection();
            Hide();
            select.ShowDialog();
            Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            PrincipleAmount = double.Parse(tx1.Text);
            duration = double.Parse(tx3.Text);
            if (rd1.IsChecked == true)
            {
                var rate = 0.05;
                var numMonths = duration * 12;
                var totalAmount = PrincipleAmount * (1 + (rate * duration));
                var monthlySavings = totalAmount / numMonths;
                MessageBox.Show("**********************************\n" +
                    "DISPLAY OF MONTHLY SAVINGS\n" +
                    "********************************" +
                    "\nPrinciple Amount: r" + PrincipleAmount +
                    "\n Duration: " + duration + " years" +
                    "\n Reason: " + tx2.Text + 
                    "\n Interest: " + 5 + "% p/a" + 
                    "\n Total Amount: R" + totalAmount + 
                    "\n Monthly savings: R" + monthlySavings + 
                    "\n ******************************");
            }
            if (rd2.IsChecked == true)
            {
                var rate = 0.10;
                var numMonths = duration * 12;
                var totalAmount = PrincipleAmount * (1 + (rate * duration));
                var monthlySavings = totalAmount / numMonths;
                MessageBox.Show("**********************************\n" +
                    "DISPLAY OF MONTHLY SAVINGS\n" +
                    "********************************" +
                    "\nPrinciple Amount: r" + PrincipleAmount +
                    "\n Duration: " + duration + " years" +
                    "\n Reason: " + tx2.Text +
                    "\n Interest: " + 10 + "% p/a" +
                    "\n Total Amount: R" + totalAmount +
                    "\n Monthly savings: R" + monthlySavings +
                    "\n ******************************");
            }
            if (rd3.IsChecked == true)
            {
                var rate = 0.15;
                var numMonths = duration * 12;
                var totalAmount = PrincipleAmount * (1 + (rate * duration));
                var monthlySavings = totalAmount / numMonths;
                MessageBox.Show("**********************************\n" +
                    "DISPLAY OF MONTHLY SAVINGS\n" +
                    "********************************" +
                    "\nPrinciple Amount: R" + PrincipleAmount +
                    "\n Duration: " + duration + " years" + 
                    "\n Reason: " + tx2.Text +
                    "\n Interest: " + 15 + "% p/a" +
                    "\n Total Amount: R" + totalAmount +
                    "\n Monthly savings: R" + monthlySavings +
                    "\n ******************************");
            }
        }
    }
}
