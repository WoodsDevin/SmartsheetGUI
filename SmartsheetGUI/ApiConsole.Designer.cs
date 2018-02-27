namespace SmartsheetGUI
{
    partial class ApiConsole
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
            this.btnGetApiResp = new System.Windows.Forms.Button();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.rdbGET = new System.Windows.Forms.RadioButton();
            this.rdbPOST = new System.Windows.Forms.RadioButton();
            this.rdpPUT = new System.Windows.Forms.RadioButton();
            this.rdpDELETE = new System.Windows.Forms.RadioButton();
            this.lblExampleCalls = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGetApiResp
            // 
            this.btnGetApiResp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetApiResp.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnGetApiResp.Location = new System.Drawing.Point(490, 13);
            this.btnGetApiResp.Name = "btnGetApiResp";
            this.btnGetApiResp.Size = new System.Drawing.Size(147, 24);
            this.btnGetApiResp.TabIndex = 0;
            this.btnGetApiResp.Text = "Get Response";
            this.btnGetApiResp.UseVisualStyleBackColor = false;
            this.btnGetApiResp.Click += new System.EventHandler(this.btnGetApiResp_Click);
            // 
            // txtUrl
            // 
            this.txtUrl.AllowDrop = true;
            this.txtUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUrl.Location = new System.Drawing.Point(13, 13);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(450, 20);
            this.txtUrl.TabIndex = 1;
            this.txtUrl.Text = "https://api.smartsheet.com/2.0/sheets";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 133);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(624, 326);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(414, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "(The authorization is passed through the header using the already entered access " +
    "key)";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.lblExampleCalls);
            this.panel1.Controls.Add(this.rdpDELETE);
            this.panel1.Controls.Add(this.rdpPUT);
            this.panel1.Controls.Add(this.rdbPOST);
            this.panel1.Controls.Add(this.rdbGET);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(13, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(623, 44);
            this.panel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "HTTP Method: ";
            // 
            // rdbGET
            // 
            this.rdbGET.AutoSize = true;
            this.rdbGET.Checked = true;
            this.rdbGET.Location = new System.Drawing.Point(122, 13);
            this.rdbGET.Name = "rdbGET";
            this.rdbGET.Size = new System.Drawing.Size(47, 17);
            this.rdbGET.TabIndex = 5;
            this.rdbGET.TabStop = true;
            this.rdbGET.Text = "GET";
            this.rdbGET.UseVisualStyleBackColor = true;
            // 
            // rdbPOST
            // 
            this.rdbPOST.AutoSize = true;
            this.rdbPOST.Enabled = false;
            this.rdbPOST.Location = new System.Drawing.Point(175, 13);
            this.rdbPOST.Name = "rdbPOST";
            this.rdbPOST.Size = new System.Drawing.Size(54, 17);
            this.rdbPOST.TabIndex = 6;
            this.rdbPOST.Text = "POST";
            this.rdbPOST.UseVisualStyleBackColor = true;
            // 
            // rdpPUT
            // 
            this.rdpPUT.AutoSize = true;
            this.rdpPUT.Enabled = false;
            this.rdpPUT.Location = new System.Drawing.Point(235, 13);
            this.rdpPUT.Name = "rdpPUT";
            this.rdpPUT.Size = new System.Drawing.Size(47, 17);
            this.rdpPUT.TabIndex = 7;
            this.rdpPUT.Text = "PUT";
            this.rdpPUT.UseVisualStyleBackColor = true;
            // 
            // rdpDELETE
            // 
            this.rdpDELETE.AutoSize = true;
            this.rdpDELETE.Enabled = false;
            this.rdpDELETE.Location = new System.Drawing.Point(288, 13);
            this.rdpDELETE.Name = "rdpDELETE";
            this.rdpDELETE.Size = new System.Drawing.Size(67, 17);
            this.rdpDELETE.TabIndex = 8;
            this.rdpDELETE.Text = "DELETE";
            this.rdpDELETE.UseVisualStyleBackColor = true;
            // 
            // lblExampleCalls
            // 
            this.lblExampleCalls.AutoSize = true;
            this.lblExampleCalls.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblExampleCalls.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExampleCalls.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblExampleCalls.Location = new System.Drawing.Point(500, 15);
            this.lblExampleCalls.Name = "lblExampleCalls";
            this.lblExampleCalls.Size = new System.Drawing.Size(109, 13);
            this.lblExampleCalls.TabIndex = 9;
            this.lblExampleCalls.Text = "Insert an example call";
            this.lblExampleCalls.Click += new System.EventHandler(this.lblExampleCalls_Click);
            // 
            // ApiConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(651, 471);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.btnGetApiResp);
            this.Name = "ApiConsole";
            this.Text = "API Console";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetApiResp;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdpDELETE;
        private System.Windows.Forms.RadioButton rdpPUT;
        private System.Windows.Forms.RadioButton rdbPOST;
        private System.Windows.Forms.RadioButton rdbGET;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblExampleCalls;
    }
}