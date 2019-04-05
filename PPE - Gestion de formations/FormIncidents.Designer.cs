namespace PPE___Gestion_de_formations
{
    partial class FormIncidents
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
            this.db_incidents = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.db_incidents)).BeginInit();
            this.SuspendLayout();
            // 
            // db_incidents
            // 
            this.db_incidents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.db_incidents.Location = new System.Drawing.Point(34, 39);
            this.db_incidents.MultiSelect = false;
            this.db_incidents.Name = "db_incidents";
            this.db_incidents.ReadOnly = true;
            this.db_incidents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.db_incidents.Size = new System.Drawing.Size(721, 363);
            this.db_incidents.TabIndex = 0;
            this.db_incidents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.db_incidents_CellContentClick);
            // 
            // FormIncidents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 450);
            this.Controls.Add(this.db_incidents);
            this.Name = "FormIncidents";
            this.Text = "Incidents";
            ((System.ComponentModel.ISupportInitialize)(this.db_incidents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView db_incidents;
    }
}