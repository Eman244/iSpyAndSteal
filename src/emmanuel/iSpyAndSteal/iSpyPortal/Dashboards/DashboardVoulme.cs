using iSpyPortal.ServiceReference1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Utilities;

namespace iSpyPortal.Dashboards
{
    public partial class DashboardVoulme : RadForm
    {
        public DashboardVoulme()
        {
            InitializeComponent();
        }

        private void DrivesInformation_Load(object sender, EventArgs e)
        {
            GetSystemVolumeInfo();
        }

        public void GetSystemVolumeInfo()
        {
            ServiceClient client = new ServiceClient();
            var data = client.GetSystemVolume(LoginManagment.SYSTEM_ID, LoginManagment.MAC_ADDRESS);
            gdvDriveInfo.DataSource = data;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GetSystemVolumeInfo();
        }
    }
}
