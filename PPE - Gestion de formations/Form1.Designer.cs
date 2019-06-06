namespace PPE___Gestion_de_formations
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_formation = new System.Windows.Forms.Label();
            this.cb_formation = new System.Windows.Forms.ComboBox();
            this.dg_sessions = new System.Windows.Forms.DataGridView();
            this.lbl_sessions = new System.Windows.Forms.Label();
            this.link_incident = new System.Windows.Forms.LinkLabel();
            this.link_deconnexion = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dg_sessions)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_formation
            // 
            this.lbl_formation.AutoSize = true;
            this.lbl_formation.Location = new System.Drawing.Point(12, 112);
            this.lbl_formation.Name = "lbl_formation";
            this.lbl_formation.Size = new System.Drawing.Size(62, 13);
            this.lbl_formation.TabIndex = 0;
            this.lbl_formation.Text = "Formation : ";
            // 
            // cb_formation
            // 
            this.cb_formation.FormattingEnabled = true;
            this.cb_formation.Location = new System.Drawing.Point(12, 141);
            this.cb_formation.Name = "cb_formation";
            this.cb_formation.Size = new System.Drawing.Size(402, 21);
            this.cb_formation.TabIndex = 1;
            this.cb_formation.SelectedIndexChanged += new System.EventHandler(this.cb_formation_SelectedIndexChanged);
            // 
            // dg_sessions
            // 
            this.dg_sessions.AllowUserToAddRows = false;
            this.dg_sessions.AllowUserToDeleteRows = false;
            this.dg_sessions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_sessions.Location = new System.Drawing.Point(16, 202);
            this.dg_sessions.MultiSelect = false;
            this.dg_sessions.Name = "dg_sessions";
            this.dg_sessions.ReadOnly = true;
            this.dg_sessions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_sessions.Size = new System.Drawing.Size(504, 353);
            this.dg_sessions.TabIndex = 2;
            this.dg_sessions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_sessions_CellContentClick);
            // 
            // lbl_sessions
            // 
            this.lbl_sessions.AutoSize = true;
            this.lbl_sessions.Location = new System.Drawing.Point(13, 175);
            this.lbl_sessions.Name = "lbl_sessions";
            this.lbl_sessions.Size = new System.Drawing.Size(55, 13);
            this.lbl_sessions.TabIndex = 3;
            this.lbl_sessions.Text = "Sessions :";
            // 
            // link_incident
            // 
            this.link_incident.AutoSize = true;
            this.link_incident.Location = new System.Drawing.Point(23, 584);
            this.link_incident.Name = "link_incident";
            this.link_incident.Size = new System.Drawing.Size(102, 13);
            this.link_incident.TabIndex = 4;
            this.link_incident.TabStop = true;
            this.link_incident.Text = "Déclarer un incident";
            this.link_incident.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_incident_LinkClicked);
            // 
            // link_deconnexion
            // 
            this.link_deconnexion.AutoSize = true;
            this.link_deconnexion.Location = new System.Drawing.Point(426, 584);
            this.link_deconnexion.Name = "link_deconnexion";
            this.link_deconnexion.Size = new System.Drawing.Size(83, 13);
            this.link_deconnexion.TabIndex = 8;
            this.link_deconnexion.TabStop = true;
            this.link_deconnexion.Text = "Se déconnecter";
            this.link_deconnexion.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_deconnexion_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(129, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 33);
            this.label1.TabIndex = 9;
            this.label1.Text = "Bel\'Form - Espace invité";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 615);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.link_deconnexion);
            this.Controls.Add(this.link_incident);
            this.Controls.Add(this.lbl_sessions);
            this.Controls.Add(this.dg_sessions);
            this.Controls.Add(this.cb_formation);
            this.Controls.Add(this.lbl_formation);
            this.Name = "Form1";
            this.Text = "Bel\'Form";
            ((System.ComponentModel.ISupportInitialize)(this.dg_sessions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_formation;
        private System.Windows.Forms.ComboBox cb_formation;
        private System.Windows.Forms.DataGridView dg_sessions;
        private System.Windows.Forms.Label lbl_sessions;
        private System.Windows.Forms.LinkLabel link_incident;
        private System.Windows.Forms.LinkLabel link_deconnexion;
        private System.Windows.Forms.Label label1;
    }
}

