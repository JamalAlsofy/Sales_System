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
//using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Data.Sql;

namespace ONEX_Seles
{
    /// <summary>
    /// Interaction logic for Main.xaml
    /// </summary>

    public partial class Main : Window
    {
        public int cust = 0;
        public string DateT;
        public string TxtProId;
        public string TxtProName;
        public string TxtProuQount;
        public string TxtPricProS;
        public string TxtQountityAS;
        public int ntPris = 0;
        public int ntDebt = 0;

        public int NtxtQount;
        public Main()
        {
            InitializeComponent();
            GRDataSales();


        }
        private void ReplicSales()
        {
            txtNumProSales.Text = "";
            txtPricePro.Text = "";
            txtPriceALL.Text = "";
            txtproName.Text = "";
            txtQountity.Text = "";
            txtDataSales.Text = "";
            txtCustNameS.Text = "";
            txtproName.Text = "";
            txtCustNameS.Text = "";
            txtDabte.Text = "";
            txtQountity.Text = "";
            txtPricePro.Text = "";
            txtSalesNumber.Text = "";
            txtDataSales.Text = "";
            txtCustNO.Text = "";
            txtTypeProS.Text = "";
            txtSizeProS.Text = "";
            txtStateProS.Text = "";
            txtDitail.Text = "";
            txtDabte1.Text = "";
            txtCashS.Text = "";




            radcash.IsChecked = false;
            radDebt.IsChecked = false;
            txtproName.IsEnabled = false;
            txtCustNameS.IsEnabled = false;
            txtQountity.IsEnabled = false;
            txtPricePro.IsEnabled = false;
            buAddSales.IsEnabled = false;
            //buINVOICE.IsEnabled = false;
            buUpditeSales.IsEnabled = false;
            radcash.IsEnabled = false;
            radDebt.IsEnabled = false;
            labcast.IsEnabled = false;
            labprais.IsEnabled = false;
            labprodname.IsEnabled = false;
            labprodnum.IsEnabled = false;
            labQuon.IsEnabled = false;
            txtDataSales.IsEnabled = false;
            labDataTimeS.IsEnabled = false;
            txtCustNO.IsEnabled = false;
            txtPriceALL.IsEnabled = false;
            labpraisALL.IsEnabled = false;
            txtDitail.IsEnabled = false;
            labQuon_Copy3.IsEnabled = false;
            labQuon_Copy2.IsEnabled = false;
            labQuon_Copy1.IsEnabled = false;
            txtSizeProS.IsEnabled = false;
            txtStateProS.IsEnabled = false;
            txtTypeProS.IsEnabled = false;
            labcastNo.IsEnabled = false;
            labQuon_Copy.IsEnabled = false;





            txtNumProSales.SelectAll();

        }


        private void RereadyingC()
        {
            txtNameC.Text = "";
            txtNumC.Text = "";
            txtPhonC.Text = "";
            txtDateC.Text = "";
            txtDebteC.Text = "";
            txtRecivedC.Text = "";

            txtNumC.IsEnabled = false;
            txtNameC.IsEnabled = false;
            txtPhonC.IsEnabled = false;
            txtRecivedC.IsEnabled = false;
            txtDateC.IsEnabled = false;
            txtDebteC.IsEnabled = false;
        }
        public void SaveS2S()
        {

            string invoice = "";
            TextBlock x0;
            TextBlock x1;
            TextBlock x2;
            TextBlock x3;
            TextBlock x4;
            TextBlock x5;

            try
            {
                DB1.Run1("insert into Vatorah values(1,0,'NN',0,0,0,'MM')");
                int M = NewDGV.Items.Count;
                for (int i = 0; i < M; i++)
                {
                    x0 = NewDGV.Columns[0].GetCellContent(NewDGV.Items[i]) as TextBlock;
                    x1 = NewDGV.Columns[1].GetCellContent(NewDGV.Items[i]) as TextBlock;
                    x2 = NewDGV.Columns[2].GetCellContent(NewDGV.Items[i]) as TextBlock;
                    x3 = NewDGV.Columns[3].GetCellContent(NewDGV.Items[i]) as TextBlock;
                    x4 = NewDGV.Columns[4].GetCellContent(NewDGV.Items[i]) as TextBlock;
                    x5 = NewDGV.Columns[5].GetCellContent(NewDGV.Items[i]) as TextBlock;

                    invoice = DB1.DBGetData1("select max(vatorhId)+1 from Vatorah").Rows[0][0].ToString();

                    if (x0 != null || x1 != null || x2 != null || x3 != null || x4 != null || x5 != null)
                    {

                        DB1.Run1("insert into Vatorah values(" + invoice + "," + x0.Text + ",'" + x1.Text + "'," + x2.Text + "," + x3.Text + "," + x4.Text + ",'" + x5.Text + "')");

                    }
                    else { labcastNo.Content = "No thinge"; break; }



                }
                //اخذ البيانات من القرايد



            }
            catch (Exception evz)
            {
                MessageBox.Show(evz.Message);
            }

            /*
            التكملة*/
            //DB1.Run1("DELETE FROM Vatorah");
            NewDGV.Items.Clear();
            txtCustNO.Clear();
            txtCustNameS.Clear();
            txtDataSales.Clear();
        }
        private void FPrice() {
            int NSQ = Convert.ToInt32(txtQountity.Text);
            int NSP1 = Convert.ToInt32(txtPricePro.Text);
            int NSALL = NSQ * NSP1;
            int NSPD2 = NSALL / NSQ ;
            txtPriceALL.Text = Convert.ToString(NSALL);



        }
        private void Addf()
        {
            int ntxtPrisS = Convert.ToInt32(txtPricePro.Text);
            int ntxtPrisProT = Convert.ToInt32(TxtPricProS);

            if (txtNumProSales.Text.Trim() == "")
            {
                MessageBox.Show(" لايوجد رقم ");

            }
            else if (txtproName.Text.Trim() == "") { MessageBox.Show(" لا يوجد اسم"); SName.SelectAll(); }

            else if (txtPricePro.Text.Trim() == "") { MessageBox.Show(" لا يوجد سعر بيع"); txtPricePro.SelectAll(); }

            else if (txtQountity.Text.Trim() == "") { MessageBox.Show(" لا يوجد كمية"); txtQountity.SelectAll(); }
            else
            {
                try
                {
                    if (ntxtPrisProT <= ntxtPrisS)
                    {
                        string txtSNo = DB1.DBGetData1("select max([رقم الفاتورة]) from TabSales").Rows[0][0].ToString();
                        int NSNo = (Convert.ToInt32(txtSNo)) + 1;
                        if (txtSNo == "")
                        {
                            txtSalesNumber.Text = "1";
                        }
                        else
                        {
                            txtSalesNumber.Text = Convert.ToString(NSNo);

                        }

                        txtSalesNumber.Text = Convert.ToString(NSNo);
                        string txtProductTyp1 = DB1.DBGetData1("select [النوع] from Poduct where [رقم الصنف] = " + txtNumProSales.Text).Rows[0][0].ToString();
                        cust = cust++;
                        string TxtCustNumbNew = Convert.ToString(cust);
                        /* 
                        if (txtPricePro.Text.Trim() == "")
                        {
                            ntDebt = 0;
                            ntPris = 0;

                        }
                        else
                        {
                            ntPris = Convert.ToInt32(txtPricePro.Text);
                            ntDebt = Convert.ToInt32(txtDabte.Text);

                        }

                      int CashSum = 0;
                        CashSum = ntPris - ntDebt;
                       string TxtCach = Convert.ToString(CashSum);
                        string Custo = Convert.ToString(cust);


                         */
                        //سيتم اضافة النوع والحجم والحالة تلقائي مثل الاسم
                        //عمل لاصق لكل صنف 
                        //
                        int UpToTPrP = 1;
                        int NToTPB = 1;
                        int nQthis = 1;
                        int nQinP = 1;
                        string QinP = DB1.DBGetData1("select [الكمية] from Poduct  where [رقم الصنف]= " + txtNumProSales.Text.Replace("'", "")).Rows[0][0].ToString();
                        nQinP = Convert.ToInt32(QinP);
                        string ToTPricBP = DB1.DBGetData1("select [اجمالي الشراء] from Poduct  where [رقم الصنف]= " + txtNumProSales.Text.Replace("'", "")).Rows[0][0].ToString();
                        NToTPB = Convert.ToInt32(ToTPricBP);
                        string PriceOneP = DB1.DBGetData1("select [سعر الشراء] from Poduct  where [رقم الصنف]= " + txtNumProSales.Text.Replace("'", "")).Rows[0][0].ToString();
                        string NQthis = txtQountity.Text.Replace("'", "");
                        int nPBO = Convert.ToInt32(PriceOneP);
                        nQthis = Convert.ToInt32(NQthis);

                        //  UpToTPrP = NToTPB - (nPBO * nQthis);
                        string tUpToTPrP = Convert.ToString(UpToTPrP);
                        if (NToTPB <= 0 || nQinP <= 0)
                        {
                            MessageBox.Show("يمكن ان تكون كمية هذا الصنف قد نفذت او اقل من الكمية المطلوبة ");

                        }
                        else
                        {
                            DB1.Run1("update Poduct set [الكمية] = [الكمية]-" + txtQountity.Text.Replace("'", "") + " where [رقم الصنف]= " + txtNumProSales.Text.Replace("'", ""));

                            DB1.Run1("update Poduct set [اجمالي الشراء] = " + tUpToTPrP + "  where [رقم الصنف] = " + txtNumProSales.Text.Replace("'", ""));

                            DB1.Run1("insert into TabSales values(" + txtSalesNumber.Text.Replace("'", "") + ", '" + txtproName.Text.Replace("'", "") + "', " + txtQountity.Text.Replace("'", "") + ", '" + txtTypeProS.Text.Replace("'", "") + "', '" + txtSizeProS.Text.Replace("'", "") + "', '" + txtStateProS.Text.Replace("'", "") + "', '" + txtDitail.Text.Replace("'", "") + "'," + txtPricePro.Text.Replace("'", "") + ", " + txtPriceALL.Text.Replace("'", "") + ", " + txtDabte1.Text.Replace("'", "") + ", " + txtCashS.Text.Replace("'", "") + ", '" + txtCustNameS.Text.Replace("'", "") + "', " + txtCustNO.Text.Replace("'", "") + ", '" + txtDataSales.Text.Replace("'", "") + "'); ");
                            string ActiveMax = DB1.DBGetData1("select max([رقم النشاط]) from ActivetyCU").Rows[0][0].ToString();
                            int NActive = (Convert.ToInt32(ActiveMax)) + 1;

                            string ActiveNO = Convert.ToString(NActive);

                            DB1.Run1("insert  into ActivetyCU values(" + ActiveNO + "," + txtCustNO.Text.Replace("'", "") + ",'دين'," + txtDabte1.Text.Replace("'", "") + ", 'Good','" + txtproName.Text.Replace("'", "") + "','" + txtDataSales.Text.Replace("'", "") + "')");
                            // DB.Run("insertinto Sales values("+txtSalesNumber.Text+",'"+ txtproName.Text.Replace("'","") + "','"+ txtProductTyp1 + "',"+ txtPricePro.Text.Replace("'", "") + ","+txtDabte.Text.Replace("'", "") + ","+ TxtCach + ",'"+txtCustNameS.Text.Replace("'", "") + "',"+TxtCustNumbNew+",'"+txtDataSales.Text.Replace(",","")+"')");
                            //FindOrAddCast();
                          //  MessageBox.Show("تم الاضافةالصنف بنجاح");

                        }



                        ReplicSales();
                        GRDataSales();


                    }

                }
                catch (Exception cxx)
                {

                    MessageBox.Show(cxx.Message);
                }
            }


        }
       /* class Proudect_Sales
        {
            public string proNo { get; set; }
            public string proName { get; set; }
            public string proQountity { get; set; }
            public string proOnePric { get; set; }
            public string proPric { get; set; }
            public string proDitails { get; set; }
        }*/
        private void AddintoGrid()
        {
            Pro_Items_Sales ProSales = new Pro_Items_Sales();
            ProSales.proNo = txtNumProSales.Text;
            ProSales.proName = txtproName.Text;
            ProSales.proQountity = txtQountity.Text;
            ProSales.proOnePric = txtPricePro.Text;
            ProSales.proPric = txtPriceALL.Text;
            ProSales.proDitails = txtTypeProS.Text;// + ". /n " + txtSizeProS.Text + ". /n " + txtStateProS.Text+" .";
          //  DataGridFinlS.Items.Add(ProSales);

            /*txtNumProSales.Clear();
            txtproName.Clear();
            txtQountity.Clear();
            txtPricePro.Clear();
            txtPriceALL.Clear();
            txtTypeProS.Clear();
            txtSizeProS.Clear();
            txtStateProS.Clear();
            txtCashS.Clear();
            txtDabte1.Clear();
            txtDataSales.Text = DateTime.Now.ToString();
            */
        }
        private void readyingC()
        {
            txtNumC.IsEnabled = true;
            string CustNO = DB1.DBGetData1("select max([رقم العميل] ) from Customer").Rows[0][0].ToString();
            int NCustNo =( Convert.ToInt32(CustNO))+1;
            txtNumC.Text = Convert.ToString(NCustNo);
            txtNameC.IsEnabled = true;
            txtNameC.Focus();
            txtNameC.SelectAll();
            txtDebteC.IsEnabled = true;
            txtPhonC.IsEnabled = true;
            txtRecivedC.IsEnabled = true;
            txtDateC.IsEnabled = true;
            buAddCust.IsEnabled = true;
            buEditCust.IsEnabled = true;

            txtNameC.Text = "";
            txtDebteC.Text = "";
            txtPhonC.Text = "";
            txtRecivedC.Text = "";
            txtDateC.Text = "";
           
           

            txtDateC.Text= DateTime.Now.ToString();


        }
        private void GRDataSales()
        {
            DataTable DataSal = DB1.DBGetData1("select * from Sales ");
            SqlDataAdapter aed1 = new SqlDataAdapter(DB1.cmd1);
            aed1.Fill(DataSal);
           // DataGridFinlS.ItemsSource = DataSal.DefaultView;
            
        }
        /*private void FindOrAddCast()
        {
            DataTable DTCastr = new DataTable();
          
            DTCastr = DB1.DBGetData1("select * from Customer where [رقم العميل]="+ txtCustNO.Text.Replace("'",""));
            if (DTCastr.Rows.Count > 0)
            {
                DB1.Run1("update Customer set  [المبلغ المدين]+=" + txtDabte.Text.Replace("'", "") + " where [رقم العميل]= " + txtCustNO.Text.Replace("'", ""));

            }
            else
            {
                DB1.Run1("insert into Customer values(" + txtCustNO.Text.Replace("'", "") + ",'"+ txtCustNameS.Text.Replace("'","") + "','77',0,0,'"+txtDataSales.Text.Replace("'","")+"')");

            }

        }
        */


        private void FindItemTargit2()
        {
            try
            {
                int nmaxIdPro = 0;
                int nminIdPro = 0;
                int ntxtProNum = 0;

                ntxtProNum = Convert.ToInt32(txtNumProSales.Text);

                TxtProName = DB1.DBGetData1("select [اسم الصنف] from Poduct where [رقم الصنف] = " + txtNumProSales.Text).Rows[0][0].ToString();
                TxtProuQount = DB1.DBGetData1("select [الكمية] from Poduct where [رقم الصنف] = " + txtNumProSales.Text).Rows[0][0].ToString();
                TxtPricProS = DB1.DBGetData1("select [السعر] from Poduct where [رقم الصنف] = " + txtNumProSales.Text).Rows[0][0].ToString();
                
                txtTypeProS.Text = DB1.DBGetData1("select [النوع] from Poduct where [رقم الصنف] = " + txtNumProSales.Text).Rows[0][0].ToString();
                txtSizeProS.Text= DB1.DBGetData1("select [الحجم ] from Poduct where [رقم الصنف] = " + txtNumProSales.Text).Rows[0][0].ToString();
               txtStateProS.Text= DB1.DBGetData1("select [الحالة] from Poduct where [رقم الصنف] = " + txtNumProSales.Text).Rows[0][0].ToString();
                

                txtPricePro.Text = TxtPricProS;


                string maxIdPro = DB1.DBGetData1("select max([رقم الصنف]) from Poduct").Rows[0][0].ToString();
                string minIdPro = DB1.DBGetData1("select min([رقم الصنف]) from Poduct").Rows[0][0].ToString();
                nmaxIdPro = Convert.ToInt32(maxIdPro);
                nminIdPro = Convert.ToInt32(minIdPro);


                if (ntxtProNum > nmaxIdPro || ntxtProNum < nminIdPro || ntxtProNum == 0)
                {
                    MessageBox.Show("هذا الرقم غير موجود");
                    txtNumProSales.Focus();
                }
                else
                {

                    txtproName.IsEnabled = true;
                    txtCustNameS.IsEnabled = true;
                    txtQountity.IsEnabled = true;
                    txtPricePro.IsEnabled = true;
                    buAddSales.IsEnabled = true;
                    buINVOICE.IsEnabled = true;
                    buUpditeSales.IsEnabled = true;
                    radcash.IsEnabled = true;
                    radDebt.IsEnabled = true;
                    labcast.IsEnabled = true;
                    labprais.IsEnabled = true;
                    labprodname.IsEnabled = true;
                    labprodnum.IsEnabled = true;
                    labQuon.IsEnabled = true;
                    txtDataSales.IsEnabled = true;
                    labDataTimeS.IsEnabled = true;
                    LabSalesNum.IsEnabled = true;
                    txtSalesNumber.IsEnabled = true;
                    txtCustNO.IsEnabled = true;
                    txtPriceALL.IsEnabled = true;
                    labpraisALL.IsEnabled = true;
                    txtDitail.IsEnabled = true;
                    labQuon_Copy3.IsEnabled = true;
                    labQuon_Copy2.IsEnabled = true;
                    labQuon_Copy1.IsEnabled = true;
                    txtSizeProS.IsEnabled = true;
                    txtStateProS.IsEnabled = true;
                    txtTypeProS.IsEnabled = true;
                    labcastNo.IsEnabled = true;
                    labQuon_Copy.IsEnabled = true;



                    txtDataSales.Text = DateTime.Now.ToString();
                    txtproName.Text = TxtProName;
                    txtQountity.Focus();

                }


            }
            catch (Exception emx)
            {
                MessageBox.Show(emx.Message);
            }


        }
        private void FindItemTargit()
        {
            try
            {
                int nmaxIdPro = 0;
                int nminIdPro = 0;
                int ntxtProNum = 0;

                ntxtProNum = Convert.ToInt32(txtNumProSales.Text);

                TxtProName = DB1.DBGetData1("select [اسم الصنف] from Poduct where [رقم الصنف] = " + txtNumProSales.Text).Rows[0][0].ToString();
                TxtProuQount = DB1.DBGetData1("select [الكمية] from Poduct where [رقم الصنف] = " + txtNumProSales.Text).Rows[0][0].ToString();
                TxtPricProS = DB1.DBGetData1("select [السعر] from Poduct where [رقم الصنف] = " + txtNumProSales.Text).Rows[0][0].ToString();

                txtTypeProS.Text = DB1.DBGetData1("select [النوع] from Poduct where [رقم الصنف] = " + txtNumProSales.Text).Rows[0][0].ToString();
                txtSizeProS.Text = DB1.DBGetData1("select [الحجم ] from Poduct where [رقم الصنف] = " + txtNumProSales.Text).Rows[0][0].ToString();
                txtStateProS.Text = DB1.DBGetData1("select [الحالة] from Poduct where [رقم الصنف] = " + txtNumProSales.Text).Rows[0][0].ToString();


                txtPricePro.Text = TxtPricProS;


                string maxIdPro = DB1.DBGetData1("select max([رقم الصنف]) from Poduct").Rows[0][0].ToString();
                string minIdPro = DB1.DBGetData1("select min([رقم الصنف]) from Poduct").Rows[0][0].ToString();
                nmaxIdPro = Convert.ToInt32(maxIdPro);
                nminIdPro = Convert.ToInt32(minIdPro);


                if (ntxtProNum > nmaxIdPro || ntxtProNum < nminIdPro || ntxtProNum == 0)
                {
                    MessageBox.Show("هذا الرقم غير موجود");
                    txtNumProSales.Focus();
                }
                else
                {

                    txtproName.IsEnabled = true;
                    txtCustNameS.IsEnabled = true;
                    txtQountity.IsEnabled = true;
                    txtPricePro.IsEnabled = true;
                    buAddSales.IsEnabled = true;
                    buINVOICE.IsEnabled = true;
                    buUpditeSales.IsEnabled = true;
                    radcash.IsEnabled = true;
                    radDebt.IsEnabled = true;
                    labcast.IsEnabled = true;
                    labprais.IsEnabled = true;
                    labprodname.IsEnabled = true;
                    labprodnum.IsEnabled = true;
                    labQuon.IsEnabled = true;
                    txtDataSales.IsEnabled = true;
                    labDataTimeS.IsEnabled = true;
                    LabSalesNum.IsEnabled = true;
                    txtSalesNumber.IsEnabled = true;
                    txtCustNO.IsEnabled = true;
                    txtPriceALL.IsEnabled = true;
                    labpraisALL.IsEnabled = true;
                    txtDitail.IsEnabled = true;
                    labQuon_Copy3.IsEnabled = true;
                    labQuon_Copy2.IsEnabled = true;
                    labQuon_Copy1.IsEnabled = true;
                    txtSizeProS.IsEnabled = true;
                    txtStateProS.IsEnabled = true;
                    txtTypeProS.IsEnabled = true;
                    labcastNo.IsEnabled = true;
                    labQuon_Copy.IsEnabled = true;
                    SaveAllSales.IsEnabled = true;


                    txtDataSales.Text = DateTime.Now.ToString();
                    txtproName.Text = TxtProName;
                    txtQountity.Focus();

                }


            }
            catch (Exception emx)
            {
                MessageBox.Show(emx.Message);
            }


        }
        private void FindItemTargit22()
        {
            try
            {
                int nmaxIdPro = 0;
                int nminIdPro = 0;
                int ntxtProNum = 0;

                ntxtProNum = Convert.ToInt32(txtNumProSales.Text);

                TxtProName = DB1.DBGetData1("select [اسم الصنف] from Poduct where [رقم الصنف] = " + txtNumProSales.Text).Rows[0][0].ToString();
                TxtProuQount = DB1.DBGetData1("select [الكمية] from Poduct where [رقم الصنف] = " + txtNumProSales.Text).Rows[0][0].ToString();
                TxtPricProS = DB1.DBGetData1("select [السعر] from Poduct where [رقم الصنف] = " + txtNumProSales.Text).Rows[0][0].ToString();

                txtTypeProS.Text = DB1.DBGetData1("select [النوع] from Poduct where [رقم الصنف] = " + txtNumProSales.Text).Rows[0][0].ToString();
                txtSizeProS.Text = DB1.DBGetData1("select [الحجم ] from Poduct where [رقم الصنف] = " + txtNumProSales.Text).Rows[0][0].ToString();
                txtStateProS.Text = DB1.DBGetData1("select [الحالة] from Poduct where [رقم الصنف] = " + txtNumProSales.Text).Rows[0][0].ToString();


                txtPricePro.Text = TxtPricProS;


                string maxIdPro = DB1.DBGetData1("select max([رقم الصنف]) from Poduct").Rows[0][0].ToString();
                string minIdPro = DB1.DBGetData1("select min([رقم الصنف]) from Poduct").Rows[0][0].ToString();
                nmaxIdPro = Convert.ToInt32(maxIdPro);
                nminIdPro = Convert.ToInt32(minIdPro);


                if (ntxtProNum > nmaxIdPro || ntxtProNum < nminIdPro || ntxtProNum == 0)
                {
                    MessageBox.Show("هذا الرقم غير موجود");
                    txtNumProSales.Focus();
                }
                else
                {

                    txtproName.IsEnabled = true;
                    txtCustNameS.IsEnabled = true;
                    txtQountity.IsEnabled = true;
                    txtPricePro.IsEnabled = true;
                    buAddSales.IsEnabled = true;
                    buINVOICE.IsEnabled = true;
                    buUpditeSales.IsEnabled = true;
                    radcash.IsEnabled = true;
                    radDebt.IsEnabled = true;
                    labcast.IsEnabled = true;
                    labprais.IsEnabled = true;
                    labprodname.IsEnabled = true;
                    labprodnum.IsEnabled = true;
                    labQuon.IsEnabled = true;
                    txtDataSales.IsEnabled = true;
                    labDataTimeS.IsEnabled = true;
                    LabSalesNum.IsEnabled = true;
                    txtSalesNumber.IsEnabled = true;
                    txtCustNO.IsEnabled = true;
                    txtPriceALL.IsEnabled = true;
                    labpraisALL.IsEnabled = true;
                    txtDitail.IsEnabled = true;
                    labQuon_Copy3.IsEnabled = true;
                    labQuon_Copy2.IsEnabled = true;
                    labQuon_Copy1.IsEnabled = true;
                    txtSizeProS.IsEnabled = true;
                    txtStateProS.IsEnabled = true;
                    txtTypeProS.IsEnabled = true;
                    labcastNo.IsEnabled = true;
                    labQuon_Copy.IsEnabled = true;



                    txtDataSales.Text = DateTime.Now.ToString();
                    txtproName.Text = TxtProName;
                    txtQountity.Focus();

                }


            }
            catch (Exception emx)
            {
                MessageBox.Show(emx.Message);
            }


        }

        private void cleanAutoBay()
        {
            SNo.Text = "";
            try
            {
                string txtSNo = DB1.DBGetData1("select max([رقم الصنف] ) from Poduct").Rows[0][0].ToString();
                int NSNo = (Convert.ToInt32(txtSNo)) + 1;
                SNo.Text = Convert.ToString(NSNo);

                if (SNo.Text.Trim() == "") SNo.Text = "1";
                MessageBox.Show("Connction ver Good");
                DateT = DateTime.Now.ToString();



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + "خطأ لم يستطع الوصول");
            }

            SName.Text = "";
            SPriceB.Text = "";
            SPriceS.Text = "";
            SType.Text = "";
            SQuan.Text = "";
            SCoun.Text = "";
            txtTotalPricBay.Text = "";
            txtTotalPricSales.Text = "";
            SStateProdect.Text = "";
            SSizeProdect.Text = "";
            SDitaileProdect.Text = "";






            SName.SelectAll();
        }
        private void cleanAndAuto()
        {
            SNo.Text = "";
            try
            {
                string txtSNo = DB1.DBGetData1("select max([رقم الصنف] ) from Poduct").Rows[0][0].ToString();
                int NSNo =( Convert.ToInt32(txtSNo))+1;
                SNo.Text = Convert.ToString(NSNo);

                if (SNo.Text.Trim() == "") SNo.Text = "1";
                MessageBox.Show("Connction ver Good");
                DateT = DateTime.Now.ToString();



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + "خطأ لم يستطع الوصول");
            }

            SName.Text = "";
            SPriceB.Text = "";
            SPriceS.Text = "";
            SType.Text = "";
            SQuan.Text = "";
            SCoun.Text = "";
            txtTotalPricBay.Text = "";
            txtTotalPricSales.Text = "";
            SStateProdect.Text = "";
            SSizeProdect.Text = "";
            SDitaileProdect.Text = "";
            
            
            
        


            SName.SelectAll();




        }




        private void DataGrid_ColumnHeaderDragStarted(object sender, System.Windows.Controls.Primitives.DragStartedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TabControl_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }


        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }




        private void SAdd_Click(object sender, RoutedEventArgs e)
        {
            if (SDitaileProdect.Text.Trim() == "") { SDitaileProdect.Text = "--"; }
            if (SStateProdect.Text.Trim() == "") { SStateProdect.Text = "--"; }
            if (SSizeProdect.Text.Trim() == "") { SSizeProdect.Text = "--"; }


            if (SNo.Text.Trim() == "")
            {
                MessageBox.Show(" لايوجد رقم ");

            }
            else if (SName.Text.Trim() == "") { MessageBox.Show(" لا يوجد اسم"); SName.SelectAll(); }
            else if (SCoun.Text.Trim() == "") { MessageBox.Show(" لا يوجد دولة"); SCoun.SelectAll(); }
            else if (SPriceB.Text.Trim() == "") { MessageBox.Show(" لا يوجد سعر شراء"); SPriceB.SelectAll(); }
            else if (SPriceS.Text.Trim() == "") { MessageBox.Show(" لا يوجد سعر بيع"); SPriceS.SelectAll(); }
            else if (SType.Text.Trim() == "") { MessageBox.Show(" لا يوجد نوع"); SType.SelectAll(); }
            else if (SQuan.Text.Trim() == "") { MessageBox.Show(" لا يوجد كمية"); SQuan.SelectAll(); }
            else
            {
                try
                {

                    DB1.Run1("insert into Poduct values(" + SNo.Text.Replace("'", "") + ",'" + SName.Text.Replace("'", "") + "'," + SPriceS.Text.Replace("'", "") + "," + SQuan.Text.Replace("'", "") + ",'" + SType.Text.Replace("'", "")+"','"+ SSizeProdect.Text.Replace("'","") + "','"+SStateProdect.Text.Replace("'","")+"','"+SDitaileProdect.Text.Replace("'","")+"'," + SPriceB.Text.Replace("'", "") + ",'" + SCoun.Text.Replace("'", "") + "','" + txtDate.Text.Replace("'", "") + "',"+txtTotalPricBay.Text.Replace("'","")+","+txtTotalPricSales.Text.Replace("'","")+")");
                    
                    MessageBox.Show("تم الاضافة الصنف بنجاح");
                    cleanAndAuto();



                }
                catch (Exception exx) { MessageBox.Show(exx.Message+"هنالك خطأ في الادخال"); }

            }

        }

        private void StorTab_MouseEnter(object sender, MouseEventArgs e)
        {
            cleanAndAuto();
        }

        private void bunew_Click_1(object sender, RoutedEventArgs e)
        {

            SNo.IsEnabled = true;
            SName.IsEnabled = true;
            SPriceB.IsEnabled = true;
            SType.IsEnabled = true;
            SPriceS.IsEnabled = true;
            SQuan.IsEnabled = true;
            SCoun.IsEnabled = true;
            SAdd.IsEnabled = true;
            EditS.IsEnabled = true;
            DeletS.IsEnabled = true;
            txtTotalPricBay.IsEnabled = true;
            txtTotalPricSales.IsEnabled = true;
            SDitaileProdect.IsEnabled = true;
            SSizeProdect.IsEnabled = true;
            SStateProdect.IsEnabled = true;


            cleanAndAuto();
            txtDate.Text = DateT;

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_3(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_4(object sender, TextChangedEventArgs e)
        {

        }

        private void ControlItems_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void TxtproName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {

                DataTable tblSaleas = new DataTable();
               

               
                if (tblSaleas.Rows.Count > 0)
                {
                   

                }
                else
                {
                    txtNumProSales.Text = "";
                    txtproName.Text = "";
                    MessageBox.Show("البيانات التي ادخلتها للاسف خاطئة");


                }


            }
        }

        private void BuNewSales_Click(object sender, RoutedEventArgs e)
        {
            ReplicSales();
            DB1.Run1("DELETE FROM Vatorah");





        }

        private void TxtQountity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {

                txtPricePro.Focus();
                txtPricePro.SelectAll();
                /*  TxtQountityAS = txtQountity.Text;
                  string TxtPric = txtPricePro.Text;

                  int NPric = Convert.ToInt32(TxtPric);

                  int NQunt = Convert.ToInt32(TxtProuQount);
                  int newPric = NPric * NQunt;

                   NtxtQount = Convert.ToInt32(TxtQountityAS);
                  if (NtxtQount < NQunt)
                  {
                      txtPricePro.Text = Convert.ToString(newPric);
                      txtPricePro.Focus();

                  }
                  else
                  {
                      txtQountity.Text = "";
                      txtQountity.Focus();

                  }*/









            }

        }

        private void TxtNumProSales_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
              

                if (txtNumProSales.Text.Trim() != "")
                {
                   //cleanAndAutoS();

                    FindItemTargit();

                   



                }
                else
                {
                    MessageBox.Show("يجب ان تدخل رقم المنتج اولاً ");
                    txtNumProSales.Focus();
                }
               


            }
        }

        //Sales Button

        private void TxtPricePro_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.Key == Key.Enter)
                {
                    if (txtPricePro.Text.Trim() == "")
                    {
                        MessageBox.Show("لا يوجد مبلغ ");
                        txtPricePro.SelectAll();
                    }
                    else
                    {
                        int NPricOne = Convert.ToInt32(txtPricePro.Text.Replace("'", ""));
                        int NQunt = Convert.ToInt32(txtQountity.Text.Replace("'", ""));
                        int NPricAll = NPricOne * NQunt;
                        txtPriceALL.Text = Convert.ToString(NPricAll);

                        if (radcash.IsChecked == true && radDebt.IsChecked == true)
                        {

                            txtCashS.IsReadOnly = false;
                            txtCashS.IsEnabled = true;
                            txtCashS.Focus();
                            txtCashS.SelectAll();
                            txtDabte1.IsReadOnly = true;

                        }
                        else if (radDebt.IsChecked == true && radcash.IsChecked == false)
                        {
                            txtCashS.IsReadOnly = true;
                            txtDabte1.IsEnabled = true;
                            txtDabte1.Text = txtPriceALL.Text;
                            txtCashS.Text = "0";
                            txtTypeProS.Focus();
                            txtTypeProS.SelectAll();





                        }
                        else if (radDebt.IsChecked == false && radcash.IsChecked == true)
                        {
                            txtDabte1.Text = "0";
                            txtCashS.Text = txtPriceALL.Text;
                            ntDebt = 0;
                            txtTypeProS.Focus();
                            txtTypeProS.SelectAll();


                        }
                        else if (radcash.IsChecked == false && radDebt.IsChecked == false)
                        {
                            txtDabte1.Text = "0";
                            txtCashS.Text = "0";


                            ntDebt = 0;
                            txtTypeProS.Focus();
                            txtTypeProS.SelectAll();





                        }
                    }


                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }







        }

   

        private void RadDebt_Checked(object sender, RoutedEventArgs e)
        {
            
            txtPricePro.SelectAll();





        }
        public void InvocActive()
        {
            Invoice_Detail1 inv = new Invoice_Detail1();
            inv.NameCust = txtCustNameS.Text;
            inv.InvoiceNo = txtSalesNumber.Text;
            inv.Prodect_No = txtNumProSales.Text;
            inv.Prodect_Name = txtproName.Text;
            inv.Prodect_Quontity = txtQountity.Text;
            inv.Prodect_PriceOnse = txtPricePro.Text;
            inv.Prodect_Price = txtPriceALL.Text;
            inv.Prodect_Ditail = " / النوع /" + txtTypeProS.Text + "/  الحجم /" + txtSizeProS.Text + "/ الحالة /" + txtStateProS.Text + "/  تفاصيل  /" + txtDitail.Text;
            inv.InvoiceDate = txtDataSales.Text;

           // DB1.Run1("insert into Vatorah values(" + inv.InvoiceNo + "," + inv.Prodect_No + ",'" + inv.Prodect_Name + "'," + inv.Prodect_Quontity + "," + inv.Prodect_PriceOnse + "," + inv.Prodect_Price + ",'"+ inv.Prodect_Ditail+ "')");



        }

        private void Radcash_Checked(object sender, RoutedEventArgs e)
        {
            txtDabte.IsReadOnly = false;
            txtPricePro.SelectAll();
        }

        private void TxtTotalPricBay_TextInput(object sender, TextCompositionEventArgs e)
        {
            

           

        }

        private void TxtTotalPricBay_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (SQuan.Text.Trim() == "")
                {
                    MessageBox.Show("ادخل الكمية اولاً");
                    txtTotalPricBay.Text = "";
                    SQuan.Focus();
                    SQuan.SelectAll();


                }
                else
                {
                    int NtxtTotalBay = Convert.ToInt32(txtTotalPricBay.Text);
                    int NtxtQountity = Convert.ToInt32(SQuan.Text);
                    int NtxtPricBay = NtxtTotalBay / NtxtQountity;
                    SPriceB.Text = Convert.ToString(NtxtPricBay);
                    SPriceS.Focus();
                    SPriceS.SelectAll();

                }
            }
        }

        private void SPriceS_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (SPriceS.Text.Trim() == "")
                {
                    MessageBox.Show("ادخل سعر البيع اولأ");
                    SPriceS.Focus();
                    SPriceS.SelectAll();

                }else
                {
                    int ntxtSPriceS = Convert.ToInt32(SPriceS.Text);
                    int ntxtQount = Convert.ToInt32(SQuan.Text);
                    int ntxtSPriceB = Convert.ToInt32(SPriceB.Text);
                    if (ntxtSPriceB < ntxtSPriceS)
                    {
                        int ntxtTotal = ntxtSPriceS * ntxtQount;
                        txtTotalPricSales.Text = Convert.ToString(ntxtTotal);
                        SType.Focus();
                        SType.SelectAll();


                    }
                    else
                    {
                        MessageBox.Show("سعر البيع اقل من سعر الشراء ");
                        SPriceS.Focus();
                        SPriceS.SelectAll();


                    }

                    
                }
            }
        }

        private void SName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                SQuan.Focus();
                SQuan.SelectAll();
            }
        }

        private void SQuan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter) {


                txtTotalPricBay.Focus();
                txtTotalPricBay.SelectAll();


            }

        }

        private void SType_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void SType_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                SSizeProdect.Focus();
                SSizeProdect.SelectAll();

            }
                

        }

        private void TxtDabte_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                txtTypeProS.Focus();
                txtTypeProS.SelectAll();
                int nCashS = Convert.ToInt32(txtCashS.Text.Replace("'", ""));
                int nPriceAll = Convert.ToInt32(txtPriceALL.Text.Replace("'", ""));
                int nDabte = nPriceAll - nCashS;
                txtDabte1.Text = Convert.ToString(nDabte);

            }
           
        }

        private void RadDebt_Click(object sender, RoutedEventArgs e)
        {
            txtPricePro.SelectAll();
        }

        private void TxtPricePro_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TxtPricePro_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void TxtPricePro_KeyUp(object sender, KeyEventArgs e)
        {

        }

       
        private void BuAddCust_Click(object sender, RoutedEventArgs e)
        {
            if (txtNameC.Text.Trim() == "") { MessageBox.Show("ادخل  اسم العميل "); txtNameC.SelectAll(); }
            else if (txtNumC.Text.Trim() == "") { MessageBox.Show("لايوجد رقم للعميل "); txtNumC.SelectAll(); }
            else if (txtDebteC.Text.Trim() == "") { MessageBox.Show("ادخل دين العميل "); txtDateC.SelectAll(); }
     
            else
            {
                try
                {
                    DB1.Run1("insert into Customer values(" + txtNumC.Text.Replace("'","")+",'"+txtNameC.Text.Replace("'","")+"','"+txtPhonC.Text.Replace("'","")+"',"+txtDebteC.Text.Replace("'","")+","+txtRecivedC.Text.Replace("'","")+",'"+txtDateC.Text.Replace("'","")+"')");

                    MessageBox.Show("تمت الاضافة بنجاح");
                    RereadyingC();
                }
                catch(Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
                

            }
            
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

        }

        private void TxtSearchNC_KeyDown(object sender, KeyEventArgs e)
        {
           if(txtSearchNC.Text.Trim()== "أدخل رقم العميل")
            {
                txtSearchNC.Clear();
            }

            if (e.Key == Key.Enter)
            {
                
                try
                {
                    if (txtSearchNC.Text.Trim() == "")
                {
                    DataTable DataCus = DB1.DBGetData1("select * from ActivetyCU where  [رقم العميل]=" + txtSearchNC.Text.Replace("'", ""));
                        txtTotalMonyRC.Text = DB1.DBGetData1("select sum( [المبلغ المتداول]) from ActivetyCU where  [رقم العميل] =" + txtSearchNC.Text.Replace("'", "")).Rows[0][0].ToString();


                        SqlDataAdapter aed = new SqlDataAdapter(DB1.cmd1);
                    aed.Fill(DataCus);
                    DataCustomer.ItemsSource = DataCus.DefaultView;
                        
                       

                }

                    txtNumC.Text = txtSearchNC.Text;
                    txtNameC.Text= DB1.DBGetData1("select [اسم العميل] from Customer where [رقم العميل]=" + txtSearchNC.Text).Rows[0][0].ToString();
                    txtDateC.Text = DB1.DBGetData1("select [تاريخ التسليم] from Customer where [رقم العميل]=" + txtSearchNC.Text).Rows[0][0].ToString();
                    txtDebteC.Text = DB1.DBGetData1("select [المبلغ المدين] from Customer where [رقم العميل]=" + txtSearchNC.Text).Rows[0][0].ToString();
                    txtRecivedC.Text = DB1.DBGetData1("select   [المبلغ المسلم] from Customer where [رقم العميل]=" + txtSearchNC.Text).Rows[0][0].ToString();
                    txtPhonC.Text = DB1.DBGetData1("select [تلفون العميل]from Customer where [رقم العميل]=" + txtSearchNC.Text).Rows[0][0].ToString();
                    
                    DataTable DataCust = DB1.DBGetData1("select * from ActivetyCU where [رقم العميل]=" + txtSearchNC.Text);
                    SqlDataAdapter ad = new SqlDataAdapter(DB1.cmd1);
                    ad.Fill(DataCust);
                    DataCustomer.ItemsSource = DataCust.DefaultView;
                    string TypeD = "دين";
                    string TypeR = "استلام";
                    txtTotalMonyRC.Text = DB1.DBGetData1("select sum([المبلغ المتداول]) from ActivetyCU where  [رقم العميل]=" + txtSearchNC.Text+ " and [نوع النشاط]= '"+TypeD+"'").Rows[0][0].ToString();
                    txtTotalDabteC.Text = DB1.DBGetData1("select sum([المبلغ المتداول]) from ActivetyCU where  [رقم العميل]=" + txtSearchNC.Text + " and [نوع النشاط]='"+TypeR+"'").Rows[0][0].ToString();


                }
                catch (Exception exxc)
                {
                    MessageBox.Show(exxc.Message);
                }
         

            }
            
        }

        private void TxtDateC_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void BuNewC_Click(object sender, RoutedEventArgs e)
        {
            readyingC();
        }

        private void BuGardStory_Click(object sender, RoutedEventArgs e)
        {

            StorDitail HomeMain = new StorDitail();
            HomeMain.Icon = this.Icon;
            HomeMain.Show();
            this.Close();
        }

        private void Radcash_Click(object sender, RoutedEventArgs e)
        {
            txtPricePro.SelectAll();
        }

        private void ItemForEdit_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TxtCustNameS_Copy_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key==Key.Enter)
            {
                DataTable tbActive = new DataTable();
                try
                {
                    tbActive = DB1.DBGetData1("select [اسم العميل] from Customer Where [رقم العميل]=" + txtCustNO.Text.Replace("'", ""));

                    if (tbActive.Rows.Count > 0)
                        txtCustNameS.Text = DB1.DBGetData1("select  [اسم العميل] from Customer Where [رقم العميل] = " + txtCustNO.Text.Replace("'", "")).Rows[0][0].ToString();

                }
                catch(Exception emw)
                {
                    MessageBox.Show(emw.Message);
                }
                
            }
        }

        private void BuRec_Click(object sender, RoutedEventArgs e)
        {
            RecivedWin HomeMain = new RecivedWin();
            HomeMain.Icon = this.Icon;
            HomeMain.Show();
            this.Close();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void BuSaveExDec_Click(object sender, RoutedEventArgs e)
        {
            string txtEXchang = "";
            if (RadExDaylay.IsChecked==true)
            {
                txtEXchang = "Exchang";


            }else if (RadExWorckers.IsChecked == true)
            {
                txtEXchang = "ExchangWarker";

            }
            else if (RadExElecterec.IsChecked == true)
            {
                txtEXchang = "ExchangElectrec";

            }
            else if (RadExWater.IsChecked == true)
            {
                txtEXchang = "ExchangWater";

            }
            else if (RadExOther.IsChecked == true)
            {

                txtEXchang = txtExOther.Text;

            }
            DB1.Run1("insert into MonyBoxReceiving values(" + txtNumDecuEx.Text.Replace("'", "") + ",'" + txtPersonEX.Text.Replace("'", "") + "','" + txtEXchang + "'," + txtMonyExchang.Text.Replace("'", "") + ",'" + txtDateExchang.Text.Replace("'", "") + "')");

            MessageBox.Show("تمت الاضافة بنجاح");

        }

        private void BuNewExDec_Click(object sender, RoutedEventArgs e)
        {
            BuSaveExDec.IsEnabled = true;
            BuPrintEx.IsEnabled = true;
            string BoxId = DB1.DBGetData1("select max([رقم سند ق]) from MonyBoxReceiving").Rows[0][0].ToString();
            int nBoxId = (Convert.ToInt32(BoxId))+1;
            txtNumDecuEx.Text = Convert.ToString(nBoxId);
                txtDateExchang.Text = DateTime.Now.ToString();



        }

        private void BuPrintEx_Click(object sender, RoutedEventArgs e)
        {
          

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {

        }

        private void GrDataSales_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void AllViewBoxEX_Click(object sender, RoutedEventArgs e)
        {
            DataTable DataCus = DB1.DBGetData1("select * from MonyBoxexchange " );
           

            SqlDataAdapter aed = new SqlDataAdapter(DB1.cmd1);
            aed.Fill(DataCus);
            BoxDataView.ItemsSource = DataCus.DefaultView;

        }

        private void SPriceB_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void SSizeProdect_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                SStateProdect.Focus();
                SStateProdect.SelectAll();

            }
        }

        private void SStateProdect_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                SDitaileProdect.Focus();
                SDitaileProdect.SelectAll();

            }
        }

        private void SDitaileProdect_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                SCoun.Focus();
                SCoun.SelectAll();

            }
        }

        private void TxtDebteC_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TxtTypeProS_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                txtSizeProS.Focus();
                txtSizeProS.SelectAll();

            }
        }

        private void TxtSizeProS_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                txtStateProS.Focus();
                txtStateProS.SelectAll();

            }
               

        }

        private void TxtStateProS_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                txtDitail.Focus();
                txtDitail.SelectAll();

            }
           
        }

        private void TxtDitail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                txtCustNO.Focus();
                txtCustNO.SelectAll();

            }
        }

        private void TxtSalesNumber_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void BuAddSales_Click(object sender, RoutedEventArgs e)
        {
            Pro_Items_Sales ProSales = new Pro_Items_Sales();
            ProSales.proNo = txtNumProSales.Text;
            ProSales.proName = txtproName.Text;
            ProSales.proQountity = txtQountity.Text;
            ProSales.proOnePric = txtPricePro.Text;
            ProSales.proPric = txtPriceALL.Text;
            ProSales.proDitails = txtTypeProS.Text;// + ". /n " + txtSizeProS.Text + ". /n " + txtStateProS.Text+" .";
          NewDGV.Items.Add(ProSales);
            MessageBox.Show(NewDGV.Items.Count.ToString());

            Addf();
            txtDataSales.Text = DateTime.Now.ToString();

            //------------------------------

        }

        private void TxtCashS_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.Key == Key.Enter)
            {
                txtTypeProS.Focus();
                txtTypeProS.SelectAll();
                int nCashS = Convert.ToInt32(txtCashS.Text.Replace("'", ""));
                int nPriceAll = Convert.ToInt32(txtPriceALL.Text.Replace("'", ""));
                int nDabte = nPriceAll - nCashS;
                txtDabte1.Text = Convert.ToString(nDabte);

            }
        }

        private void AllViewBoxEX_Copy_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BuWorkWin_Click(object sender, RoutedEventArgs e)
        {
            
            Work HomeMain1 = new Work();
            HomeMain1.Icon = this.Icon;
            //this.Opacity = 20;
            HomeMain1.Show();
          

        }

        private void BuClose_Click(object sender, RoutedEventArgs e)
        {
            /* Work Work1 = new Work();
             Home home1 = new Home();
             RecivedWin recivedWin1 = new RecivedWin();
             storg storg1 = new storg();
             StorDitail storDitail1 = new StorDitail();

             Work1.Close();
             home1.Close();
             recivedWin1.Close();
             storg1.Close();
             storDitail1.Close();*/
           // DB1.Close1();
            //MenuRound menu = new MenuRound();
            //menu.Show();
            this.Close();

        }

        private void TextBox_TextChanged_5(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_6(object sender, TextChangedEventArgs e)
        {

        }

        private void SPriceS_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_7(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {

        }

        private void TextBox_TextChanged_8(object sender, TextChangedEventArgs e)
        {

        }

        private void BuINVOICE_Click(object sender, RoutedEventArgs e)
        {
           
            InvocActive();

            Vatorah vat = new Vatorah();
            vat.Icon = this.Icon;
            //Addf();
            vat.Show();
           
            this.Close();
        }

        private void BuAddBay_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TxtDabte_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TxtDabte1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {


            string invoice = "";
            TextBlock x0;
            TextBlock x1;
            TextBlock x2;
            TextBlock x3;
            TextBlock x4;
            TextBlock x5;
            
            try
            {
                DB1.Run1("insert into Vatorah values(1,0,'NN',0,0,0,'MM')");
                int M = NewDGV.Items.Count;
                for (int i = 0; i < M ; i++)
                {
                    x0 = NewDGV.Columns[0].GetCellContent(NewDGV.Items[i]) as TextBlock;
                    x1 = NewDGV.Columns[1].GetCellContent(NewDGV.Items[i]) as TextBlock;
                    x2 = NewDGV.Columns[2].GetCellContent(NewDGV.Items[i]) as TextBlock;
                    x3 = NewDGV.Columns[3].GetCellContent(NewDGV.Items[i]) as TextBlock;
                    x4 = NewDGV.Columns[4].GetCellContent(NewDGV.Items[i]) as TextBlock;
                    x5 = NewDGV.Columns[5].GetCellContent(NewDGV.Items[i]) as TextBlock;
                    
                    invoice = DB1.DBGetData1("select max(vatorhId)+1 from Vatorah").Rows[0][0].ToString();

                    if (x0 != null || x1 != null || x2 != null || x3 != null || x4 != null || x5 != null)
                    {

                        DB1.Run1("insert into Vatorah values(" + invoice + "," + x0.Text + ",'" + x1.Text + "'," + x2.Text + "," + x3.Text + "," + x4.Text + ",'" + x5.Text + "')");

                    }
                    else { labcastNo.Content = "No thinge"; break; }


                    
                }
                //اخذ البيانات من القرايد
               
               

            }
            catch(Exception evz)
            {
                MessageBox.Show(evz.Message);
            }

            /*
            التكملة*/
            //DB1.Run1("DELETE FROM Vatorah");
            NewDGV.Items.Clear();
            txtCustNO.Clear();
            txtCustNameS.Clear();
            txtDataSales.Clear();
        }

        private void DataGridFinlS_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TxtCustNO_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void TxtNumC_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {

        }
    }
}   
