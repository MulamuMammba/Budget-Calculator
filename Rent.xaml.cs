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

    public partial class Rent : Window
    {
        
        public Rent()
        {
            InitializeComponent();
            
        }
       

        private void Button_Click(object sender, RoutedEventArgs e)
         {

            Hide();
            double rent = double.Parse(tx1.Text);
            double remAmount = MainWindow.remainingAmount - rent;
            MessageBox.Show(
                "*************************************************************************\n" +
                "DISPLAYING OUTPUT OF RENT ACCOMMODATION\n" +
                "*************************************************************************\n" +
                "Groos Monthly Income: R" + MainWindow.monthly_income + "\n" +
                "Monthly tax deducted: R" + MainWindow.tax + "\n" +
                "Groceries: R" + MainWindow.Groceries + "\n" +
                "Water and lights: R" + MainWindow.waterAndLights + "\n" +
                "Travel costs (including petrol): R" + MainWindow.travelCosts + "\n" +
                "Cell phone and telephone: R" + MainWindow.phone + "\n" +
                "Other expenses: R" + MainWindow.otherExpenses + "\n" +
                "Rent Amount: R" + rent + "\n" +
                "Remaining amount After All deduction(including Rent: R" + remAmount + "\n" +
                "*************************************************************************");
           
        }

        private void Button_Click_Cancel(object sender, RoutedEventArgs e)
        {
            Selection select = new Selection();
            Hide();
            select.ShowDialog();
            Show();
        }

        private void tx1_Error(object sender, ValidationErrorEventArgs e)
        {

        }
    }
}
