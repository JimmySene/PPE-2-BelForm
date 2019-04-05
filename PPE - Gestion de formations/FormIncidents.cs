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
    public partial class FormIncidents : Form
    {
        List<Incident> listIncidents = new List<Incident>();
        IncidentManager incidentManager = new IncidentManager();
        public FormIncidents()
        {
            InitializeComponent();
            listIncidents = incidentManager.getIncidents();
            db_incidents.DataSource = listIncidents;
            db_incidents.Columns["ID"].Visible = false;
            db_incidents.Columns["IdUtilisateur"].HeaderText = "Utilisateur";
            db_incidents.Columns["DatePost"].HeaderText = "Date création";
            db_incidents.Columns["DateTrait"].HeaderText = "Date traitement";
            db_incidents.Columns["DateReso"].HeaderText = "Date résolution";

        }

        private void db_incidents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Incident lincident = (Incident)db_incidents.CurrentRow.DataBoundItem;

            FormIncident formIncident = new FormIncident(lincident);
            formIncident.ShowDialog();
          
        }
    }
}
