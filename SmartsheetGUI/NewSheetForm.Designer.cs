namespace SmartsheetGUI
{
    partial class NewSheetForm
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
            this.btnCreateSheet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customization coming soon.";
            // 
            // btnCreateSheet
            // 
            this.btnCreateSheet.Location = new System.Drawing.Point(141, 98);
            this.btnCreateSheet.Name = "btnCreateSheet";
            this.btnCreateSheet.Size = new System.Drawing.Size(113, 23);
            this.btnCreateSheet.TabIndex = 1;
            this.btnCreateSheet.Text = "Create New Sheet";
            this.btnCreateSheet.UseVisualStyleBackColor = true;
            this.btnCreateSheet.Click += new System.EventHandler(this.btnCreateSheet_Click);
            // 
            // NewSheetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 296);
            this.Controls.Add(this.btnCreateSheet);
            this.Controls.Add(this.label1);
            this.Name = "NewSheetForm";
            this.Text = "NewSheet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreateSheet;
    }
}