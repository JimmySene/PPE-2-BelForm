namespace PPE___Gestion_de_formations
{
    partial class FormGestio
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
            this.btn_ajout_participants = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_formations = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_candidater = new System.Windows.Forms.Button();
            this.cb_formations = new System.Windows.Forms.ComboBox();
            this.dg_sessions = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_sessions)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ajout_participants
            // 
            this.btn_ajout_participants.Location = new System.Drawing.Point(80, 174);
            this.btn_ajout_participants.Name = "btn_ajout_participants";
            this.btn_ajout_participants.Size = new System.Drawing.Size(206, 34);
            this.btn_ajout_participants.TabIndex = 0;
            this.btn_ajout_participants.Text = "Ajouter un participant";
            this.btn_ajout_participants.UseVisualStyleBackColor = true;
            this.btn_ajout_participants.Click += new System.EventHandler(this.btn_ajout_participants_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Formation : ";
            // 
            // lb_formations
            // 
            this.lb_formations.FormattingEnabled = true;
            this.lb_formations.Location = new System.Drawing.Point(61, 51);
            this.lb_formations.Name = "lb_formations";
            this.lb_formations.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lb_formations.Size = new System.Drawing.Size(252, 95);
            this.lb_formations.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_ajout_participants);
            this.groupBox1.Controls.Add(this.lb_formations);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(26, 154);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(412, 254);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inscrire un participant à une ou plusieurs formation(s)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dg_sessions);
            this.groupBox2.Controls.Add(this.cb_formations);
            this.groupBox2.Controls.Add(this.btn_candidater);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(475, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(412, 396);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Inscrire un participant existant à une ou plusieurs session(s)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Formation : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sessions : ";
            // 
            // btn_candidater
            // 
            this.btn_candidater.Location = new System.Drawing.Point(114, 329);
            this.btn_candidater.Name = "btn_candidater";
            this.btn_candidater.Size = new System.Drawing.Size(194, 34);
            this.btn_candidater.TabIndex = 8;
            this.btn_candidater.Text = "Faire candidater un participant";
            this.btn_candidater.UseVisualStyleBackColor = true;
            this.btn_candidater.Click += new System.EventHandler(this.button1_Click);
            // 
            // cb_formations
            // 
            this.cb_formations.FormattingEnabled = true;
            this.cb_formations.Location = new System.Drawing.Point(61, 68);
            this.cb_formations.Name = "cb_formations";
            this.cb_formations.Size = new System.Drawing.Size(276, 21);
            this.cb_formations.TabIndex = 9;
            this.cb_formations.SelectedIndexChanged += new System.EventHandler(this.cb_formations_SelectedIndexChanged);
            // 
            // dg_sessions
            // 
            this.dg_sessions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_sessions.Location = new System.Drawing.Point(61, 142);
            this.dg_sessions.Name = "dg_sessions";
            this.dg_sessions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_sessions.Size = new System.Drawing.Size(307, 150);
            this.dg_sessions.TabIndex = 10;
            // 
            // FormGestio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 433);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormGestio";
            this.Text = "Espace gestionnaire";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_sessions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ajout_participants;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lb_formations;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_candidater;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_formations;
        private System.Windows.Forms.DataGridView dg_sessions;
    }
}