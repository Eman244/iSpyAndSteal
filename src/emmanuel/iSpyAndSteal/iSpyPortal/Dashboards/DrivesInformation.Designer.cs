﻿namespace iSpyPortal.Dashboards
{
    partial class DrivesInformation
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DrivesInformation));
            this.crystalTheme1 = new Telerik.WinControls.Themes.CrystalTheme();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.gdvDriveInfo = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvDriveInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvDriveInfo.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.radGroupBox1);
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPanel1.Location = new System.Drawing.Point(0, 0);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(1327, 729);
            this.radPanel1.TabIndex = 0;
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.gdvDriveInfo);
            this.radGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGroupBox1.HeaderMargin = new System.Windows.Forms.Padding(1);
            this.radGroupBox1.HeaderText = "";
            this.radGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(1327, 729);
            this.radGroupBox1.TabIndex = 0;
            this.radGroupBox1.ThemeName = "Crystal";
            // 
            // gdvDriveInfo
            // 
            this.gdvDriveInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.gdvDriveInfo.Cursor = System.Windows.Forms.Cursors.Default;
            this.gdvDriveInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdvDriveInfo.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.gdvDriveInfo.ForeColor = System.Drawing.Color.Black;
            this.gdvDriveInfo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gdvDriveInfo.Location = new System.Drawing.Point(2, 18);
            // 
            // 
            // 
            this.gdvDriveInfo.MasterTemplate.AllowAddNewRow = false;
            this.gdvDriveInfo.MasterTemplate.AllowColumnReorder = false;
            this.gdvDriveInfo.MasterTemplate.AllowColumnResize = false;
            this.gdvDriveInfo.MasterTemplate.AllowDragToGroup = false;
            this.gdvDriveInfo.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "Name";
            gridViewTextBoxColumn1.HeaderText = "Caption";
            gridViewTextBoxColumn1.Name = "Caption";
            gridViewTextBoxColumn1.Width = 258;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "SerialNo";
            gridViewTextBoxColumn2.HeaderText = "Serial";
            gridViewTextBoxColumn2.Name = "Serial";
            gridViewTextBoxColumn2.Width = 258;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "TotalSize";
            gridViewTextBoxColumn3.HeaderText = "Total (GB)";
            gridViewTextBoxColumn3.Name = "Total";
            gridViewTextBoxColumn3.Width = 258;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "TotalFreeSpace";
            gridViewTextBoxColumn4.HeaderText = "Free (GB)";
            gridViewTextBoxColumn4.Name = "Free";
            gridViewTextBoxColumn4.Width = 258;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "UsedSpace";
            gridViewTextBoxColumn5.HeaderText = "Used (GB)";
            gridViewTextBoxColumn5.Name = "Used";
            gridViewTextBoxColumn5.Width = 259;
            this.gdvDriveInfo.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5});
            this.gdvDriveInfo.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.gdvDriveInfo.Name = "gdvDriveInfo";
            this.gdvDriveInfo.ReadOnly = true;
            this.gdvDriveInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gdvDriveInfo.Size = new System.Drawing.Size(1323, 709);
            this.gdvDriveInfo.TabIndex = 0;
            this.gdvDriveInfo.ThemeName = "Crystal";
            // 
            // DrivesInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 729);
            this.Controls.Add(this.radPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DrivesInformation";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Running Fox Technologies";
            this.ThemeName = "Crystal";
            this.Load += new System.EventHandler(this.DrivesInformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdvDriveInfo.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvDriveInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.Themes.CrystalTheme crystalTheme1;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadGridView gdvDriveInfo;
    }
}
