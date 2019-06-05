namespace PPE___Gestion_de_formations
{
    partial class FormMotifRefus
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
            this.tb_motif = new System.Windows.Forms.TextBox();
            this.btn_motif = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Entrez un motif de refus :";
            // 
            // tb_motif
            // 
            this.tb_motif.Location = new System.Drawing.Point(34, 55);
            this.tb_motif.Multiline = true;
            this.tb_motif.Name = "tb_motif";
            this.tb_motif.Size = new System.Drawing.Size(247, 68);
            this.tb_motif.TabIndex = 1;
            // 
            // btn_motif
            // 
            this.btn_motif.Location = new System.Drawing.Point(85, 156);
            this.btn_motif.Name = "btn_motif";
            this.btn_motif.Size = new System.Drawing.Size(142, 37);
            this.btn_motif.TabIndex = 2;
            this.btn_motif.Text = "Refuser le candidat";
            this.btn_motif.UseVisualStyleBackColor = true;
            this.btn_motif.Click += new System.EventHandler(this.btn_motif_Click);
            // 
            // FormMotifRefus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 230);
            this.Controls.Add(this.btn_motif);
            this.Controls.Add(this.tb_motif);
            this.Controls.Add(this.label1);
            this.Name = "FormMotifRefus";
            this.Text = "FormMotifRefus";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_motif;
        private System.Windows.Forms.Button btn_motif;
    }
}