namespace iSpyPortal.Dashboards
{
    partial class DashboardNetwork
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.crystalTheme1 = new Telerik.WinControls.Themes.CrystalTheme();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.gdvNetworkInfo = new Telerik.WinControls.UI.RadGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvNetworkInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvNetworkInfo.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gdvNetworkInfo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1356, 736);
            this.panel1.TabIndex = 0;
            // 
            // gdvNetworkInfo
            // 
            this.gdvNetworkInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.gdvNetworkInfo.Cursor = System.Windows.Forms.Cursors.Default;
            this.gdvNetworkInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdvNetworkInfo.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.gdvNetworkInfo.ForeColor = System.Drawing.Color.Black;
            this.gdvNetworkInfo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gdvNetworkInfo.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.gdvNetworkInfo.MasterTemplate.AllowAddNewRow = false;
            this.gdvNetworkInfo.MasterTemplate.AllowColumnReorder = false;
            this.gdvNetworkInfo.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "ID";
            gridViewTextBoxColumn1.HeaderText = "ID";
            gridViewTextBoxColumn1.Name = "ID";
            gridViewTextBoxColumn1.ReadOnly = true;
            gridViewTextBoxColumn1.Width = 221;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "NAME";
            gridViewTextBoxColumn2.HeaderText = "NAME";
            gridViewTextBoxColumn2.Name = "NAME";
            gridViewTextBoxColumn2.ReadOnly = true;
            gridViewTextBoxColumn2.Width = 221;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "DESCRIPTION";
            gridViewTextBoxColumn3.HeaderText = "DESCRIPTION";
            gridViewTextBoxColumn3.Name = "DESCRIPTION";
            gridViewTextBoxColumn3.ReadOnly = true;
            gridViewTextBoxColumn3.Width = 221;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "SPEED";
            gridViewTextBoxColumn4.HeaderText = "SPEED";
            gridViewTextBoxColumn4.Name = "SPEED";
            gridViewTextBoxColumn4.ReadOnly = true;
            gridViewTextBoxColumn4.Width = 221;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "SYSTEM_UP_TIME";
            gridViewTextBoxColumn5.HeaderText = "SYSTEM UP TIME";
            gridViewTextBoxColumn5.Name = "SYSTEM_UP_TIME";
            gridViewTextBoxColumn5.ReadOnly = true;
            gridViewTextBoxColumn5.Width = 221;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "LOGIN_NAME";
            gridViewTextBoxColumn6.HeaderText = "USER NAME";
            gridViewTextBoxColumn6.Name = "LOGIN_NAME";
            gridViewTextBoxColumn6.ReadOnly = true;
            gridViewTextBoxColumn6.Width = 219;
            this.gdvNetworkInfo.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6});
            this.gdvNetworkInfo.MasterTemplate.EnablePaging = true;
            this.gdvNetworkInfo.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.gdvNetworkInfo.Name = "gdvNetworkInfo";
            this.gdvNetworkInfo.ReadOnly = true;
            this.gdvNetworkInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gdvNetworkInfo.Size = new System.Drawing.Size(1356, 736);
            this.gdvNetworkInfo.TabIndex = 0;
            this.gdvNetworkInfo.ThemeName = "Crystal";
            // 
            // DashboardNetwork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 736);
            this.Controls.Add(this.panel1);
            this.Name = "DashboardNetwork";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.RootElement.MaxSize = new System.Drawing.Size(0, 0);
            this.Text = "Network Information";
            this.ThemeName = "Crystal";
            this.Load += new System.EventHandler(this.DashboardNetwork_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdvNetworkInfo.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvNetworkInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.Themes.CrystalTheme crystalTheme1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private Telerik.WinControls.UI.RadGridView gdvNetworkInfo;
    }
}
