namespace SmartsheetGUI
{
    partial class ClientForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboSheets = new System.Windows.Forms.ComboBox();
            this.pnlSheetInfo = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPermalink = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtModified = new System.Windows.Forms.TextBox();
            this.txtRowCount = new System.Windows.Forms.TextBox();
            this.txtSheetID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCreated = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSheetName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkUniqueColumns = new System.Windows.Forms.CheckBox();
            this.lstSheetView = new System.Windows.Forms.ListView();
            this.label9 = new System.Windows.Forms.Label();
            this.lblCurrentUser = new System.Windows.Forms.Label();
            this.btnMakeNewSheet = new System.Windows.Forms.Button();
            this.btnOpenApiConsole = new System.Windows.Forms.Button();
            this.pnlSheetInfo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Available Sheets:";
            // 
            // cboSheets
            // 
            this.cboSheets.FormattingEnabled = true;
            this.cboSheets.Location = new System.Drawing.Point(107, 22);
            this.cboSheets.Name = "cboSheets";
            this.cboSheets.Size = new System.Drawing.Size(121, 21);
            this.cboSheets.TabIndex = 1;
            this.cboSheets.SelectedIndexChanged += new System.EventHandler(this.cboSheets_SelectedIndexChanged);
            // 
            // pnlSheetInfo
            // 
            this.pnlSheetInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlSheetInfo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pnlSheetInfo.Controls.Add(this.label8);
            this.pnlSheetInfo.Controls.Add(this.txtPermalink);
            this.pnlSheetInfo.Controls.Add(this.label7);
            this.pnlSheetInfo.Controls.Add(this.label6);
            this.pnlSheetInfo.Controls.Add(this.txtModified);
            this.pnlSheetInfo.Controls.Add(this.txtRowCount);
            this.pnlSheetInfo.Controls.Add(this.txtSheetID);
            this.pnlSheetInfo.Controls.Add(this.label5);
            this.pnlSheetInfo.Controls.Add(this.txtCreated);
            this.pnlSheetInfo.Controls.Add(this.label3);
            this.pnlSheetInfo.Controls.Add(this.txtSheetName);
            this.pnlSheetInfo.Controls.Add(this.label2);
            this.pnlSheetInfo.Location = new System.Drawing.Point(12, 58);
            this.pnlSheetInfo.Name = "pnlSheetInfo";
            this.pnlSheetInfo.Size = new System.Drawing.Size(281, 342);
            this.pnlSheetInfo.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Permalink:";
            // 
            // txtPermalink
            // 
            this.txtPermalink.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtPermalink.Location = new System.Drawing.Point(95, 154);
            this.txtPermalink.Multiline = true;
            this.txtPermalink.Name = "txtPermalink";
            this.txtPermalink.ReadOnly = true;
            this.txtPermalink.Size = new System.Drawing.Size(146, 110);
            this.txtPermalink.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Total Rows:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Last Modified:";
            // 
            // txtModified
            // 
            this.txtModified.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtModified.Location = new System.Drawing.Point(95, 98);
            this.txtModified.Name = "txtModified";
            this.txtModified.ReadOnly = true;
            this.txtModified.Size = new System.Drawing.Size(146, 20);
            this.txtModified.TabIndex = 9;
            // 
            // txtRowCount
            // 
            this.txtRowCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtRowCount.Location = new System.Drawing.Point(95, 124);
            this.txtRowCount.Name = "txtRowCount";
            this.txtRowCount.ReadOnly = true;
            this.txtRowCount.Size = new System.Drawing.Size(146, 20);
            this.txtRowCount.TabIndex = 8;
            // 
            // txtSheetID
            // 
            this.txtSheetID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSheetID.Location = new System.Drawing.Point(95, 46);
            this.txtSheetID.Name = "txtSheetID";
            this.txtSheetID.ReadOnly = true;
            this.txtSheetID.Size = new System.Drawing.Size(146, 20);
            this.txtSheetID.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Sheet ID:";
            // 
            // txtCreated
            // 
            this.txtCreated.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCreated.Location = new System.Drawing.Point(95, 72);
            this.txtCreated.Name = "txtCreated";
            this.txtCreated.ReadOnly = true;
            this.txtCreated.Size = new System.Drawing.Size(146, 20);
            this.txtCreated.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Created:";
            // 
            // txtSheetName
            // 
            this.txtSheetName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSheetName.Location = new System.Drawing.Point(95, 20);
            this.txtSheetName.Name = "txtSheetName";
            this.txtSheetName.ReadOnly = true;
            this.txtSheetName.Size = new System.Drawing.Size(146, 20);
            this.txtSheetName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.chkUniqueColumns);
            this.panel1.Controls.Add(this.lstSheetView);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(299, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(477, 342);
            this.panel1.TabIndex = 3;
            // 
            // chkUniqueColumns
            // 
            this.chkUniqueColumns.AutoSize = true;
            this.chkUniqueColumns.Checked = true;
            this.chkUniqueColumns.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUniqueColumns.Location = new System.Drawing.Point(77, 19);
            this.chkUniqueColumns.Name = "chkUniqueColumns";
            this.chkUniqueColumns.Size = new System.Drawing.Size(157, 17);
            this.chkUniqueColumns.TabIndex = 16;
            this.chkUniqueColumns.Text = "Show Only Unique Columns";
            this.chkUniqueColumns.UseVisualStyleBackColor = true;
            this.chkUniqueColumns.CheckedChanged += new System.EventHandler(this.chkUniqueColumns_CheckedChanged);
            // 
            // lstSheetView
            // 
            this.lstSheetView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstSheetView.Location = new System.Drawing.Point(14, 42);
            this.lstSheetView.Name = "lstSheetView";
            this.lstSheetView.Size = new System.Drawing.Size(443, 281);
            this.lstSheetView.TabIndex = 0;
            this.lstSheetView.UseCompatibleStateImageBehavior = false;
            this.lstSheetView.View = System.Windows.Forms.View.Details;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Columns:";
            // 
            // lblCurrentUser
            // 
            this.lblCurrentUser.AutoSize = true;
            this.lblCurrentUser.Location = new System.Drawing.Point(254, 25);
            this.lblCurrentUser.Name = "lblCurrentUser";
            this.lblCurrentUser.Size = new System.Drawing.Size(39, 13);
            this.lblCurrentUser.TabIndex = 4;
            this.lblCurrentUser.Text = "(Login)";
            // 
            // btnMakeNewSheet
            // 
            this.btnMakeNewSheet.Location = new System.Drawing.Point(551, 20);
            this.btnMakeNewSheet.Name = "btnMakeNewSheet";
            this.btnMakeNewSheet.Size = new System.Drawing.Size(100, 23);
            this.btnMakeNewSheet.TabIndex = 5;
            this.btnMakeNewSheet.Text = "New Sheet";
            this.btnMakeNewSheet.UseVisualStyleBackColor = true;
            this.btnMakeNewSheet.Click += new System.EventHandler(this.btnMakeNewSheet_Click);
            // 
            // btnOpenApiConsole
            // 
            this.btnOpenApiConsole.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenApiConsole.Location = new System.Drawing.Point(657, 20);
            this.btnOpenApiConsole.Name = "btnOpenApiConsole";
            this.btnOpenApiConsole.Size = new System.Drawing.Size(119, 23);
            this.btnOpenApiConsole.TabIndex = 6;
            this.btnOpenApiConsole.Text = "Open API Console";
            this.btnOpenApiConsole.UseVisualStyleBackColor = true;
            this.btnOpenApiConsole.Click += new System.EventHandler(this.btnOpenApiConsole_Click);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(799, 412);
            this.Controls.Add(this.btnOpenApiConsole);
            this.Controls.Add(this.btnMakeNewSheet);
            this.Controls.Add(this.lblCurrentUser);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlSheetInfo);
            this.Controls.Add(this.cboSheets);
            this.Controls.Add(this.label1);
            this.Name = "ClientForm";
            this.Text = "SmartSheet";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ClientForm_FormClosed);
            this.Load += new System.EventHandler(this.ClientForm_Load);
            this.pnlSheetInfo.ResumeLayout(false);
            this.pnlSheetInfo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboSheets;
        private System.Windows.Forms.Panel pnlSheetInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSheetName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCreated;
        private System.Windows.Forms.TextBox txtSheetID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtModified;
        private System.Windows.Forms.TextBox txtRowCount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPermalink;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chkUniqueColumns;
        private System.Windows.Forms.ListView lstSheetView;
        private System.Windows.Forms.Label lblCurrentUser;
        private System.Windows.Forms.Button btnMakeNewSheet;
        private System.Windows.Forms.Button btnOpenApiConsole;
    }
}