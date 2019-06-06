namespace PPE___Gestion_de_formations
{
    partial class FormInsererIncident
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
            this.tb_lib_incident = new System.Windows.Forms.TextBox();
            this.rtb_message_incident = new System.Windows.Forms.RichTextBox();
            this.btn_saisir_incident = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Libelle : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Message : ";
            // 
            // tb_lib_incident
            // 
            this.tb_lib_incident.Location = new System.Drawing.Point(82, 35);
            this.tb_lib_incident.Name = "tb_lib_incident";
            this.tb_lib_incident.Size = new System.Drawing.Size(233, 20);
            this.tb_lib_incident.TabIndex = 2;
            // 
            // rtb_message_incident
            // 
            this.rtb_message_incident.Location = new System.Drawing.Point(33, 111);
            this.rtb_message_incident.Name = "rtb_message_incident";
            this.rtb_message_incident.Size = new System.Drawing.Size(282, 161);
            this.rtb_message_incident.TabIndex = 3;
            this.rtb_message_incident.Text = "";
            // 
            // btn_saisir_incident
            // 
            this.btn_saisir_incident.Location = new System.Drawing.Point(105, 294);
            this.btn_saisir_incident.Name = "btn_saisir_incident";
            this.btn_saisir_incident.Size = new System.Drawing.Size(112, 34);
            this.btn_saisir_incident.TabIndex = 4;
            this.btn_saisir_incident.Text = "Envoyer";
            this.btn_saisir_incident.UseVisualStyleBackColor = true;
            this.btn_saisir_incident.Click += new System.EventHandler(this.btn_saisir_incident_Click);
            // 
            // FormInsererIncident
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 349);
            this.Controls.Add(this.btn_saisir_incident);
            this.Controls.Add(this.rtb_message_incident);
            this.Controls.Add(this.tb_lib_incident);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormInsererIncident";
            this.Text = "Saisir un incident";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_lib_incident;
        private System.Windows.Forms.RichTextBox rtb_message_incident;
        private System.Windows.Forms.Button btn_saisir_incident;
    }
}