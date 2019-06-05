namespace PPE___Gestion_de_formations
{
    partial class FormAjouterParticipant
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
            this.tb_nom = new System.Windows.Forms.TextBox();
            this.tb_prenom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_ville = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_adresse = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_mobile = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_codepostal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_ajout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom :";
            // 
            // tb_nom
            // 
            this.tb_nom.Location = new System.Drawing.Point(63, 20);
            this.tb_nom.Name = "tb_nom";
            this.tb_nom.Size = new System.Drawing.Size(171, 20);
            this.tb_nom.TabIndex = 1;
            // 
            // tb_prenom
            // 
            this.tb_prenom.Location = new System.Drawing.Point(77, 59);
            this.tb_prenom.Name = "tb_prenom";
            this.tb_prenom.Size = new System.Drawing.Size(171, 20);
            this.tb_prenom.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prénom : ";
            // 
            // tb_ville
            // 
            this.tb_ville.Location = new System.Drawing.Point(63, 145);
            this.tb_ville.Name = "tb_ville";
            this.tb_ville.Size = new System.Drawing.Size(171, 20);
            this.tb_ville.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ville : ";
            // 
            // tb_adresse
            // 
            this.tb_adresse.Location = new System.Drawing.Point(80, 103);
            this.tb_adresse.Name = "tb_adresse";
            this.tb_adresse.Size = new System.Drawing.Size(171, 20);
            this.tb_adresse.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Adresse : ";
            // 
            // tb_mobile
            // 
            this.tb_mobile.Location = new System.Drawing.Point(75, 275);
            this.tb_mobile.Name = "tb_mobile";
            this.tb_mobile.Size = new System.Drawing.Size(171, 20);
            this.tb_mobile.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Mobile : ";
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(66, 233);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(171, 20);
            this.tb_email.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Email :";
            // 
            // tb_codepostal
            // 
            this.tb_codepostal.Location = new System.Drawing.Point(100, 189);
            this.tb_codepostal.Name = "tb_codepostal";
            this.tb_codepostal.Size = new System.Drawing.Size(171, 20);
            this.tb_codepostal.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Code postal : ";
            // 
            // btn_ajout
            // 
            this.btn_ajout.Location = new System.Drawing.Point(75, 334);
            this.btn_ajout.Name = "btn_ajout";
            this.btn_ajout.Size = new System.Drawing.Size(155, 33);
            this.btn_ajout.TabIndex = 14;
            this.btn_ajout.Text = "Ajouter le participant";
            this.btn_ajout.UseVisualStyleBackColor = true;
            this.btn_ajout.Click += new System.EventHandler(this.btn_ajout_Click);
            // 
            // FormAjouterParticipant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 414);
            this.Controls.Add(this.btn_ajout);
            this.Controls.Add(this.tb_mobile);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_codepostal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_ville);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_adresse);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_prenom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_nom);
            this.Controls.Add(this.label1);
            this.Name = "FormAjouterParticipant";
            this.Text = "Ajouter un participant";
            this.Load += new System.EventHandler(this.FormAjouterParticipant_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_nom;
        private System.Windows.Forms.TextBox tb_prenom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_ville;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_adresse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_mobile;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_codepostal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_ajout;
    }
}