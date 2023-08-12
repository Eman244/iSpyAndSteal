﻿namespace iSpyPortal.Dashboards
{
    partial class DashboardBrowser
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.crystalTheme1 = new Telerik.WinControls.Themes.CrystalTheme();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.gdvActiveWindows = new Telerik.WinControls.UI.RadGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvActiveWindows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvActiveWindows.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.gdvActiveWindows);
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPanel1.Location = new System.Drawing.Point(0, 0);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(1356, 736);
            this.radPanel1.TabIndex = 0;
            // 
            // gdvActiveWindows
            // 
            this.gdvActiveWindows.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.gdvActiveWindows.Cursor = System.Windows.Forms.Cursors.Default;
            this.gdvActiveWindows.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdvActiveWindows.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.gdvActiveWindows.ForeColor = System.Drawing.Color.Black;
            this.gdvActiveWindows.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gdvActiveWindows.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.gdvActiveWindows.MasterTemplate.AllowAddNewRow = false;
            this.gdvActiveWindows.MasterTemplate.AllowColumnReorder = false;
            this.gdvActiveWindows.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "Brower";
            gridViewTextBoxColumn1.HeaderText = "BROWSER";
            gridViewTextBoxColumn1.Name = "Brower";
            gridViewTextBoxColumn1.ReadOnly = true;
            gridViewTextBoxColumn1.Width = 189;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "TITLE";
            gridViewTextBoxColumn2.HeaderText = "TITLE";
            gridViewTextBoxColumn2.Name = "TITLE";
            gridViewTextBoxColumn2.ReadOnly = true;
            gridViewTextBoxColumn2.Width = 189;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "URL";
            gridViewTextBoxColumn3.HeaderText = "URL";
            gridViewTextBoxColumn3.Name = "URL";
            gridViewTextBoxColumn3.ReadOnly = true;
            gridViewTextBoxColumn3.Width = 189;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "VISIT_COUNT";
            gridViewTextBoxColumn4.HeaderText = "VISIT COUNT";
            gridViewTextBoxColumn4.Name = "VISIT_COUNT";
            gridViewTextBoxColumn4.ReadOnly = true;
            gridViewTextBoxColumn4.Width = 189;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "LAST_VISIT_DATE";
            gridViewTextBoxColumn5.HeaderText = "LAST_VISIT_DATE";
            gridViewTextBoxColumn5.Name = "LAST_VISIT_DATE";
            gridViewTextBoxColumn5.ReadOnly = true;
            gridViewTextBoxColumn5.Width = 189;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "MAC_ADDRESS";
            gridViewTextBoxColumn6.HeaderText = "MAC ADDRESS";
            gridViewTextBoxColumn6.Name = "MAC_ADDRESS";
            gridViewTextBoxColumn6.ReadOnly = true;
            gridViewTextBoxColumn6.Width = 189;
            gridViewTextBoxColumn7.EnableExpressionEditor = false;
            gridViewTextBoxColumn7.FieldName = "SYSTEM_ID";
            gridViewTextBoxColumn7.HeaderText = "SYSTEM ID";
            gridViewTextBoxColumn7.Name = "SYSTEM_ID";
            gridViewTextBoxColumn7.ReadOnly = true;
            gridViewTextBoxColumn7.Width = 190;
            this.gdvActiveWindows.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7});
            this.gdvActiveWindows.MasterTemplate.EnablePaging = true;
            this.gdvActiveWindows.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.gdvActiveWindows.Name = "gdvActiveWindows";
            this.gdvActiveWindows.ReadOnly = true;
            this.gdvActiveWindows.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gdvActiveWindows.Size = new System.Drawing.Size(1356, 736);
            this.gdvActiveWindows.TabIndex = 0;
            this.gdvActiveWindows.ThemeName = "Crystal";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // DashboardBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 736);
            this.Controls.Add(this.radPanel1);
            this.Name = "DashboardBrowser";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.RootElement.MaxSize = new System.Drawing.Size(0, 0);
            this.Text = "Browser History";
            this.ThemeName = "Crystal";
            this.Load += new System.EventHandler(this.DashboardActiveWindows_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdvActiveWindows.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvActiveWindows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.Themes.CrystalTheme crystalTheme1;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadGridView gdvActiveWindows;
        private System.Windows.Forms.Timer timer1;
    }
}
