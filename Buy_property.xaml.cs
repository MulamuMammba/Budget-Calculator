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
    /// Interaction logic for Buy_property.xaml
    /// </summary>
    public partial class Buy_property : Window
    {
        public static double total, purchase_price, interest, total_deposite;
        public static int months;

        private void Button_Click_Cancel(object sender, RoutedEventArgs e)
        {
            Selection select = new Selection();
            Hide();
            select.ShowDialog();
            Show();
        }

        public Buy_property()
        {
            InitializeComponent();
        }
        public static double calculating_available_Money(double monthly_repayment)
        { 
            double available_money_after_deductions = MainWindow.monthly_income - MainWindow.tax - MainWindow.sum - monthly_repayment;
            return available_money_after_deductions;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            purchase_price = Double.Parse(tx1.Text);
            total_deposite = Double.Parse(tx2.Text);
            interest = Double.Parse(tx3.Text);
            months = int.Parse(tx4.Text);

            if (interest > 0 && interest <= 100)
            {
                if (months >= 240 && months <= 360)
                {
                    total = purchase_price - total_deposite;
                    var years = months / 12;
                    var interestValue = interest / 100;
                    double amount = total * (1 + (interestValue * years));
                    double monthly_repayment = amount / months;

                    //Check if monthy repayment is greater than third income
                    if (monthly_repayment > MainWindow.third_income)
                    {
                        //If it is greater than it will print the following statement
                        MessageBox.Show("The approval of the home loan is unlikely");
                        Close();
                    }
                    else 
                    {
                        /*Printing the available money after deductions has been made the calculations occars in the method
                           called calculating_available_Money
                        */
                        MessageBox.Show(
                            "==================================================\n"
                          + "BUYING A PROPERTY\n"
                          + "==================================================\n"
                          + "Gross Monthly income: R" + Math.Round(MainWindow.monthly_income, 2)
                          + "\nEstimated monthly tax (before deducted): R" + Math.Round(MainWindow.tax, 2)
                          + "\n Total expenditures is: R" + MainWindow.sum
                          + "\n Total amount going to pay: R" + Math.Round(amount, 2)
                          + "\n Monthly Repayment: R " + Math.Round(monthly_repayment, 2)
                          + "\nThe available amount is(After Deductions) R" + Math.Round(calculating_available_Money(monthly_repayment), 2)
                          + "\n===============================================");
                        Close();

                    }
                }
                else
                {
                    //If user entered incorrect number of months
                    MessageBox.Show("The number of month is correct (between 240 and 360)");
                   
                }//end of else statement for number of months
            }//End of if statement for interest
            else
            {
                MessageBox.Show("Percetage is equal to 100 you can't have percent less than 0 or greater than 100:");
               
            }
        }
        }
    }
