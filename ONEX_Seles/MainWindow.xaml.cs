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
using System.Data;
using System.Data.OleDb;

namespace ONEX_Seles
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
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();

        }

        private void Enter_Click(object sender, RoutedEventArgs e)
        {
            DataTable tblLogin2 = new DataTable();
            DB1.Open1();
            tblLogin2 = DB1.DBGetData1("select * from mylogin where is_Active='True' and username='" + UW.Text.Replace("'","")+"' and password ='"+ txtpass.Password.Replace("'","")+"'");
            if (tblLogin2.Rows.Count > 0)
            {
                Main HomeMain = new Main();
                HomeMain.Icon = this.Icon;
                HomeMain.Show();
                DB1.Open1();
                DB.Open();
                this.Close();

            }
            else
            {
                UW.Text ="";
                txtpass.Password ="";
                MessageBox.Show("البيانات التي ادخلتها للاسف خاطئة");


            }


        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void UW_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void Txtpass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {

                DataTable tblLogin1 = new DataTable();
                DB1.Open1();
                tblLogin1 = DB1.DBGetData1("select * from mylogin where is_Active='True' and username='" + UW.Text.Replace("'", "") + "' and password ='" + txtpass.Password.Replace("'", "") + "'");
                if (tblLogin1.Rows.Count > 0)
                {
                    Main HomeMain = new Main();
                    HomeMain.Icon = this.Icon;
                    HomeMain.Show();
                    DB1.Open1();
                    DB.Open();
                    this.Close();

                }
                else
                {
                    UW.Text = "";
                    txtpass.Password = "";
                    MessageBox.Show("البيانات التي ادخلتها للاسف خاطئة");


                }




            }

        }

        private void UW_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                txtpass.Focus();

            }

        }

        private void Txtpass1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Enter_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void BuGmail_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void Bufacebook_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
