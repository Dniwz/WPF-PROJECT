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

namespace AP_Project_
{
    /// <summary>
    /// Interaction logic for Admin.xaml
    /// </summary>
    public partial class Admin : Window
    {
        public Admin()
        {
            InitializeComponent();
        }
        private void Button_Click_Emp(object sender, RoutedEventArgs e)
        {
            NewEmp newEmp = new NewEmp();
            newEmp.Show();
            this.Close();
        }
        private void Button_Click_Bank(object sender, RoutedEventArgs e)
        {
            Bank bank = new Bank();
            bank.Show();
            this.Close();
        }
        private void Button_Click_Books(object sender, RoutedEventArgs e)
        {
            ShowBooks showBooks = new ShowBooks();
            showBooks.Show();
            this.Close();
        }
    }
}
