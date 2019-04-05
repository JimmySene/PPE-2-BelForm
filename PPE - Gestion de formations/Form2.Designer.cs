namespace PPE___Gestion_de_formations
{
    partial class Form2
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
            this.lbl_formation = new System.Windows.Forms.Label();
            this.dg_inscrits = new System.Windows.Forms.DataGridView();
            this.dg_postulants = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_inscrire = new System.Windows.Forms.Button();
            this.btn_desinscrire = new System.Windows.Forms.Button();
            this.btn_ajouter_postulant = new System.Windows.Forms.Button();
            this.btn_retirer_postulant = new System.Windows.Forms.Button();
            this.btn_valider = new System.Windows.Forms.Button();
            this.btn_annuler = new System.Windows.Forms.Button();
            this.dtp_datedebut = new System.Windows.Forms.DateTimePicker();
            this.dtp_datefin = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dg_inscrits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_postulants)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date du";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(291, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "au";
            // 
            // lbl_formation
            // 
            this.lbl_formation.AutoSize = true;
            this.lbl_formation.Location = new System.Drawing.Point(28, 20);
            this.lbl_formation.Name = "lbl_formation";
            this.lbl_formation.Size = new System.Drawing.Size(62, 13);
            this.lbl_formation.TabIndex = 4;
            this.lbl_formation.Text = "Formation : ";
            // 
            // dg_inscrits
            // 
            this.dg_inscrits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_inscrits.Location = new System.Drawing.Point(31, 152);
            this.dg_inscrits.MultiSelect = false;
            this.dg_inscrits.Name = "dg_inscrits";
            this.dg_inscrits.ReadOnly = true;
            this.dg_inscrits.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_inscrits.Size = new System.Drawing.Size(240, 150);
            this.dg_inscrits.TabIndex = 5;
            // 
            // dg_postulants
            // 
            this.dg_postulants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_postulants.Location = new System.Drawing.Point(424, 152);
            this.dg_postulants.MultiSelect = false;
            this.dg_postulants.Name = "dg_postulants";
            this.dg_postulants.ReadOnly = true;
            this.dg_postulants.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_postulants.Size = new System.Drawing.Size(240, 150);
            this.dg_postulants.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Inscrits :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(515, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Postulants :";
            // 
            // btn_inscrire
            // 
            this.btn_inscrire.Location = new System.Drawing.Point(312, 185);
            this.btn_inscrire.Name = "btn_inscrire";
            this.btn_inscrire.Size = new System.Drawing.Size(75, 23);
            this.btn_inscrire.TabIndex = 9;
            this.btn_inscrire.Text = "<";
            this.btn_inscrire.UseVisualStyleBackColor = true;
            this.btn_inscrire.Click += new System.EventHandler(this.btn_inscrire_Click);
            // 
            // btn_desinscrire
            // 
            this.btn_desinscrire.Location = new System.Drawing.Point(312, 233);
            this.btn_desinscrire.Name = "btn_desinscrire";
            this.btn_desinscrire.Size = new System.Drawing.Size(75, 23);
            this.btn_desinscrire.TabIndex = 10;
            this.btn_desinscrire.Text = ">";
            this.btn_desinscrire.UseVisualStyleBackColor = false;
            this.btn_desinscrire.Click += new System.EventHandler(this.btn_desinscrire_Click);
            // 
            // btn_ajouter_postulant
            // 
            this.btn_ajouter_postulant.Location = new System.Drawing.Point(583, 123);
            this.btn_ajouter_postulant.Name = "btn_ajouter_postulant";
            this.btn_ajouter_postulant.Size = new System.Drawing.Size(26, 23);
            this.btn_ajouter_postulant.TabIndex = 11;
            this.btn_ajouter_postulant.Text = "+";
            this.btn_ajouter_postulant.UseVisualStyleBackColor = true;
            // 
            // btn_retirer_postulant
            // 
            this.btn_retirer_postulant.Location = new System.Drawing.Point(615, 123);
            this.btn_retirer_postulant.Name = "btn_retirer_postulant";
            this.btn_retirer_postulant.Size = new System.Drawing.Size(26, 23);
            this.btn_retirer_postulant.TabIndex = 12;
            this.btn_retirer_postulant.Text = "-";
            this.btn_retirer_postulant.UseVisualStyleBackColor = true;
            // 
            // btn_valider
            // 
            this.btn_valider.Location = new System.Drawing.Point(235, 363);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(75, 23);
            this.btn_valider.TabIndex = 13;
            this.btn_valider.Text = "Valider";
            this.btn_valider.UseVisualStyleBackColor = true;
            // 
            // btn_annuler
            // 
            this.btn_annuler.Location = new System.Drawing.Point(375, 363);
            this.btn_annuler.Name = "btn_annuler";
            this.btn_annuler.Size = new System.Drawing.Size(75, 23);
            this.btn_annuler.TabIndex = 14;
            this.btn_annuler.Text = "Annuler";
            this.btn_annuler.UseVisualStyleBackColor = true;
            // 
            // dtp_datedebut
            // 
            this.dtp_datedebut.Location = new System.Drawing.Point(79, 82);
            this.dtp_datedebut.Name = "dtp_datedebut";
            this.dtp_datedebut.Size = new System.Drawing.Size(200, 20);
            this.dtp_datedebut.TabIndex = 15;
            // 
            // dtp_datefin
            // 
            this.dtp_datefin.Location = new System.Drawing.Point(316, 82);
            this.dtp_datefin.Name = "dtp_datefin";
            this.dtp_datefin.Size = new System.Drawing.Size(200, 20);
            this.dtp_datefin.TabIndex = 16;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtp_datefin);
            this.Controls.Add(this.dtp_datedebut);
            this.Controls.Add(this.btn_annuler);
            this.Controls.Add(this.btn_valider);
            this.Controls.Add(this.btn_retirer_postulant);
            this.Controls.Add(this.btn_ajouter_postulant);
            this.Controls.Add(this.btn_desinscrire);
            this.Controls.Add(this.btn_inscrire);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dg_postulants);
            this.Controls.Add(this.dg_inscrits);
            this.Controls.Add(this.lbl_formation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Bel\'Form";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_inscrits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_postulants)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_formation;
        private System.Windows.Forms.DataGridView dg_inscrits;
        private System.Windows.Forms.DataGridView dg_postulants;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_inscrire;
        private System.Windows.Forms.Button btn_desinscrire;
        private System.Windows.Forms.Button btn_ajouter_postulant;
        private System.Windows.Forms.Button btn_retirer_postulant;
        private System.Windows.Forms.Button btn_valider;
        private System.Windows.Forms.Button btn_annuler;
        private System.Windows.Forms.DateTimePicker dtp_datedebut;
        private System.Windows.Forms.DateTimePicker dtp_datefin;
    }
}