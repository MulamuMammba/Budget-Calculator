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
    /// Interaction logic for Selection.xaml
    /// </summary>
    public partial class Selection : Window
    {
        public Selection()
        {
            InitializeComponent();
            this.Closed += MainWindow_Closed;
            this.Closing += MainWindow_Closing;
        }
        private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // See if the user really wants to shut down this window.
            string msg = "Do you want to close this window";
            MessageBoxResult result = MessageBox.Show(msg,
            "My App", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (result == MessageBoxResult.No)
            {
                // If user doesn't want to close, cancel closure.
                e.Cancel = true;
            }
        }
        private void MainWindow_Closed(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you!!!!!!!!");
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            if (rd1.IsChecked == true) 
            {              
                Rent rnt = new Rent();
                Hide();
                rnt.ShowDialog();
                Show();
            }
            if (rd2.IsChecked == true)
            {
                Buy_property property = new Buy_property();
                Hide();
                property.ShowDialog();
                Show();
            }
            if (rd3.IsChecked == true) 
            {
                buy_vehicle vehicle = new buy_vehicle();
                Hide();
                vehicle.ShowDialog();
                Show();
            }
            if (rd4.IsChecked == true)
            {
                Savings save = new Savings();
                Hide();
                save.ShowDialog();
                Show();
            }
            this.Hide();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            Hide();
            main.ShowDialog();
            Show();
        }
    }
}
