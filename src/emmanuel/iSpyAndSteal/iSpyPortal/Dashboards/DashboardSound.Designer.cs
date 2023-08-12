namespace iSpyPortal.Dashboards
{
    partial class DashboardSound
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.crystalTheme1 = new Telerik.WinControls.Themes.CrystalTheme();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.gdvSoundInfo = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvSoundInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvSoundInfo.MasterTemplate)).BeginInit();
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
            this.radPanel1.Controls.Add(this.gdvSoundInfo);
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPanel1.Location = new System.Drawing.Point(0, 0);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(1414, 741);
            this.radPanel1.TabIndex = 0;
            // 
            // gdvSoundInfo
            // 
            this.gdvSoundInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.gdvSoundInfo.Cursor = System.Windows.Forms.Cursors.Default;
            this.gdvSoundInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdvSoundInfo.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.gdvSoundInfo.ForeColor = System.Drawing.Color.Black;
            this.gdvSoundInfo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gdvSoundInfo.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.gdvSoundInfo.MasterTemplate.AllowAddNewRow = false;
            this.gdvSoundInfo.MasterTemplate.AllowColumnReorder = false;
            this.gdvSoundInfo.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "ID";
            gridViewTextBoxColumn1.HeaderText = "ID";
            gridViewTextBoxColumn1.Name = "ID";
            gridViewTextBoxColumn1.ReadOnly = true;
            gridViewTextBoxColumn1.Width = 154;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "NAME";
            gridViewTextBoxColumn2.HeaderText = "NAME";
            gridViewTextBoxColumn2.Name = "NAME";
            gridViewTextBoxColumn2.ReadOnly = true;
            gridViewTextBoxColumn2.Width = 154;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "DESCRIPTION";
            gridViewTextBoxColumn3.HeaderText = "DESCRIPTION";
            gridViewTextBoxColumn3.Name = "DESCRIPTION";
            gridViewTextBoxColumn3.ReadOnly = true;
            gridViewTextBoxColumn3.Width = 154;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "MANUFACTURER";
            gridViewTextBoxColumn4.HeaderText = "MANUFACTURER";
            gridViewTextBoxColumn4.Name = "MANUFACTURER";
            gridViewTextBoxColumn4.Width = 154;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "SYSTEM_NAME";
            gridViewTextBoxColumn5.HeaderText = "SYSTEM NAME";
            gridViewTextBoxColumn5.Name = "SYSTEM_NAME";
            gridViewTextBoxColumn5.ReadOnly = true;
            gridViewTextBoxColumn5.Width = 154;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "MAC_ADDRESS";
            gridViewTextBoxColumn6.HeaderText = "MAC ADDRESS";
            gridViewTextBoxColumn6.Name = "MAC_ADDRESS";
            gridViewTextBoxColumn6.Width = 154;
            gridViewTextBoxColumn7.EnableExpressionEditor = false;
            gridViewTextBoxColumn7.FieldName = "SYSTEM_UP_TIME";
            gridViewTextBoxColumn7.HeaderText = "SYSTEM UP TIME";
            gridViewTextBoxColumn7.Name = "SYSTEM_UP_TIME";
            gridViewTextBoxColumn7.ReadOnly = true;
            gridViewTextBoxColumn7.Width = 154;
            gridViewTextBoxColumn8.EnableExpressionEditor = false;
            gridViewTextBoxColumn8.FieldName = "LOGIN_NAME";
            gridViewTextBoxColumn8.HeaderText = "USER NAME";
            gridViewTextBoxColumn8.Name = "LOGIN_NAME";
            gridViewTextBoxColumn8.ReadOnly = true;
            gridViewTextBoxColumn8.Width = 154;
            gridViewTextBoxColumn9.EnableExpressionEditor = false;
            gridViewTextBoxColumn9.FieldName = "COMPANY";
            gridViewTextBoxColumn9.HeaderText = "COMPANY";
            gridViewTextBoxColumn9.Name = "COMPANY";
            gridViewTextBoxColumn9.ReadOnly = true;
            gridViewTextBoxColumn9.Width = 150;
            this.gdvSoundInfo.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8,
            gridViewTextBoxColumn9});
            this.gdvSoundInfo.MasterTemplate.EnablePaging = true;
            this.gdvSoundInfo.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.gdvSoundInfo.Name = "gdvSoundInfo";
            this.gdvSoundInfo.ReadOnly = true;
            this.gdvSoundInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gdvSoundInfo.Size = new System.Drawing.Size(1414, 741);
            this.gdvSoundInfo.TabIndex = 0;
            this.gdvSoundInfo.ThemeName = "Crystal";
            // 
            // DashboardSound
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1414, 741);
            this.Controls.Add(this.radPanel1);
            this.Name = "DashboardSound";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.RootElement.MaxSize = new System.Drawing.Size(0, 0);
            this.Text = "Sound Device\'s Information";
            this.ThemeName = "Crystal";
            this.Load += new System.EventHandler(this.DashboardSound_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdvSoundInfo.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvSoundInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.Themes.CrystalTheme crystalTheme1;
        private System.Windows.Forms.Timer timer1;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadGridView gdvSoundInfo;
    }
}
