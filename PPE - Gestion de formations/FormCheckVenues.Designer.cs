namespace PPE___Gestion_de_formations
{
    partial class FormCheckVenues
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
            this.btn_signature = new System.Windows.Forms.Button();
            this.dg_signature = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dg_signature)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Signature des inscrits :";
            // 
            // btn_signature
            // 
            this.btn_signature.Location = new System.Drawing.Point(113, 209);
            this.btn_signature.Name = "btn_signature";
            this.btn_signature.Size = new System.Drawing.Size(124, 33);
            this.btn_signature.TabIndex = 2;
            this.btn_signature.Text = "Valider";
            this.btn_signature.UseVisualStyleBackColor = true;
            this.btn_signature.Click += new System.EventHandler(this.btn_signature_Click);
            // 
            // dg_signature
            // 
            this.dg_signature.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_signature.Location = new System.Drawing.Point(18, 38);
            this.dg_signature.Name = "dg_signature";
            this.dg_signature.Size = new System.Drawing.Size(337, 150);
            this.dg_signature.TabIndex = 3;
            // 
            // FormCheckVenues
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 256);
            this.Controls.Add(this.dg_signature);
            this.Controls.Add(this.btn_signature);
            this.Controls.Add(this.label1);
            this.Name = "FormCheckVenues";
            this.Text = "Confirmation des présences";
            ((System.ComponentModel.ISupportInitialize)(this.dg_signature)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_signature;
        private System.Windows.Forms.DataGridView dg_signature;
    }
}