namespace PPE___Gestion_de_formations
{
    partial class ConnexionForm
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
            this.lbl_login = new System.Windows.Forms.Label();
            this.lbl_mdp = new System.Windows.Forms.Label();
            this.tb_login = new System.Windows.Forms.TextBox();
            this.tb_mdp = new System.Windows.Forms.TextBox();
            this.btn_connexion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.Location = new System.Drawing.Point(36, 24);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(42, 13);
            this.lbl_login.TabIndex = 0;
            this.lbl_login.Text = "Login : ";
            // 
            // lbl_mdp
            // 
            this.lbl_mdp.AutoSize = true;
            this.lbl_mdp.Location = new System.Drawing.Point(36, 57);
            this.lbl_mdp.Name = "lbl_mdp";
            this.lbl_mdp.Size = new System.Drawing.Size(80, 13);
            this.lbl_mdp.TabIndex = 1;
            this.lbl_mdp.Text = "Mot de passe : ";
            // 
            // tb_login
            // 
            this.tb_login.Location = new System.Drawing.Point(84, 21);
            this.tb_login.Name = "tb_login";
            this.tb_login.Size = new System.Drawing.Size(100, 20);
            this.tb_login.TabIndex = 2;
            // 
            // tb_mdp
            // 
            this.tb_mdp.Location = new System.Drawing.Point(122, 57);
            this.tb_mdp.Name = "tb_mdp";
            this.tb_mdp.PasswordChar = '*';
            this.tb_mdp.Size = new System.Drawing.Size(100, 20);
            this.tb_mdp.TabIndex = 3;
            // 
            // btn_connexion
            // 
            this.btn_connexion.Location = new System.Drawing.Point(67, 96);
            this.btn_connexion.Name = "btn_connexion";
            this.btn_connexion.Size = new System.Drawing.Size(117, 35);
            this.btn_connexion.TabIndex = 4;
            this.btn_connexion.Text = "Se connecter";
            this.btn_connexion.UseVisualStyleBackColor = true;
            this.btn_connexion.Click += new System.EventHandler(this.btn_connexion_Click);
            // 
            // ConnexionForm
            // 
            this.AcceptButton = this.btn_connexion;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 153);
            this.Controls.Add(this.btn_connexion);
            this.Controls.Add(this.tb_mdp);
            this.Controls.Add(this.tb_login);
            this.Controls.Add(this.lbl_mdp);
            this.Controls.Add(this.lbl_login);
            this.Name = "ConnexionForm";
            this.Text = "Bel\'Form - Connexion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.Label lbl_mdp;
        private System.Windows.Forms.TextBox tb_login;
        private System.Windows.Forms.TextBox tb_mdp;
        private System.Windows.Forms.Button btn_connexion;
    }
}