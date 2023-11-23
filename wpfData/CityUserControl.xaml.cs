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
    /// </summary>
    public partial class CityUserControl : UserControl
    {
        private ServiceReferenceSnack.ServiceSnacksClient serviceSnacks;



        public CityUserControl()
        {
            InitializeComponent();

            serviceSnacks = new ServiceSnacksClient();
            cityListView.ItemsSource = serviceSnacks.GetAllCities();

        }
    }
}
