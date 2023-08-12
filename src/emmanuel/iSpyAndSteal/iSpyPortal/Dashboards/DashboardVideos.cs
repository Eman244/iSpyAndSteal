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
    public partial class DashboardVideos : Telerik.WinControls.UI.RadForm
    {
        public DashboardVideos()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GetSystemVideoControllerInfo();
        }
        public void GetSystemVideoControllerInfo()
        {
            ServiceClient client = new ServiceClient();
            var data = client.GetSystemVideoControllers(LoginManagment.SYSTEM_ID, LoginManagment.MAC_ADDRESS);
            gdvVideoInfo.DataSource = data;
        }

        private void DashboardVideos_Load(object sender, EventArgs e)
        {
            GetSystemVideoControllerInfo();
        }
    }
}
