using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using Entities;
using Microsoft.Win32;
using Telerik.WinControls;
using Utilities;

namespace iSpyPortal.Dashboards
{
    public partial class Dashboard : Telerik.WinControls.UI.RadForm
    {
        
        public Dashboard()
        {
            InitializeComponent();
            

        }

      
        public bool CloseForm { get; set; }

        private void bteAddPatients_Click(object sender, EventArgs e)
        {

        }



        private void Dashboard_Load(object sender, EventArgs e)
        {
            
            
        }


      






       


        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radMenuItem4_Click(object sender, EventArgs e)
        {
            LoginManagment.Dispose();
            Application.Restart();
        }

        private void bteAddServices_Click(object sender, EventArgs e)
        {
        }

        private void btnrmiExit_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
            Application.Exit();
        }

        private void rmbtnChangePassword_Click(object sender, EventArgs e)
        {
           
        }

        private void radTileElement2_Click(object sender, EventArgs e)
        {
        }

        private void rmbtnAddSuggestion_Click(object sender, EventArgs e)
        {

        }

        private void radTileElement3_Click(object sender, EventArgs e)
        {
        }

        private void rmiMinimize_Click(object sender, EventArgs e)
        {
            this.MinimizeBox = true;
            this.WindowState = FormWindowState.Minimized;
        }

        private void rmiSuport_Click(object sender, EventArgs e)
        {

        }

        private void rmiPatientVisit_Click(object sender, EventArgs e)
        {
        }

        private void rltePatientVisit_Click(object sender, EventArgs e)
        {
        }

        private void radLiveTileElement2_Click(object sender, EventArgs e)
        {
        }

        private void radLiveTileElement1_Click(object sender, EventArgs e)
        {
        }

        private void tlteChangePassword_Click(object sender, EventArgs e)
        {
        }

        private void rlteSupport_Click(object sender, EventArgs e)
        {
           
        }

        private void rlteProfile_Click(object sender, EventArgs e)
        {
           
        }

        private void rlteSettings_Click(object sender, EventArgs e)
        {
            RadMessageBox.Show("Under Construction");
        }

        private void rlteMailBox_Click(object sender, EventArgs e)
        {
        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {



                //TimeSpan timeinterval = DateTime.Now.Subtract(logintime);
                //System.Diagnostics.EventLog.WriteEntry("Application Watcher Total Time Details", timeinterval.Hours + " Hrs " + timeinterval.Minutes + " Mins", System.Diagnostics.EventLogEntryType.Information);
                //MessageBox.Show("Actual Time Spent :" + timeinterval.Hours + " Hrs " + timeinterval.Minutes + " Mins", "Application Watcher Total Time Details");

                //StreamReader freader = new StreamReader(@"d:\appldetails.xml");
                //XmlTextReader xmlreader = new XmlTextReader(freader);
                //string tottime = "";
                //while (xmlreader.Read())
                //{
                //    if (xmlreader.NodeType == XmlNodeType.Element && xmlreader.Name == "TotalSeconds")
                //    {
                //        tottime += ";" + xmlreader.ReadInnerXml().ToString();
                //    }
                //}
                //string[] tottimes = tottime.Split(';');
                //long totsecs = 0;
                //foreach (string str in tottimes)
                //{
                //    if (str != string.Empty)
                //    {
                //        if (str.IndexOf("Seconds") != -1)
                //        {
                //            totsecs += Convert.ToInt64(str.Substring(0, str.Length - 8));

                //        }
                //        else
                //        {
                //            totsecs += Convert.ToInt64(str.Substring(0, str.Length - 8)) * 60;
                //        }
                //    }
                //}
                //MessageBox.Show((totsecs / 60) + " Minutes");
                //showdetailsinIE();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Application.ExitThread();
        }

        //private void showdetailsinIE()
        //{
        //    //To create XSL file,if it is not existing....
        //    if (!File.Exists(@"d:\appl_xsl.xsl"))
        //    {
        //        File.Create(@"d:\appl_xsl.xsl").Close();
        //        string xslcontents = "<?xml version=\"1.0\" encoding=\"ISO-8859-1\"?><xsl:stylesheet version=\"1.0\" xmlns:xsl=\"http://www.w3.org/1999/XSL/Transform\"><xsl:template match=\"/\"> <html> <body>  <h2>My Applications Details</h2>  <table border=\"1\"> <tr bgcolor=\"#9acd32\">  <th>Window Title</th>  <th>Process Name</th>  <th>Total Time</th> </tr> <xsl:for-each select=\"ApplDetails/Application_Info\"><xsl:sort select=\"ApplicationName\"/> <tr>  <td><xsl:value-of select=\"ProcessName\"/></td>  <td><xsl:value-of select=\"ApplicationName\"/></td>  <td><xsl:value-of select=\"TotalSeconds\"/></td> </tr> </xsl:for-each>  </table> </body> </html></xsl:template></xsl:stylesheet>";
        //        StreamWriter xslwriter = new StreamWriter(@"d:\appl_xsl.xsl");
        //        xslwriter.Write(xslcontents);
        //        xslwriter.Flush();
        //        xslwriter.Close();
        //    }
        //    //TO show the contents of xml file in IE with a proper xsl....
        //    System.Diagnostics.Process ie = new Process();
        //    System.Diagnostics.ProcessStartInfo ieinfo = new ProcessStartInfo(@"D:\Program Files\Internet Explorer\iexplore.exe", @"D:\appldetails.xml");
        //    ie.StartInfo = ieinfo;
        //    bool started = ie.Start();
        //    Application.Exit();
        //}

        private void rteServiceCosting_Click(object sender, EventArgs e)
        {
        }

        private void rteReceptionist_Click(object sender, EventArgs e)
        {
        }

        private void grpElementModules_Click(object sender, EventArgs e)
        {
        }

        private void radLiveTileElement2_Click_1(object sender, EventArgs e)
        {
        }

        private void grpElementServices_Click(object sender, EventArgs e)
        {
        }

        private void dteFinance_Click(object sender, EventArgs e)
        {
        }

        private void rteLab_Click(object sender, EventArgs e)
        {
        }

        private void rteRefund_Click(object sender, EventArgs e)
        {
        }

        private void radLiveTileElement4_Click(object sender, EventArgs e)
        {
        }

        private void rteCNEAccts_Click(object sender, EventArgs e)
        {
        }

        private void radTileElement1_Click(object sender, EventArgs e)
        {
        }
        private void radLiveTileElement5_Click(object sender, EventArgs e)
        {
           
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radLiveTileElementDisease_Click(object sender, EventArgs e)
        {

        }

        private void rteDashboardVendor_Click(object sender, EventArgs e)
        {
        }

        private void rteDashboardInventory_Click(object sender, EventArgs e)
        {
        }

        private void rteDashboardPO_Click(object sender, EventArgs e)
        {
        }

        private void rteDashboardPayRoll_Click(object sender, EventArgs e)
        {
        }

        private void rteDashboardPanels_Click(object sender, EventArgs e)
        {
        }

        private void rteDashboardAdmission_Click(object sender, EventArgs e)
        {
        }

        private void grpElementAdmin_Click(object sender, EventArgs e)
        {

        }

        private void grpProperty_Click(object sender, EventArgs e)
        {

        }


        // Newly Added code for Property Module
        private void rteDashboardProperty_Click(object sender, EventArgs e)
        {
        }

        private void rteDashboardPropertyDemand_Click(object sender, EventArgs e)
        {
        }

        private void rteDashboardPropertyLPAppComm_Click(object sender, EventArgs e)
        {
        }

        private void rteDashboardPropertyMgmt_Click(object sender, EventArgs e)
        {
        }

        private void rteDashboardPropertyQuotes_Click(object sender, EventArgs e)
        {

        }

        private void rteDashboardPropertyPO_Click(object sender, EventArgs e)
        {
        }

        private void rteDashboardPropertyBill_Click(object sender, EventArgs e)
        {
        }



        private void rteDashboardPropertyCBillMgmt_Click(object sender, EventArgs e)
        {
        }

        private void rteDashboardPropertyBook_Click(object sender, EventArgs e)
        {
        }

        private void DashboardPanaroma_Click(object sender, EventArgs e)
        {

        }

        private void rteSystemInformation_Click(object sender, EventArgs e)
        {
           
        }

        private void rteDriveInformation_Click(object sender, EventArgs e)
        {
            var obj = new Dashboards.DashboardVoulme();
            obj.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }


        private void rteCPUInformation_Click(object sender, EventArgs e)
        {

        }

        private void rteDashboardNetwork_Click(object sender, EventArgs e)
        {
            var obj = new Dashboards.DashboardNetwork();
            obj.Show();
        }

        private void rteDashboardCpu_Click(object sender, EventArgs e)
        {
            var obj = new Dashboards.DashboardCpuUsage();
            obj.Show();
        }

        private void rteDashboardMemory_Click(object sender, EventArgs e)
        {
            var obj = new Dashboards.DashboardMemory();
            obj.Show();
        }

        private void rteDashboardVideos_Click(object sender, EventArgs e)
        {
            var obj = new Dashboards.DashboardVideos();
            obj.Show();
        }

        private void rteDashboardSound_Click(object sender, EventArgs e)
        {
            var obj = new Dashboards.DashboardSound();
            obj.Show();
        }

        private void rteDashboardPointingDevice_Click(object sender, EventArgs e)
        {
            var obj = new Dashboards.DashboardPointingDevice();
            obj.Show();
        }

        private void rteDashboardActiveWindows_Click(object sender, EventArgs e)
        {
            var obj = new Dashboards.DashboardActiveWindows();
            obj.Show();
        }

        private void rteDashboardPorts_Click(object sender, EventArgs e)
        {
            var obj = new Dashboards.DashboardPorts();
            obj.Show();
        }

        private void rteSystemInformation_Click_1(object sender, EventArgs e)
        {

        }

        private void rteDashboardVoulme_Click(object sender, EventArgs e)
        {
            var obj = new Dashboards.DashboardVoulme();
            obj.Show();
        }

        private void rteDashboardMemoryUsage_Click(object sender, EventArgs e)
        {
            var obj = new Dashboards.DashboardMemoryUsage();
            obj.Show();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
          
        }

        private void radDropDownButton1_Click(object sender, EventArgs e)
        {
          
        }

      

        private void timer3_Tick(object sender, EventArgs e)
        {
           

        }

       

        private void timer4_Tick(object sender, EventArgs e)
        {
           
        }

        private void radTileElement1_Click_1(object sender, EventArgs e)
        {
            var obj = new Dashboards.DashboardBrowser();
            obj.Show();
        }
    }
}
