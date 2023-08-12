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
    public partial class DashboardPointingDevice : Telerik.WinControls.UI.RadForm
    {
        public DashboardPointingDevice()
        {
            InitializeComponent();
        }

        private void DashboardPointingDevice_Load(object sender, EventArgs e)
        {
            GetSystemPointingDevicenfo();
        }
        public void GetSystemPointingDevicenfo()
        {
            ServiceClient client = new ServiceClient();
            var data = client.GetSystemPointingDevice(LoginManagment.SYSTEM_ID, LoginManagment.MAC_ADDRESS);
            gdvPointingInfo.DataSource = data;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GetSystemPointingDevicenfo();
        }
    }
}
