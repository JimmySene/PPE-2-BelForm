namespace PPE___Gestion_de_formations
{
    partial class FormIncident
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
            this.lbl_statut = new System.Windows.Forms.Label();
            this.cb_statut = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_statut
            // 
            this.lbl_statut.AutoSize = true;
            this.lbl_statut.Location = new System.Drawing.Point(27, 30);
            this.lbl_statut.Name = "lbl_statut";
            this.lbl_statut.Size = new System.Drawing.Size(44, 13);
            this.lbl_statut.TabIndex = 2;
            this.lbl_statut.Text = "Statut : ";
            // 
            // cb_statut
            // 
            this.cb_statut.FormattingEnabled = true;
            this.cb_statut.Location = new System.Drawing.Point(77, 27);
            this.cb_statut.Name = "cb_statut";
            this.cb_statut.Size = new System.Drawing.Size(121, 21);
            this.cb_statut.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(77, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Valider";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormIncident
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 120);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cb_statut);
            this.Controls.Add(this.lbl_statut);
            this.Name = "FormIncident";
            this.Text = "Incident";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_statut;
        private System.Windows.Forms.ComboBox cb_statut;
        private System.Windows.Forms.Button button1;
    }
}