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
    public partial class DashboardSound : Telerik.WinControls.UI.RadForm
    {
        public DashboardSound()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GetSystemSoundInfo();
        }

        public void GetSystemSoundInfo()
        {
            ServiceClient client = new ServiceClient();
            var data = client.GetSystemSound(LoginManagment.SYSTEM_ID, LoginManagment.MAC_ADDRESS);
            gdvSoundInfo.DataSource = data;
        }

        private void DashboardSound_Load(object sender, EventArgs e)
        {
            GetSystemSoundInfo();
        }
    }
}
