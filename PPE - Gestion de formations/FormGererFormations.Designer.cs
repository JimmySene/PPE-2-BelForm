namespace PPE___Gestion_de_formations
{
    partial class FormGererFormations
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
            this.btn_ajouter_formation = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_nom_formation = new System.Windows.Forms.Label();
            this.tb_nom_formation = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_supprimer_formation = new System.Windows.Forms.Button();
            this.cb_supprimer_formation = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_nom_formation_modif = new System.Windows.Forms.TextBox();
            this.btn_modifier_formation = new System.Windows.Forms.Button();
            this.cb_modifier_formation = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_ajouter_formation
            // 
            this.btn_ajouter_formation.Location = new System.Drawing.Point(143, 112);
            this.btn_ajouter_formation.Name = "btn_ajouter_formation";
            this.btn_ajouter_formation.Size = new System.Drawing.Size(93, 23);
            this.btn_ajouter_formation.TabIndex = 0;
            this.btn_ajouter_formation.Text = "Ajouter";
            this.btn_ajouter_formation.UseVisualStyleBackColor = true;
            this.btn_ajouter_formation.Click += new System.EventHandler(this.btn_ajouter_formation_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_nom_formation);
            this.groupBox1.Controls.Add(this.tb_nom_formation);
            this.groupBox1.Controls.Add(this.btn_ajouter_formation);
            this.groupBox1.Location = new System.Drawing.Point(39, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 158);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ajouter une formation";
            // 
            // lbl_nom_formation
            // 
            this.lbl_nom_formation.AutoSize = true;
            this.lbl_nom_formation.Location = new System.Drawing.Point(49, 36);
            this.lbl_nom_formation.Name = "lbl_nom_formation";
            this.lbl_nom_formation.Size = new System.Drawing.Size(110, 13);
            this.lbl_nom_formation.TabIndex = 2;
            this.lbl_nom_formation.Text = "Nom de la formation : ";
            // 
            // tb_nom_formation
            // 
            this.tb_nom_formation.Location = new System.Drawing.Point(52, 67);
            this.tb_nom_formation.Name = "tb_nom_formation";
            this.tb_nom_formation.Size = new System.Drawing.Size(260, 20);
            this.tb_nom_formation.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_supprimer_formation);
            this.groupBox2.Controls.Add(this.cb_supprimer_formation);
            this.groupBox2.Location = new System.Drawing.Point(39, 209);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(378, 133);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Supprimer une formation";
            // 
            // btn_supprimer_formation
            // 
            this.btn_supprimer_formation.Location = new System.Drawing.Point(143, 85);
            this.btn_supprimer_formation.Name = "btn_supprimer_formation";
            this.btn_supprimer_formation.Size = new System.Drawing.Size(93, 23);
            this.btn_supprimer_formation.TabIndex = 1;
            this.btn_supprimer_formation.Text = "Supprimer";
            this.btn_supprimer_formation.UseVisualStyleBackColor = true;
            this.btn_supprimer_formation.Click += new System.EventHandler(this.btn_supprimer_formation_Click);
            // 
            // cb_supprimer_formation
            // 
            this.cb_supprimer_formation.FormattingEnabled = true;
            this.cb_supprimer_formation.Location = new System.Drawing.Point(52, 43);
            this.cb_supprimer_formation.Name = "cb_supprimer_formation";
            this.cb_supprimer_formation.Size = new System.Drawing.Size(260, 21);
            this.cb_supprimer_formation.TabIndex = 0;
            this.cb_supprimer_formation.SelectedIndexChanged += new System.EventHandler(this.cb_supprimer_formation_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.tb_nom_formation_modif);
            this.groupBox3.Controls.Add(this.btn_modifier_formation);
            this.groupBox3.Controls.Add(this.cb_modifier_formation);
            this.groupBox3.Location = new System.Drawing.Point(39, 365);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(378, 203);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Modifier une formation";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nouveau nom de la formation : ";
            // 
            // tb_nom_formation_modif
            // 
            this.tb_nom_formation_modif.Location = new System.Drawing.Point(52, 112);
            this.tb_nom_formation_modif.Name = "tb_nom_formation_modif";
            this.tb_nom_formation_modif.Size = new System.Drawing.Size(260, 20);
            this.tb_nom_formation_modif.TabIndex = 2;
            // 
            // btn_modifier_formation
            // 
            this.btn_modifier_formation.Location = new System.Drawing.Point(143, 154);
            this.btn_modifier_formation.Name = "btn_modifier_formation";
            this.btn_modifier_formation.Size = new System.Drawing.Size(93, 23);
            this.btn_modifier_formation.TabIndex = 1;
            this.btn_modifier_formation.Text = "Modifier";
            this.btn_modifier_formation.UseVisualStyleBackColor = true;
            this.btn_modifier_formation.Click += new System.EventHandler(this.btn_modifier_formation_Click);
            // 
            // cb_modifier_formation
            // 
            this.cb_modifier_formation.FormattingEnabled = true;
            this.cb_modifier_formation.Location = new System.Drawing.Point(52, 34);
            this.cb_modifier_formation.Name = "cb_modifier_formation";
            this.cb_modifier_formation.Size = new System.Drawing.Size(260, 21);
            this.cb_modifier_formation.TabIndex = 0;
            // 
            // FormGererFormations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 597);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormGererFormations";
            this.Text = "Gérer les formations";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ajouter_formation;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_nom_formation;
        private System.Windows.Forms.TextBox tb_nom_formation;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_supprimer_formation;
        private System.Windows.Forms.ComboBox cb_supprimer_formation;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_nom_formation_modif;
        private System.Windows.Forms.Button btn_modifier_formation;
        private System.Windows.Forms.ComboBox cb_modifier_formation;
    }
}