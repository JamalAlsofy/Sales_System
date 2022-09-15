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
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace ONEX_Seles
{
    /// <summary>
    /// Interaction logic for Vatorah.xaml
    /// </summary>
    public partial class Vatorah : Window
    {
        Main awe = new Main();
        static string textprod;
        public Vatorah()
        {
            Main mm = new Main();
          //  mm.SaveS2S();

            InitializeComponent();
            V2();
            textprod = awe.txtNumProSales.Text;
           // awe.InvocActive();

        }
        private void V2()
        {
           
          
        
              


        }

        private void Viewer1_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                MySalesData set = new MySalesData();
                ReportDocument report = new ReportDocument();
                report.Load(@"C:\Users\DeveloperSalesMango\source\repos\ONEX_Seles\ONEX_Seles\CRF.rpt");
                report.SetDataSource(set);
                
                /* using (cvmakerEntities1 db = new cvmakerEntities1())
                  {
                      report.SetDataSource(from c in db.cvs
                                           select new { c.Full_Name, c.Address, c.E_Mail, c.Activities, c.Birth_Day, c.Courses, c.Education, c.Experience, c.Gender, c.Mobile, c.Nationality, c.Occuptional_Field, c.Personnal_Website, c.photo, c.Skills, c.Tele });
                  }*/
                Viewer1.ViewerCore.ReportSource = report;


            }
            catch (Exception nnex) { MessageBox.Show(nnex.Message); }
            

        }
    }
}
