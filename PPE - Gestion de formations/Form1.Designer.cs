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
            ((System.ComponentModel.ISupportInitialize)(this.dg_sessions)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_formation
            // 
            this.lbl_formation.AutoSize = true;
            this.lbl_formation.Location = new System.Drawing.Point(13, 24);
            this.lbl_formation.Name = "lbl_formation";
            this.lbl_formation.Size = new System.Drawing.Size(62, 13);
            this.lbl_formation.TabIndex = 0;
            this.lbl_formation.Text = "Formation : ";
            // 
            // cb_formation
            // 
            this.cb_formation.FormattingEnabled = true;
            this.cb_formation.Location = new System.Drawing.Point(16, 51);
            this.cb_formation.Name = "cb_formation";
            this.cb_formation.Size = new System.Drawing.Size(321, 21);
            this.cb_formation.TabIndex = 1;
            this.cb_formation.SelectedIndexChanged += new System.EventHandler(this.cb_formation_SelectedIndexChanged);
            // 
            // dg_sessions
            // 
            this.dg_sessions.AllowUserToAddRows = false;
            this.dg_sessions.AllowUserToDeleteRows = false;
            this.dg_sessions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_sessions.Location = new System.Drawing.Point(16, 133);
            this.dg_sessions.MultiSelect = false;
            this.dg_sessions.Name = "dg_sessions";
            this.dg_sessions.ReadOnly = true;
            this.dg_sessions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_sessions.Size = new System.Drawing.Size(321, 150);
            this.dg_sessions.TabIndex = 2;
            this.dg_sessions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_sessions_CellContentClick);
            // 
            // lbl_sessions
            // 
            this.lbl_sessions.AutoSize = true;
            this.lbl_sessions.Location = new System.Drawing.Point(16, 98);
            this.lbl_sessions.Name = "lbl_sessions";
            this.lbl_sessions.Size = new System.Drawing.Size(55, 13);
            this.lbl_sessions.TabIndex = 3;
            this.lbl_sessions.Text = "Sessions :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

