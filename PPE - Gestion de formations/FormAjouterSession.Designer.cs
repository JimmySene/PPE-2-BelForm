namespace PPE___Gestion_de_formations
{
    partial class FormAjouterSession
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
            this.label2 = new System.Windows.Forms.Label();
            this.cb_lieux = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dt_debut = new System.Windows.Forms.DateTimePicker();
            this.dt_fin = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Date et heure de commencement : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Date et heure de fin : ";
            // 
            // cb_lieux
            // 
            this.cb_lieux.FormattingEnabled = true;
            this.cb_lieux.Location = new System.Drawing.Point(30, 217);
            this.cb_lieux.Name = "cb_lieux";
            this.cb_lieux.Size = new System.Drawing.Size(198, 21);
            this.cb_lieux.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Lieu de déroulement :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(60, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Ajouter la session";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dt_debut
            // 
            this.dt_debut.CustomFormat = "dd/MM/yyyy à HH:mm";
            this.dt_debut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_debut.Location = new System.Drawing.Point(28, 62);
            this.dt_debut.MinDate = new System.DateTime(2019, 4, 22, 0, 0, 0, 0);
            this.dt_debut.Name = "dt_debut";
            this.dt_debut.ShowUpDown = true;
            this.dt_debut.Size = new System.Drawing.Size(200, 20);
            this.dt_debut.TabIndex = 8;
            this.dt_debut.Value = new System.DateTime(2019, 4, 22, 18, 36, 43, 0);
            // 
            // dt_fin
            // 
            this.dt_fin.CustomFormat = "dd/MM/yyyy à HH:mm";
            this.dt_fin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_fin.Location = new System.Drawing.Point(28, 145);
            this.dt_fin.MinDate = new System.DateTime(2019, 4, 22, 0, 0, 0, 0);
            this.dt_fin.Name = "dt_fin";
            this.dt_fin.ShowUpDown = true;
            this.dt_fin.Size = new System.Drawing.Size(200, 20);
            this.dt_fin.TabIndex = 9;
            this.dt_fin.Value = new System.DateTime(2019, 4, 22, 18, 45, 15, 0);
            // 
            // FormAjouterSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 313);
            this.Controls.Add(this.dt_fin);
            this.Controls.Add(this.dt_debut);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_lieux);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAjouterSession";
            this.Text = "Ajouter une session";
            this.Load += new System.EventHandler(this.FormAjouterSession_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_lieux;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dt_debut;
        private System.Windows.Forms.DateTimePicker dt_fin;
    }
}