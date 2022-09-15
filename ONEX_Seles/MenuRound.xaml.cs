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

namespace ONEX_Seles
{
    /// <summary>
    /// Interaction logic for MenuRound.xaml
    /// </summary>
    public partial class MenuRound : Window
    {
      
        public class Employee
        {
            public string proNo { get; set; }
            public string proName { get; set; }
            public string proQountity { get; set; }
            public string proOnePric { get; set; }
            public string proPric { get; set; }
            public string proDitails { get; set; }



        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Employee employee1 = new Employee();
            employee1.proNo = txtproNo.Text;
            employee1.proName = txtproName.Text;
            employee1.proQountity = txtQountity.Text;
            employee1.proOnePric = txtOnePric.Text;
            employee1.proPric = txtPric.Text;
            employee1.proDitails = "لا يوجد";

            DataGritXAML1.Items.Add(employee1);

            txtproNo.Clear();
            txtproName.Clear();
            txtQountity.Clear();
            txtOnePric.Clear();
            txtPric.Clear();


        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.DataGritXAML1.Items.Clear();
            DataGritXAML1.Items.Refresh();


        }
    }
}
