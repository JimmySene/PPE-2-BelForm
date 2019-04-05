using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPE___Gestion_de_formations
{
    public partial class FormIncident : Form
    {
        Incident Lincident;
        public FormIncident(Incident lincident)
        {
            Lincident = lincident;
            List<StatutIncident> statuts = new List<StatutIncident>();
            StatutIncident nontraite = new StatutIncident(0, "non traite");
            StatutIncident encours = new StatutIncident(1, "en cours");
            StatutIncident resolu = new StatutIncident(2, "résolu");

            statuts.Add(nontraite);
            statuts.Add(encours);
            statuts.Add(resolu);
           
            InitializeComponent();

            cb_statut.DataSource = statuts;
            cb_statut.DisplayMember = "Nom";
            cb_statut.ValueMember = "ID";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StatutIncident statutIncident= (StatutIncident)cb_statut.SelectedItem;
            Lincident.Statut = statutIncident.ID;

            IncidentManager incidentManager = new IncidentManager();
            incidentManager.modifIncident(Lincident);

            this.DialogResult = DialogResult.OK;
        }
    }
}
