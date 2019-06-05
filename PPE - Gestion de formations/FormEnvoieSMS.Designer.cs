namespace PPE___Gestion_de_formations
{
    partial class FormEnvoieSMS
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
            this.rtb_sms = new System.Windows.Forms.RichTextBox();
            this.lbl_sms = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtb_sms
            // 
            this.rtb_sms.Location = new System.Drawing.Point(31, 56);
            this.rtb_sms.Name = "rtb_sms";
            this.rtb_sms.Size = new System.Drawing.Size(238, 228);
            this.rtb_sms.TabIndex = 0;
            this.rtb_sms.Text = "";
            // 
            // lbl_sms
            // 
            this.lbl_sms.AutoSize = true;
            this.lbl_sms.Location = new System.Drawing.Point(28, 30);
            this.lbl_sms.Name = "lbl_sms";
            this.lbl_sms.Size = new System.Drawing.Size(114, 13);
            this.lbl_sms.TabIndex = 1;
            this.lbl_sms.Text = "SMS de confirmation : ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(59, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 44);
            this.button1.TabIndex = 2;
            this.button1.Text = "Envoyer le SMS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormEnvoieSMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 374);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_sms);
            this.Controls.Add(this.rtb_sms);
            this.Name = "FormEnvoieSMS";
            this.Text = "Envoie du SMS de confirmation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_sms;
        private System.Windows.Forms.Label lbl_sms;
        private System.Windows.Forms.Button button1;
    }
}