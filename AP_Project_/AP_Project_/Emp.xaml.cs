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
    /// Interaction logic for Emp.xaml
    /// </summary>
    public partial class Emp : Window
    {
        public Emp()
        {
            InitializeComponent();
        }
        private void Button_Click_Books(object sender, RoutedEventArgs e)
        {
            AddBooks addBooks = new AddBooks();
            addBooks.Show();
            this.Close();
        }
        private void Button_Click_Members(object sender, RoutedEventArgs e)
        {
            Members members = new Members();
            members.Show();
            this.Close();
        }
        private void Button_Click_Wallet(object sender, RoutedEventArgs e)
        {
            Wallet wallet = new Wallet();
            wallet.Show();
            this.Close();
        }
        private void Button_Click_Profile(object sender, RoutedEventArgs e)
        {
            Profile profile = new Profile();
            profile.Show();
            this.Close();
        }
    }
}
