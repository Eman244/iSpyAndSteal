namespace iSpyPortal.Dashboards
{
    partial class DashboardPorts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.crystalTheme1 = new Telerik.WinControls.Themes.CrystalTheme();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.gdvPortsInfo = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvPortsInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvPortsInfo.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.gdvPortsInfo);
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPanel1.Location = new System.Drawing.Point(0, 0);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(1356, 736);
            this.radPanel1.TabIndex = 0;
            // 
            // gdvPortsInfo
            // 
            this.gdvPortsInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.gdvPortsInfo.Cursor = System.Windows.Forms.Cursors.Default;
            this.gdvPortsInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdvPortsInfo.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.gdvPortsInfo.ForeColor = System.Drawing.Color.Black;
            this.gdvPortsInfo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gdvPortsInfo.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.gdvPortsInfo.MasterTemplate.AllowAddNewRow = false;
            this.gdvPortsInfo.MasterTemplate.AllowColumnReorder = false;
            this.gdvPortsInfo.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "ID";
            gridViewTextBoxColumn1.HeaderText = "ID";
            gridViewTextBoxColumn1.Name = "ID";
            gridViewTextBoxColumn1.ReadOnly = true;
            gridViewTextBoxColumn1.Width = 166;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "DESCRIPTION";
            gridViewTextBoxColumn2.HeaderText = "DESCRIPTION";
            gridViewTextBoxColumn2.Name = "DESCRIPTION";
            gridViewTextBoxColumn2.ReadOnly = true;
            gridViewTextBoxColumn2.Width = 166;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "TAG";
            gridViewTextBoxColumn3.HeaderText = "TAG";
            gridViewTextBoxColumn3.Name = "TAG";
            gridViewTextBoxColumn3.ReadOnly = true;
            gridViewTextBoxColumn3.Width = 166;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "MAC_ADDRESS";
            gridViewTextBoxColumn4.HeaderText = "MAC ADDRESS";
            gridViewTextBoxColumn4.Name = "MAC_ADDRESS";
            gridViewTextBoxColumn4.ReadOnly = true;
            gridViewTextBoxColumn4.Width = 166;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "ACCOUNT_NAME";
            gridViewTextBoxColumn5.HeaderText = "ACCOUNT NAME";
            gridViewTextBoxColumn5.Name = "ACCOUNT_NAME";
            gridViewTextBoxColumn5.ReadOnly = true;
            gridViewTextBoxColumn5.Width = 166;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "SYSTEM_UP_TIME";
            gridViewTextBoxColumn6.HeaderText = "SYSTEM UP TIME";
            gridViewTextBoxColumn6.Name = "SYSTEM_UP_TIME";
            gridViewTextBoxColumn6.ReadOnly = true;
            gridViewTextBoxColumn6.Width = 166;
            gridViewTextBoxColumn7.EnableExpressionEditor = false;
            gridViewTextBoxColumn7.FieldName = "LOGIN_NAME";
            gridViewTextBoxColumn7.HeaderText = "USER NAME";
            gridViewTextBoxColumn7.Name = "LOGIN_NAME";
            gridViewTextBoxColumn7.ReadOnly = true;
            gridViewTextBoxColumn7.Width = 166;
            gridViewTextBoxColumn8.EnableExpressionEditor = false;
            gridViewTextBoxColumn8.FieldName = "COMPANY";
            gridViewTextBoxColumn8.HeaderText = "COMPANY";
            gridViewTextBoxColumn8.Name = "COMPANY";
            gridViewTextBoxColumn8.ReadOnly = true;
            gridViewTextBoxColumn8.Width = 162;
            this.gdvPortsInfo.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8});
            this.gdvPortsInfo.MasterTemplate.EnablePaging = true;
            this.gdvPortsInfo.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.gdvPortsInfo.Name = "gdvPortsInfo";
            this.gdvPortsInfo.ReadOnly = true;
            this.gdvPortsInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gdvPortsInfo.Size = new System.Drawing.Size(1356, 736);
            this.gdvPortsInfo.TabIndex = 0;
            this.gdvPortsInfo.ThemeName = "Crystal";
            // 
            // DashboardPorts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 736);
            this.Controls.Add(this.radPanel1);
            this.Name = "DashboardPorts";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.RootElement.MaxSize = new System.Drawing.Size(0, 0);
            this.Text = "Ports Information";
            this.ThemeName = "Crystal";
            this.Load += new System.EventHandler(this.DashboardPorts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdvPortsInfo.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvPortsInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.Themes.CrystalTheme crystalTheme1;
        private System.Windows.Forms.Timer timer1;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadGridView gdvPortsInfo;
    }
}
