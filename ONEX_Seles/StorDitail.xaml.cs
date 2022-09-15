using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

namespace ONEX_Seles
{
    /// <summary>
    /// Interaction logic for StorDitail.xaml
    /// </summary>
    public partial class StorDitail : Window
    {
        public StorDitail()
        {
            InitializeComponent();
            StorInventory();
        }

        private void BuEx_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void StorInventory()
        {
            try
            {
                txtTotalQfoundPro.Text = DB1.DBGetData1("select sum([الكمية]) from Poduct").Rows[0][0].ToString();
                txtTotaleQSalesPro.Text = DB1.DBGetData1("select sum([الكمية]) from TabSales").Rows[0][0].ToString();
                txtTotalePricFoundPro.Text = DB1.DBGetData1("select sum([السعر]) from Poduct").Rows[0][0].ToString();
                txtTotalePricSalesPro.Text = DB1.DBGetData1("select sum([السعر]) from TabSales").Rows[0][0].ToString();
                DataTable DataPro = DB1.DBGetData1("select * from Poduct  ");
                SqlDataAdapter ad = new SqlDataAdapter(DB1.cmd1);
                ad.Fill(DataPro);
                DataProdect.ItemsSource = DataPro.DefaultView;



            }
            catch (Exception edx)
            {
                MessageBox.Show(edx.Message);
            }
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BuReturnMain_Click(object sender, RoutedEventArgs e)
        {

            Main HomeMain = new Main();
            HomeMain.Icon = this.Icon;
            HomeMain.Show();
            
            this.Close();
        }

        private void BuUpditData_Click(object sender, RoutedEventArgs e)
        {

            DataProdect.UpdateLayout();
        }

        private void DataProdect_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
