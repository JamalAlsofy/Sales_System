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
    /// Interaction logic for Work.xaml
    /// </summary>
    public partial class Work : Window
    {
        public Work()
        {
            InitializeComponent();
        }

        private void BuRetuarnToMain_Click(object sender, RoutedEventArgs e)
        {
           
            Main Main2 = new Main();
            Main2.Opacity =  100  ;
            this.Close();

        }

        private void UW_KeyDown_1(object sender, KeyEventArgs e)
        {

        }

        private void TxtworkMony_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void TxtWorkName_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void TxtWorkTime_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void TxtWorkDebte_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void TxtWorkCustNo_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void UW_Copy4_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void TxtWorkCustName_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void TxtWorkDate_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
