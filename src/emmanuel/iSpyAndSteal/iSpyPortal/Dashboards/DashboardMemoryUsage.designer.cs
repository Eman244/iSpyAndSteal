namespace iSpyPortal.Dashboards
{
    partial class DashboardMemoryUsage
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn9 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn10 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            this.crystalTheme1 = new Telerik.WinControls.Themes.CrystalTheme();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.gdvMemoryUsage = new Telerik.WinControls.UI.RadGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvMemoryUsage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvMemoryUsage.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.gdvMemoryUsage);
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPanel1.Location = new System.Drawing.Point(0, 0);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(1356, 741);
            this.radPanel1.TabIndex = 0;
            // 
            // gdvMemoryUsage
            // 
            this.gdvMemoryUsage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.gdvMemoryUsage.Cursor = System.Windows.Forms.Cursors.Default;
            this.gdvMemoryUsage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdvMemoryUsage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.gdvMemoryUsage.ForeColor = System.Drawing.Color.Black;
            this.gdvMemoryUsage.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gdvMemoryUsage.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.gdvMemoryUsage.MasterTemplate.AllowAddNewRow = false;
            this.gdvMemoryUsage.MasterTemplate.AllowColumnReorder = false;
            this.gdvMemoryUsage.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "ID";
            gridViewTextBoxColumn6.HeaderText = "ID";
            gridViewTextBoxColumn6.Name = "ID";
            gridViewTextBoxColumn6.ReadOnly = true;
            gridViewTextBoxColumn6.Width = 265;
            gridViewTextBoxColumn7.EnableExpressionEditor = false;
            gridViewTextBoxColumn7.FieldName = "MAC_ADDRESS";
            gridViewTextBoxColumn7.HeaderText = "MAC ADDRESS";
            gridViewTextBoxColumn7.Name = "MAC_ADDRESS";
            gridViewTextBoxColumn7.ReadOnly = true;
            gridViewTextBoxColumn7.Width = 265;
            gridViewTextBoxColumn8.EnableExpressionEditor = false;
            gridViewTextBoxColumn8.FieldName = "USAGE";
            gridViewTextBoxColumn8.HeaderText = "USAGE";
            gridViewTextBoxColumn8.Name = "USAGE";
            gridViewTextBoxColumn8.ReadOnly = true;
            gridViewTextBoxColumn8.Width = 265;
            gridViewTextBoxColumn9.EnableExpressionEditor = false;
            gridViewTextBoxColumn9.FieldName = "PHYSICAL_RAM_MEMORY";
            gridViewTextBoxColumn9.HeaderText = "PHYSICAL MEMORY";
            gridViewTextBoxColumn9.Name = "PHYSICAL_RAM_MEMORY";
            gridViewTextBoxColumn9.ReadOnly = true;
            gridViewTextBoxColumn9.Width = 265;
            gridViewTextBoxColumn10.EnableExpressionEditor = false;
            gridViewTextBoxColumn10.FieldName = "COMPUTER_NAME";
            gridViewTextBoxColumn10.HeaderText = "COMPUTER NAME";
            gridViewTextBoxColumn10.Name = "COMPUTER_NAME";
            gridViewTextBoxColumn10.ReadOnly = true;
            gridViewTextBoxColumn10.Width = 264;
            this.gdvMemoryUsage.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8,
            gridViewTextBoxColumn9,
            gridViewTextBoxColumn10});
            this.gdvMemoryUsage.MasterTemplate.EnablePaging = true;
            this.gdvMemoryUsage.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.gdvMemoryUsage.Name = "gdvMemoryUsage";
            this.gdvMemoryUsage.ReadOnly = true;
            this.gdvMemoryUsage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gdvMemoryUsage.Size = new System.Drawing.Size(1356, 741);
            this.gdvMemoryUsage.TabIndex = 0;
            this.gdvMemoryUsage.ThemeName = "Crystal";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // DashboardMemoryUsage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 741);
            this.Controls.Add(this.radPanel1);
            this.Name = "DashboardMemoryUsage";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Memory Usage";
            this.ThemeName = "Crystal";
            this.Load += new System.EventHandler(this.DashboardMemoryUsage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdvMemoryUsage.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvMemoryUsage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.Themes.CrystalTheme crystalTheme1;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadGridView gdvMemoryUsage;
        private System.Windows.Forms.Timer timer1;
    }
}
