namespace PPE___Gestion_de_formations
{
    partial class FormCandidaterParticipant
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
            this.cb_participants = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_candidater = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_participants
            // 
            this.cb_participants.FormattingEnabled = true;
            this.cb_participants.Location = new System.Drawing.Point(45, 36);
            this.cb_participants.Name = "cb_participants";
            this.cb_participants.Size = new System.Drawing.Size(258, 21);
            this.cb_participants.TabIndex = 0;
            this.cb_participants.SelectedIndexChanged += new System.EventHandler(this.cb_participants_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Participant : ";
            // 
            // btn_candidater
            // 
            this.btn_candidater.Location = new System.Drawing.Point(113, 80);
            this.btn_candidater.Name = "btn_candidater";
            this.btn_candidater.Size = new System.Drawing.Size(127, 32);
            this.btn_candidater.TabIndex = 2;
            this.btn_candidater.Text = "Faire candidater";
            this.btn_candidater.UseVisualStyleBackColor = true;
            this.btn_candidater.Click += new System.EventHandler(this.btn_candidater_Click);
            // 
            // FormCandidaterParticipant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 144);
            this.Controls.Add(this.btn_candidater);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_participants);
            this.Name = "FormCandidaterParticipant";
            this.Text = "Faire candidater un participant";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_participants;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_candidater;
    }
}