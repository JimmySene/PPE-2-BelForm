namespace PPE___Gestion_de_formations
{
    partial class PromptForm
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
            this.lbl_prompt = new System.Windows.Forms.Label();
            this.rtb_prompt = new System.Windows.Forms.RichTextBox();
            this.btn_prompt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_prompt
            // 
            this.lbl_prompt.AutoSize = true;
            this.lbl_prompt.Location = new System.Drawing.Point(67, 34);
            this.lbl_prompt.Name = "lbl_prompt";
            this.lbl_prompt.Size = new System.Drawing.Size(0, 13);
            this.lbl_prompt.TabIndex = 0;
            // 
            // rtb_prompt
            // 
            this.rtb_prompt.Location = new System.Drawing.Point(70, 68);
            this.rtb_prompt.Name = "rtb_prompt";
            this.rtb_prompt.Size = new System.Drawing.Size(271, 96);
            this.rtb_prompt.TabIndex = 1;
            this.rtb_prompt.Text = "";
            // 
            // btn_prompt
            // 
            this.btn_prompt.Location = new System.Drawing.Point(162, 185);
            this.btn_prompt.Name = "btn_prompt";
            this.btn_prompt.Size = new System.Drawing.Size(75, 23);
            this.btn_prompt.TabIndex = 2;
            this.btn_prompt.Text = "OK";
            this.btn_prompt.UseVisualStyleBackColor = true;
            this.btn_prompt.Click += new System.EventHandler(this.btn_prompt_Click);
            // 
            // PromptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 227);
            this.Controls.Add(this.btn_prompt);
            this.Controls.Add(this.rtb_prompt);
            this.Controls.Add(this.lbl_prompt);
            this.Name = "PromptForm";
            this.Text = "PromptForm";
            this.Load += new System.EventHandler(this.PromptForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_prompt;
        private System.Windows.Forms.RichTextBox rtb_prompt;
        private System.Windows.Forms.Button btn_prompt;
    }
}