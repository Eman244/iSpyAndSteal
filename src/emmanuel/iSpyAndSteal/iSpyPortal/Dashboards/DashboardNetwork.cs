using iSpyPortal.ServiceReference1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Utilities;

namespace iSpyPortal.Dashboards
{
    public partial class DashboardNetwork : Telerik.WinControls.UI.RadForm
    {
        public DashboardNetwork()
        {
            InitializeComponent();
        }

        private void DashboardNetwork_Load(object sender, EventArgs e)
        {
            GetSystemNetworkInfo();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GetSystemNetworkInfo();
        }

        public void GetSystemNetworkInfo()
        {
            ServiceClient client = new ServiceClient();
            var data = client.GetSystemNetwork(LoginManagment.SYSTEM_ID, LoginManagment.MAC_ADDRESS);
            gdvNetworkInfo.DataSource = data;
        }
    }
}
