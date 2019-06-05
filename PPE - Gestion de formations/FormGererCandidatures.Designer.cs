namespace PPE___Gestion_de_formations
{
    partial class FormGererCandidatures
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
            this.lbl_session = new System.Windows.Forms.Label();
            this.dg_candidats = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dg_inscrits = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_accepter = new System.Windows.Forms.Button();
            this.btn_refuser = new System.Windows.Forms.Button();
            this.btn_retirer = new System.Windows.Forms.Button();
            this.lbl_nb_inscrits = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dg_candidats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_inscrits)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_session
            // 
            this.lbl_session.AutoSize = true;
            this.lbl_session.Location = new System.Drawing.Point(59, 33);
            this.lbl_session.Name = "lbl_session";
            this.lbl_session.Size = new System.Drawing.Size(0, 13);
            this.lbl_session.TabIndex = 0;
            // 
            // dg_candidats
            // 
            this.dg_candidats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_candidats.Location = new System.Drawing.Point(62, 125);
            this.dg_candidats.Name = "dg_candidats";
            this.dg_candidats.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_candidats.Size = new System.Drawing.Size(270, 215);
            this.dg_candidats.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Candidats : ";
            // 
            // dg_inscrits
            // 
            this.dg_inscrits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_inscrits.Location = new System.Drawing.Point(446, 125);
            this.dg_inscrits.Name = "dg_inscrits";
            this.dg_inscrits.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_inscrits.Size = new System.Drawing.Size(270, 215);
            this.dg_inscrits.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(443, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Inscrits (validés) :";
            // 
            // btn_accepter
            // 
            this.btn_accepter.Location = new System.Drawing.Point(106, 364);
            this.btn_accepter.Name = "btn_accepter";
            this.btn_accepter.Size = new System.Drawing.Size(75, 23);
            this.btn_accepter.TabIndex = 5;
            this.btn_accepter.Text = "Accepter";
            this.btn_accepter.UseVisualStyleBackColor = true;
            this.btn_accepter.Click += new System.EventHandler(this.btn_accepter_Click);
            // 
            // btn_refuser
            // 
            this.btn_refuser.Location = new System.Drawing.Point(208, 364);
            this.btn_refuser.Name = "btn_refuser";
            this.btn_refuser.Size = new System.Drawing.Size(75, 23);
            this.btn_refuser.TabIndex = 6;
            this.btn_refuser.Text = "Refuser";
            this.btn_refuser.UseVisualStyleBackColor = true;
            this.btn_refuser.Click += new System.EventHandler(this.btn_refuser_Click);
            // 
            // btn_retirer
            // 
            this.btn_retirer.Location = new System.Drawing.Point(538, 364);
            this.btn_retirer.Name = "btn_retirer";
            this.btn_retirer.Size = new System.Drawing.Size(75, 23);
            this.btn_retirer.TabIndex = 7;
            this.btn_retirer.Text = "Retirer";
            this.btn_retirer.UseVisualStyleBackColor = true;
            this.btn_retirer.Click += new System.EventHandler(this.btn_retirer_Click);
            // 
            // lbl_nb_inscrits
            // 
            this.lbl_nb_inscrits.AutoSize = true;
            this.lbl_nb_inscrits.Location = new System.Drawing.Point(443, 33);
            this.lbl_nb_inscrits.Name = "lbl_nb_inscrits";
            this.lbl_nb_inscrits.Size = new System.Drawing.Size(96, 13);
            this.lbl_nb_inscrits.TabIndex = 8;
            this.lbl_nb_inscrits.Text = "Nombre d\'inscrits : ";
            // 
            // FormGererCandidatures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_nb_inscrits);
            this.Controls.Add(this.btn_retirer);
            this.Controls.Add(this.btn_refuser);
            this.Controls.Add(this.btn_accepter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dg_inscrits);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dg_candidats);
            this.Controls.Add(this.lbl_session);
            this.Name = "FormGererCandidatures";
            this.Text = "Gérer les candidatures";
            this.Load += new System.EventHandler(this.FormGererCandidatures_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_candidats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_inscrits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_session;
        private System.Windows.Forms.DataGridView dg_candidats;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dg_inscrits;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_accepter;
        private System.Windows.Forms.Button btn_refuser;
        private System.Windows.Forms.Button btn_retirer;
        private System.Windows.Forms.Label lbl_nb_inscrits;
    }
}