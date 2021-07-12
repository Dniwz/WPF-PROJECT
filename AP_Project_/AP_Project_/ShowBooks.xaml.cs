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
    /// Interaction logic for ShowBooks.xaml
    /// </summary>
    public partial class ShowBooks : Window
    {
        public ShowBooks()
        {
            InitializeComponent();
        }
        private void Button_Click_Back(object sender, RoutedEventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Close();
        }
        private void Button_Click_AddBook(object sender, RoutedEventArgs e)
        {
            AddBooks addBooks = new AddBooks();
            addBooks.Show();
            this.Close();
        }
    }
}
