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
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void btn_incidents_Click(object sender, EventArgs e)
        {
            FormIncidents formIncident = new FormIncidents();
            formIncident.ShowDialog();
        }

        private void link_deconnexion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void btn_gerer_formations_Click(object sender, EventArgs e)
        {
            FormGererFormations formGererFormations = new FormGererFormations();
            formGererFormations.ShowDialog();
        }

        private void btn_gerer_sessions_Click(object sender, EventArgs e)
        {
            FormGererSession formGererSession = new FormGererSession();
            formGererSession.ShowDialog();
        }

    }
}
