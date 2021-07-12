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
    /// Interaction logic for AddBooks.xaml
    /// </summary>
    public partial class AddBooks : Window
    {
        public AddBooks()
        {
            InitializeComponent();
        }
        private void Button_Click_Books(object sender, RoutedEventArgs e)
        {
            ShowBooks showBooks = new ShowBooks();
            showBooks.Show();
            this.Close();
        }
        private void Button_Click_Add(object sender, RoutedEventArgs e)
        {
            if (BName.Text.Length != 0 && WName.Text.Length != 0 && Genre.Text.Length != 0 && Shomare.Text.Length != 0)
            {
                ShowBooks showBooks = new ShowBooks();
                showBooks.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("All fields must be filled.");
            }
        }
    }
}
