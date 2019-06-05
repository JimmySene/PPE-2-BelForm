namespace PPE___Gestion_de_formations
{
    partial class FormAdmin
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
            this.btn_incidents = new System.Windows.Forms.Button();
            this.btn_gerer_formations = new System.Windows.Forms.Button();
            this.btn_gerer_utilisateurs = new System.Windows.Forms.Button();
            this.btn_gerer_sessions = new System.Windows.Forms.Button();
            this.link_deconnexion = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btn_incidents
            // 
            this.btn_incidents.Location = new System.Drawing.Point(74, 34);
            this.btn_incidents.Name = "btn_incidents";
            this.btn_incidents.Size = new System.Drawing.Size(130, 23);
            this.btn_incidents.TabIndex = 0;
            this.btn_incidents.Text = "Voir les incidents";
            this.btn_incidents.UseVisualStyleBackColor = true;
            this.btn_incidents.Click += new System.EventHandler(this.btn_incidents_Click);
            // 
            // btn_gerer_formations
            // 
            this.btn_gerer_formations.Location = new System.Drawing.Point(74, 87);
            this.btn_gerer_formations.Name = "btn_gerer_formations";
            this.btn_gerer_formations.Size = new System.Drawing.Size(130, 23);
            this.btn_gerer_formations.TabIndex = 1;
            this.btn_gerer_formations.Text = "Gérer les formations";
            this.btn_gerer_formations.UseVisualStyleBackColor = true;
            this.btn_gerer_formations.Click += new System.EventHandler(this.btn_gerer_formations_Click);
            // 
            // btn_gerer_utilisateurs
            // 
            this.btn_gerer_utilisateurs.Location = new System.Drawing.Point(74, 201);
            this.btn_gerer_utilisateurs.Name = "btn_gerer_utilisateurs";
            this.btn_gerer_utilisateurs.Size = new System.Drawing.Size(130, 23);
            this.btn_gerer_utilisateurs.TabIndex = 2;
            this.btn_gerer_utilisateurs.Text = "Gérer les utilisateurs";
            this.btn_gerer_utilisateurs.UseVisualStyleBackColor = true;
            // 
            // btn_gerer_sessions
            // 
            this.btn_gerer_sessions.Location = new System.Drawing.Point(74, 144);
            this.btn_gerer_sessions.Name = "btn_gerer_sessions";
            this.btn_gerer_sessions.Size = new System.Drawing.Size(130, 23);
            this.btn_gerer_sessions.TabIndex = 4;
            this.btn_gerer_sessions.Text = "Gérer les sessions";
            this.btn_gerer_sessions.UseVisualStyleBackColor = true;
            this.btn_gerer_sessions.Click += new System.EventHandler(this.btn_gerer_sessions_Click);
            // 
            // link_deconnexion
            // 
            this.link_deconnexion.AutoSize = true;
            this.link_deconnexion.Location = new System.Drawing.Point(93, 263);
            this.link_deconnexion.Name = "link_deconnexion";
            this.link_deconnexion.Size = new System.Drawing.Size(83, 13);
            this.link_deconnexion.TabIndex = 5;
            this.link_deconnexion.TabStop = true;
            this.link_deconnexion.Text = "Se déconnecter";
            this.link_deconnexion.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_deconnexion_LinkClicked);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 298);
            this.Controls.Add(this.link_deconnexion);
            this.Controls.Add(this.btn_gerer_sessions);
            this.Controls.Add(this.btn_gerer_utilisateurs);
            this.Controls.Add(this.btn_gerer_formations);
            this.Controls.Add(this.btn_incidents);
            this.Name = "FormAdmin";
            this.Text = "Panneau d\'administration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_incidents;
        private System.Windows.Forms.Button btn_gerer_formations;
        private System.Windows.Forms.Button btn_gerer_utilisateurs;
        private System.Windows.Forms.Button btn_gerer_sessions;
        private System.Windows.Forms.LinkLabel link_deconnexion;
    }
}