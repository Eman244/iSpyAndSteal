namespace iSpyPortal.Dashboards
{
    partial class DashboardCpuUsage
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.crystalTheme1 = new Telerik.WinControls.Themes.CrystalTheme();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.gdvCpuUsage = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvCpuUsage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvCpuUsage.MasterTemplate)).BeginInit();
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
            this.radPanel1.Controls.Add(this.gdvCpuUsage);
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPanel1.Location = new System.Drawing.Point(0, 0);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(1356, 736);
            this.radPanel1.TabIndex = 0;
            // 
            // gdvCpuUsage
            // 
            this.gdvCpuUsage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.gdvCpuUsage.Cursor = System.Windows.Forms.Cursors.Default;
            this.gdvCpuUsage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdvCpuUsage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.gdvCpuUsage.ForeColor = System.Drawing.Color.Black;
            this.gdvCpuUsage.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gdvCpuUsage.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.gdvCpuUsage.MasterTemplate.AllowAddNewRow = false;
            this.gdvCpuUsage.MasterTemplate.AllowColumnReorder = false;
            this.gdvCpuUsage.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "ID";
            gridViewTextBoxColumn1.HeaderText = "ID";
            gridViewTextBoxColumn1.Name = "ID";
            gridViewTextBoxColumn1.ReadOnly = true;
            gridViewTextBoxColumn1.Width = 264;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "MAC_ADDRESS";
            gridViewTextBoxColumn2.HeaderText = "MAC ADDRESS";
            gridViewTextBoxColumn2.Name = "MAC_ADDRESS";
            gridViewTextBoxColumn2.ReadOnly = true;
            gridViewTextBoxColumn2.Width = 264;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "USAGE";
            gridViewTextBoxColumn3.HeaderText = "USAGE";
            gridViewTextBoxColumn3.Name = "USAGE";
            gridViewTextBoxColumn3.ReadOnly = true;
            gridViewTextBoxColumn3.Width = 264;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "CPU_SPEED_IN_GHZ";
            gridViewTextBoxColumn4.HeaderText = "CPU SPEED (Ghz)";
            gridViewTextBoxColumn4.Name = "CPU_SPEED_IN_GHZ";
            gridViewTextBoxColumn4.ReadOnly = true;
            gridViewTextBoxColumn4.Width = 264;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "COMPUTER_NAME";
            gridViewTextBoxColumn5.HeaderText = "COMPUTER_NAME";
            gridViewTextBoxColumn5.Name = "COMPUTER NAME";
            gridViewTextBoxColumn5.ReadOnly = true;
            gridViewTextBoxColumn5.Width = 268;
            this.gdvCpuUsage.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5});
            this.gdvCpuUsage.MasterTemplate.EnablePaging = true;
            this.gdvCpuUsage.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.gdvCpuUsage.Name = "gdvCpuUsage";
            this.gdvCpuUsage.ReadOnly = true;
            this.gdvCpuUsage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gdvCpuUsage.Size = new System.Drawing.Size(1356, 736);
            this.gdvCpuUsage.TabIndex = 0;
            this.gdvCpuUsage.ThemeName = "Crystal";
            // 
            // DashboardCpuUsage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 736);
            this.Controls.Add(this.radPanel1);
            this.MaximumSize = new System.Drawing.Size(1364, 771);
            this.Name = "DashboardCpuUsage";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.RootElement.MaxSize = new System.Drawing.Size(1364, 771);
            this.Text = "Processor Usage";
            this.ThemeName = "Crystal";
            this.Load += new System.EventHandler(this.DashboardCpuUsage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdvCpuUsage.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvCpuUsage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.Themes.CrystalTheme crystalTheme1;
        private System.Windows.Forms.Timer timer1;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadGridView gdvCpuUsage;
    }
}
