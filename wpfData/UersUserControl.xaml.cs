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
using ViewModel;


namespace wpfData
{
    /// <summary>
    /// Interaction logic for UersUserControl.xaml
    /// </summary>
    public partial class UsersUserControl : UserControl
    {
        private UserDB userDB;

        public UsersUserControl()
        {
            InitializeComponent();

            userDB = new UserDB();
            usersListView.ItemsSource = userDB.SelectAll();
        }
    }
}
