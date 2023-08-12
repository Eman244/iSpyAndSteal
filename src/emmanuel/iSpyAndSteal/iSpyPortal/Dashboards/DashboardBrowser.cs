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
    public partial class DashboardBrowser : Telerik.WinControls.UI.RadForm
    {
        public DashboardBrowser()
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
            var data = client.getBrowserHistoryAll(int.Parse(LoginManagment.SYSTEM_ID.ToString()),0);
            gdvActiveWindows.DataSource = data;

        }
    }
}
