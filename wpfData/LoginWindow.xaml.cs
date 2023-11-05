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
using Model;
using ViewModel;

namespace wpfData
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            User user = new User() { UserName =tbxID.Text, Password=tbxPassword.Password};
           UserDB db = new UserDB();    
            user=db.Login(user);
            if(user==null)
            {
                MessageBox.Show("Not In System");
                return;
            }
            if(!user.IsAdmin)
            {
                MessageBox.Show("Not Admin");
                return;
            }
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            tbxID.Text = tbxPassword.Password=String.Empty;
        }
    }
}
