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
    public partial class DashboardMemoryUsage : Telerik.WinControls.UI.RadForm
    {
        public DashboardMemoryUsage()
        {
            InitializeComponent();
        }

        private void DashboardMemoryUsage_Load(object sender, EventArgs e)
        {
            GetSystemMemoryInfo();
        }

        public void GetSystemMemoryInfo()
        {
            ServiceClient client = new ServiceClient();
            var data = client.GetSystemMemoryUsage(LoginManagment.SYSTEM_ID, LoginManagment.MAC_ADDRESS);
            gdvMemoryUsage.DataSource = data;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GetSystemMemoryInfo();
        }
    }
}
