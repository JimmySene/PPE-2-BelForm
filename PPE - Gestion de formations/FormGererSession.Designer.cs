namespace PPE___Gestion_de_formations
{
    partial class FormGererSession
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
            this.cb_formations = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dg_sessions = new System.Windows.Forms.DataGridView();
            this.btn_ajouter = new System.Windows.Forms.Button();
            this.btn_supprimer = new System.Windows.Forms.Button();
            this.btn_candidatures = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_sessions)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_formations
            // 
            this.cb_formations.FormattingEnabled = true;
            this.cb_formations.Location = new System.Drawing.Point(49, 56);
            this.cb_formations.Name = "cb_formations";
            this.cb_formations.Size = new System.Drawing.Size(411, 21);
            this.cb_formations.TabIndex = 0;
            this.cb_formations.SelectedIndexChanged += new System.EventHandler(this.cb_formations_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sélectionnez une formation : ";
            // 
            // dg_sessions
            // 
            this.dg_sessions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_sessions.Location = new System.Drawing.Point(49, 119);
            this.dg_sessions.MultiSelect = false;
            this.dg_sessions.Name = "dg_sessions";
            this.dg_sessions.ReadOnly = true;
            this.dg_sessions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_sessions.Size = new System.Drawing.Size(506, 216);
            this.dg_sessions.TabIndex = 2;
            // 
            // btn_ajouter
            // 
            this.btn_ajouter.Location = new System.Drawing.Point(49, 364);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(93, 33);
            this.btn_ajouter.TabIndex = 3;
            this.btn_ajouter.Text = "Ajouter";
            this.btn_ajouter.UseVisualStyleBackColor = true;
            this.btn_ajouter.Click += new System.EventHandler(this.btn_ajouter_Click);
            // 
            // btn_supprimer
            // 
            this.btn_supprimer.Location = new System.Drawing.Point(166, 364);
            this.btn_supprimer.Name = "btn_supprimer";
            this.btn_supprimer.Size = new System.Drawing.Size(93, 33);
            this.btn_supprimer.TabIndex = 5;
            this.btn_supprimer.Text = "Supprimer";
            this.btn_supprimer.UseVisualStyleBackColor = true;
            this.btn_supprimer.Click += new System.EventHandler(this.btn_supprimer_Click);
            // 
            // btn_candidatures
            // 
            this.btn_candidatures.Location = new System.Drawing.Point(288, 364);
            this.btn_candidatures.Name = "btn_candidatures";
            this.btn_candidatures.Size = new System.Drawing.Size(172, 33);
            this.btn_candidatures.TabIndex = 6;
            this.btn_candidatures.Text = "Gérer les candidatures";
            this.btn_candidatures.UseVisualStyleBackColor = true;
            this.btn_candidatures.Click += new System.EventHandler(this.btn_candidatures_Click);
            // 
            // FormGererSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 429);
            this.Controls.Add(this.btn_candidatures);
            this.Controls.Add(this.btn_supprimer);
            this.Controls.Add(this.btn_ajouter);
            this.Controls.Add(this.dg_sessions);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_formations);
            this.Name = "FormGererSession";
            this.Text = "Gérer les sessions";
            this.Load += new System.EventHandler(this.FormGererSession_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_sessions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_formations;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dg_sessions;
        private System.Windows.Forms.Button btn_ajouter;
        private System.Windows.Forms.Button btn_supprimer;
        private System.Windows.Forms.Button btn_candidatures;
    }
}