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
    public partial class Form2 : Form
    {
        ParticipantManager participantManager = new ParticipantManager();
        List<Participant> les_inscrits = new List<Participant>();
        List<Participant> les_postulants = new List<Participant>();

        public Form2(Session la_session)
        {
            InitializeComponent();
            dtp_datedebut.Text = la_session.DateDebut.ToString();
            dtp_datefin.Text = la_session.DateFin.ToString();
            lbl_formation.Text += " " + la_session.LaFormation.Nom;

            les_inscrits = participantManager.getInscrits(la_session);
            les_postulants = participantManager.getPostulants(la_session);

            dg_inscrits.DataSource = les_inscrits;
            dg_postulants.DataSource = les_postulants;

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_inscrire_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dg_postulants.SelectedRows)
            {
                Participant le_participant = (Participant)row.DataBoundItem;
                les_inscrits.Add(le_participant);
                les_postulants.Remove(le_participant);
            }

            dg_inscrits.DataSource = null;
            dg_inscrits.DataSource = les_inscrits;

            dg_postulants.DataSource = null;
            dg_postulants.DataSource = les_postulants;
        }

        private void btn_desinscrire_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in dg_inscrits.SelectedRows)
            {
                Participant le_participant = (Participant)row.DataBoundItem;
                les_postulants.Add(le_participant);
                les_inscrits.Remove(le_participant);
            }
            

            dg_inscrits.DataSource = null;
            dg_inscrits.DataSource = les_inscrits;

            dg_postulants.DataSource = null;
            dg_postulants.DataSource = les_postulants;
        }
    }
}
