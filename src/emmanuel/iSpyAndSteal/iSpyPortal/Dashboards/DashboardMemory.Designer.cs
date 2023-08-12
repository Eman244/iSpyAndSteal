namespace iSpyPortal.Dashboards
{
    partial class DashboardMemory
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn9 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn10 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn11 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.crystalTheme1 = new Telerik.WinControls.Themes.CrystalTheme();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.gdvMemoryInformation = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvMemoryInformation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvMemoryInformation.MasterTemplate)).BeginInit();
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
            this.radPanel1.Controls.Add(this.gdvMemoryInformation);
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPanel1.Location = new System.Drawing.Point(0, 0);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(1414, 741);
            this.radPanel1.TabIndex = 0;
            // 
            // gdvMemoryInformation
            // 
            this.gdvMemoryInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.gdvMemoryInformation.Cursor = System.Windows.Forms.Cursors.Default;
            this.gdvMemoryInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdvMemoryInformation.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.gdvMemoryInformation.ForeColor = System.Drawing.Color.Black;
            this.gdvMemoryInformation.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gdvMemoryInformation.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.gdvMemoryInformation.MasterTemplate.AllowAddNewRow = false;
            this.gdvMemoryInformation.MasterTemplate.AllowColumnReorder = false;
            this.gdvMemoryInformation.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "ID";
            gridViewTextBoxColumn1.HeaderText = "ID";
            gridViewTextBoxColumn1.Name = "ID";
            gridViewTextBoxColumn1.ReadOnly = true;
            gridViewTextBoxColumn1.Width = 126;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "ATTRIBUTES";
            gridViewTextBoxColumn2.HeaderText = "ATTRIBUTE";
            gridViewTextBoxColumn2.Name = "ATTRIBUTES";
            gridViewTextBoxColumn2.ReadOnly = true;
            gridViewTextBoxColumn2.Width = 126;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "CAPACITY";
            gridViewTextBoxColumn3.HeaderText = "CAPACITY";
            gridViewTextBoxColumn3.Name = "CAPACITY";
            gridViewTextBoxColumn3.ReadOnly = true;
            gridViewTextBoxColumn3.Width = 126;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "CAPTION";
            gridViewTextBoxColumn4.HeaderText = "CAPTION";
            gridViewTextBoxColumn4.Name = "CAPTION";
            gridViewTextBoxColumn4.ReadOnly = true;
            gridViewTextBoxColumn4.Width = 126;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "DEVICE_LOCATOR";
            gridViewTextBoxColumn5.HeaderText = "DEVICE LOCATION";
            gridViewTextBoxColumn5.Name = "DEVICE_LOCATOR";
            gridViewTextBoxColumn5.ReadOnly = true;
            gridViewTextBoxColumn5.Width = 126;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "MANUFACTURER";
            gridViewTextBoxColumn6.HeaderText = "MANUFACTURER";
            gridViewTextBoxColumn6.Name = "MANUFACTURER";
            gridViewTextBoxColumn6.ReadOnly = true;
            gridViewTextBoxColumn6.Width = 126;
            gridViewTextBoxColumn7.EnableExpressionEditor = false;
            gridViewTextBoxColumn7.FieldName = "SERIAL_NO";
            gridViewTextBoxColumn7.HeaderText = "SERIAL NO";
            gridViewTextBoxColumn7.Name = "SERIAL_NO";
            gridViewTextBoxColumn7.ReadOnly = true;
            gridViewTextBoxColumn7.Width = 126;
            gridViewTextBoxColumn8.EnableExpressionEditor = false;
            gridViewTextBoxColumn8.FieldName = "SPEED";
            gridViewTextBoxColumn8.HeaderText = "SPEED";
            gridViewTextBoxColumn8.Name = "SPEED";
            gridViewTextBoxColumn8.ReadOnly = true;
            gridViewTextBoxColumn8.Width = 126;
            gridViewTextBoxColumn9.EnableExpressionEditor = false;
            gridViewTextBoxColumn9.FieldName = "COMPUTER_NAME";
            gridViewTextBoxColumn9.HeaderText = "COMPUTER NAME";
            gridViewTextBoxColumn9.Name = "COMPUTER_NAME";
            gridViewTextBoxColumn9.ReadOnly = true;
            gridViewTextBoxColumn9.Width = 126;
            gridViewTextBoxColumn10.EnableExpressionEditor = false;
            gridViewTextBoxColumn10.FieldName = "SYSTEM_UP_TIME";
            gridViewTextBoxColumn10.HeaderText = "SYSTEM UP TIME";
            gridViewTextBoxColumn10.Name = "SYSTEM_UP_TIME";
            gridViewTextBoxColumn10.ReadOnly = true;
            gridViewTextBoxColumn10.Width = 126;
            gridViewTextBoxColumn11.EnableExpressionEditor = false;
            gridViewTextBoxColumn11.FieldName = "LOGIN_NAME";
            gridViewTextBoxColumn11.HeaderText = "USER NAME";
            gridViewTextBoxColumn11.Name = "LOGIN_NAME";
            gridViewTextBoxColumn11.ReadOnly = true;
            gridViewTextBoxColumn11.Width = 122;
            this.gdvMemoryInformation.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8,
            gridViewTextBoxColumn9,
            gridViewTextBoxColumn10,
            gridViewTextBoxColumn11});
            this.gdvMemoryInformation.MasterTemplate.EnablePaging = true;
            this.gdvMemoryInformation.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.gdvMemoryInformation.Name = "gdvMemoryInformation";
            this.gdvMemoryInformation.ReadOnly = true;
            this.gdvMemoryInformation.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gdvMemoryInformation.Size = new System.Drawing.Size(1414, 741);
            this.gdvMemoryInformation.TabIndex = 0;
            this.gdvMemoryInformation.ThemeName = "Crystal";
            // 
            // DashboardMemory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1414, 741);
            this.Controls.Add(this.radPanel1);
            this.Name = "DashboardMemory";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Memory Information";
            this.ThemeName = "Crystal";
            this.Load += new System.EventHandler(this.DashboardMemory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdvMemoryInformation.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvMemoryInformation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.Themes.CrystalTheme crystalTheme1;
        private System.Windows.Forms.Timer timer1;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadGridView gdvMemoryInformation;
    }
}
