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
using wpfData.ServiceReferenceSnack;


namespace wpfData
{
    /// <summary>
    /// Interaction logic for UersUserControl.xaml
    /// </summary>
    public partial class UsersUserControl : UserControl
    {
        private ServiceSnacksClient serviceSnacks;

        public UsersUserControl()
        {
            InitializeComponent();

            serviceSnacks = new ServiceSnacksClient();
            UserList list = serviceSnacks.GetAllUsers();
            usersListView.ItemsSource = list;
        }
    }
}
