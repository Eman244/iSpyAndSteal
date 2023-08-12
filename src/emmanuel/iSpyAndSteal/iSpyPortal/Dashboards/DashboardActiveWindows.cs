using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Utilities;
using iSpyPortal.ServiceReference1;

namespace iSpyPortal.Dashboards
{
    public partial class DashboardActiveWindows : Telerik.WinControls.UI.RadForm
    {
        public DashboardActiveWindows()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GetSystemActiveWindows();
        }

        private void DashboardActiveWindows_Load(object sender, EventArgs e)
        {
            GetSystemActiveWindows();
        }

        public void GetSystemActiveWindows()
        {
            ServiceClient client = new ServiceClient();
            var data = client.GetSystemActiveWindow(LoginManagment.SYSTEM_ID,LoginManagment.MAC_ADDRESS);
            gdvActiveWindows.DataSource = data;

        }
    }
}
