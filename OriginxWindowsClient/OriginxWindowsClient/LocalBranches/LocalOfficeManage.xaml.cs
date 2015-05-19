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

namespace OriginxWindowsClient.LocalBranches
{
    /// <summary>
    /// Interaction logic for LocalOfficeManage.xaml
    /// </summary>
    public partial class LocalOfficeManage : Window
    {
        public LocalOfficeManage()
        {
            InitializeComponent();
        }

        private void coutrybranchcode_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            LocalBranchService.LocalBranchServiceClient Client = new LocalBranchService.LocalBranchServiceClient();
            LocalBranchService.LocalBranchClass LB = new LocalBranchService.LocalBranchClass();
            LB.Countrybranchcod = coutrybranchcode.Text;
            LB.Branchadmin = branchadmin.Text;
            LB.Branchcity = branchcity.Text;
            LB.Branchdesc = branchdec.Text;
            Client.AddLocalBranch(LB);
            
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }
    }
}
