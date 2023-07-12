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
    /// <summary>
    /// Interaction logic for buy_vehicle.xaml
    /// </summary>
    public partial class buy_vehicle : Window
    {
        public static double ModelAndMake, purchasePrice, totalDeposite, interestRate, insurancePremium;

        private void Button_Click_Cancel(object sender, RoutedEventArgs e)
        {
            Selection select = new Selection();
            Hide();
            select.ShowDialog();
            Show();
        }

        public static int PERIOD = 5;

        public buy_vehicle()
        {
            InitializeComponent();
        }
        public static double calculating_available_Money(double loanRepayment)
        {
            //Method of calculationg available money if the user choose to buy property 
            double available_money_after_deductions = MainWindow.monthly_income - MainWindow.tax - MainWindow.sum - loanRepayment;
            return available_money_after_deductions;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            ModelAndMake = Double.Parse(tx1.Text);
            purchasePrice = Double.Parse(tx2.Text);
            totalDeposite = Double.Parse(tx3.Text);
            interestRate = Double.Parse(tx4.Text);
            insurancePremium = Double.Parse(tx5.Text);
            if (interestRate > 0 && interestRate <= 100)
            {
                double principalAmount = purchasePrice - totalDeposite;
                double interest = interestRate / 100;
                var numberOfMonth = PERIOD * 12;
                //A = p(1 +in)
                var totalAmount = principalAmount * (1 + (interest * PERIOD));
                var loanRepayment = totalAmount / numberOfMonth;
                var total_monthly_cost = loanRepayment + insurancePremium;
                if (total_monthly_cost > MainWindow.third_income)
                {
                    Console.WriteLine(Math.Round(loanRepayment));
                    Console.WriteLine(Math.Round(total_monthly_cost));
                    Console.WriteLine("Your total expenses exeed 75% of your monthly income");
                    Console.ReadLine();
                    Close();
                }
                else
                {
                    MessageBox.Show(
                           "===================================================\n"
                         + "BUYING A VEHICLE\n"
                         + "===================================================\n"
                         + "Gross Monthly income: R" + Math.Round(MainWindow.monthly_income, 2)
                         + "\nEstimated monthly tax (before deducted): R" + Math.Round(MainWindow.tax, 2)
                         + "\n Total expenditures is: R" + MainWindow.sum
                         + "\n Total amount going to pay: R" + Math.Round(totalAmount, 2)
                         + "\n Monthly Repayment: R " + Math.Round(loanRepayment, 2)
                         + "\nThe available amount is(After Deductions) R" + Math.Round(calculating_available_Money(loanRepayment), 2)
                         + "\n================================================");
                    Close();
                }
            }

            }
    }
}
