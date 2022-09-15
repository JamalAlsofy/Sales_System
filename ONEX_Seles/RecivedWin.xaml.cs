using System;
using System.Collections.Generic;
using System.Data;
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
    /// Interaction logic for RecivedWin.xaml
    /// </summary>
    public partial class RecivedWin : Window
    {
        public RecivedWin()
        {
            InitializeComponent();
        }

        private void BuNewC_Click(object sender, RoutedEventArgs e)
        {
            string ActiveMax = DB1.DBGetData1("select max([رقم النشاط]) from ActivetyCU").Rows[0][0].ToString();
            int NActive = (Convert.ToInt32(ActiveMax)) + 1;

            string ActiveNO = Convert.ToString(NActive);

            DB1.Run1("insert into ActivetyCU values(" + ActiveNO + "," + txtCustNoR.Text.Replace("'", "") + ",'استلام'," + txtMonyR.Text.Replace("'", "") + ", 'Good','" + txtCategR.Text.Replace("'", "") + "','" + txtDateR.Text.Replace("'", "") + "')");
            MessageBox.Show("تمت الاضافة بنجاح");
            txtCustNoR.Text = "";
            txtCustNameR.Text = "";
            txtMonyR.Text = "";
            txtCategR.Text = "";
            txtDateR.Text = "";





        }

        private void TxtCustNoR_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                DataTable tbActiveR = new DataTable();
                try
                {
                    tbActiveR = DB1.DBGetData1("select [اسم العميل] from Customer Where [رقم العميل]=" + txtCustNoR.Text.Replace("'", ""));

                    if (tbActiveR.Rows.Count > 0)
                        txtCustNameR.Text = DB1.DBGetData1("select [اسم العميل] from Customer Where [رقم العميل]=" + txtCustNoR.Text.Replace("'", "")).Rows[0][0].ToString();
                    txtMonyR.Focus();
                    txtMonyR.SelectAll();
                    txtDateR.Text = DateTime.Now.ToString();

                }
                catch (Exception emw)
                {
                    MessageBox.Show(emw.Message);
                }

            }
        }

        private void TxtMonyR_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key==Key.Enter)
            {
                txtCategR.Focus();
                txtCategR.SelectAll();
            }
        }

        private void TxtMonyR_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TxtCategR_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                txtCategR.Focus();
                txtCategR.SelectAll();
            }
        }

        private void BackR_Click(object sender, RoutedEventArgs e)
        {

            Main HomeMain = new Main();
       
            HomeMain.Show();
            this.Close();
        }
    }
}
