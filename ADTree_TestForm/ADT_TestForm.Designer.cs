﻿using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace ADTree_TestForm
{
    public partial class AdtTestForm : DockContent
    {
        #region  Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.btnImport = new Button();
            this.txtDomain = new TextBox();
            this.lblDomain = new Label();
            this.btnChangeDomain = new Button();
            this.ActiveDirectoryTree = new ADTree.ADtree();
            this.btnClose = new Button();
            this.chkSubOU = new CheckBox();
            this.SuspendLayout();
            // 
            // btnImport
            // 
            this.btnImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnImport.Location = new System.Drawing.Point(126, 345);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 23);
            this.btnImport.TabIndex = 4;
            this.btnImport.Text = "&Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.BtnImport_Click);
            // 
            // txtDomain
            // 
            this.txtDomain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDomain.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDomain.Location = new System.Drawing.Point(12, 25);
            this.txtDomain.Name = "txtDomain";
            this.txtDomain.Size = new System.Drawing.Size(406, 22);
            this.txtDomain.TabIndex = 1;
            this.txtDomain.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtDomain_KeyDown);
            // 
            // lblDomain
            // 
            this.lblDomain.AutoSize = true;
            this.lblDomain.Location = new System.Drawing.Point(9, 9);
            this.lblDomain.Name = "lblDomain";
            this.lblDomain.Size = new System.Drawing.Size(50, 13);
            this.lblDomain.TabIndex = 0;
            this.lblDomain.Text = "Domain:";
            // 
            // btnChangeDomain
            // 
            this.btnChangeDomain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChangeDomain.Location = new System.Drawing.Point(422, 23);
            this.btnChangeDomain.Name = "btnChangeDomain";
            this.btnChangeDomain.Size = new System.Drawing.Size(100, 24);
            this.btnChangeDomain.TabIndex = 2;
            this.btnChangeDomain.Text = "Change";
            this.btnChangeDomain.UseVisualStyleBackColor = true;
            this.btnChangeDomain.Click += new System.EventHandler(this.BtnChangeDomain_Click);
            // 
            // ActiveDirectoryTree
            // 
            this.ActiveDirectoryTree.AdPath = null;
            this.ActiveDirectoryTree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ActiveDirectoryTree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ActiveDirectoryTree.Domain = "";
            this.ActiveDirectoryTree.Location = new System.Drawing.Point(12, 52);
            this.ActiveDirectoryTree.Margin = new System.Windows.Forms.Padding(4);
            this.ActiveDirectoryTree.Name = "ActiveDirectoryTree";
            this.ActiveDirectoryTree.SelectedNode = null;
            this.ActiveDirectoryTree.Size = new System.Drawing.Size(510, 285);
            this.ActiveDirectoryTree.TabIndex = 3;
            this.ActiveDirectoryTree.AdPathChanged += new ADTree.ADtree.AdPathChangedEventHandler(this.ActiveDirectoryTree_ADPathChanged);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(422, 344);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 24);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // chkSubOU
            // 
            this.chkSubOU.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkSubOU.AutoSize = true;
            this.chkSubOU.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSubOU.Location = new System.Drawing.Point(12, 349);
            this.chkSubOU.Name = "chkSubOU";
            this.chkSubOU.Size = new System.Drawing.Size(108, 17);
            this.chkSubOU.TabIndex = 6;
            this.chkSubOU.Text = "Import Sub OUs";
            this.chkSubOU.UseVisualStyleBackColor = true;
            // 
            // ActiveDirectoryImportWindow
            // 
            this.AcceptButton = this.btnImport;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(534, 381);
            this.Controls.Add(this.chkSubOU);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ActiveDirectoryTree);
            this.Controls.Add(this.lblDomain);
            this.Controls.Add(this.txtDomain);
            this.Controls.Add(this.btnChangeDomain);
            this.Controls.Add(this.btnImport);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ActiveDirectoryImportWindow";
            this.TabText = "Active Directory Import";
            this.Text = "Active Directory Import";
            this.Load += new System.EventHandler(this.ADImport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private Button btnImport;
        private TextBox txtDomain;
        private Label lblDomain;
        private Button btnChangeDomain;
        private ADTree.ADtree ActiveDirectoryTree;
        #endregion

        private Button btnClose;
        private CheckBox chkSubOU;
    }
}