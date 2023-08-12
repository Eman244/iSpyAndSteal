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
    public partial class DashboardPorts : Telerik.WinControls.UI.RadForm
    {
        public DashboardPorts()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GetSystemPortsnfo();
        }

        public void GetSystemPortsnfo()
        {
            ServiceClient client = new ServiceClient();
            var data = client.GetSystemPorts(LoginManagment.SYSTEM_ID, LoginManagment.MAC_ADDRESS);
            gdvPortsInfo.DataSource = data;
        }

        private void DashboardPorts_Load(object sender, EventArgs e)
        {
            GetSystemPortsnfo();
        }
    }
}
