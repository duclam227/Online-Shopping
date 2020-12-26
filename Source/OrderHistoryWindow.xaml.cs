using OnlineShoppingBUS;
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

namespace Online_Shopping
{
    /// <summary>
    /// Interaction logic for HistoryOrder.xaml
    /// </summary>
    public partial class OrderHistoryWindow : Window
    {
        DonDatHangBUS dDHB;
        int maKhachHang;

        public OrderHistoryWindow(int ma)
        {
            InitializeComponent();
            maKhachHang = ma;
            dDHB = new DonDatHangBUS();
        }

        void loadData()
        {
            System.Data.DataTable dataTable = dDHB.GetHistoryOfOrder(maKhachHang.ToString());
            ddGHistory.ItemsSource = dataTable.DefaultView;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            loadData();
        }
    }
}
