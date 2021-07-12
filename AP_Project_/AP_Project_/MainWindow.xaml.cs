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

namespace AP_Project_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Button_Click_Register(object sender, RoutedEventArgs e)
        {
            Register reg = new Register();
            reg.Show();
            this.Close();
        }
        private void Button_Click_Enter(object sender, RoutedEventArgs e)
        {
            if (Username.Text.Length != 0 && Password.Password.Length != 0)
            {
                if (Username.Text.ToLower()=="admin")
                {
                    Admin admin = new Admin();
                    admin.Show();
                    this.Close();
                }
                else if (Username.Text.ToLower() == "emp")
                {
                    Emp emp = new Emp();
                    emp.Show();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Enter both Username and Password.");
            }
        }
    }
}
