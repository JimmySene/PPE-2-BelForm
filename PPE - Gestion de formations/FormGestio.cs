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
    public partial class FormGestio : Form
    {
        Formation laFormation = null;
        FormationManager formationManager = new FormationManager();
        List<Formation> lesFormations = new List<Formation>();
        List<Formation> lesFormations2 = new List<Formation>();

        SessionManager sessionManager = new SessionManager();
        List<Session> lesSessions = new List<Session>();

        LieuManager lieuManager = new LieuManager();
        ParticipantManager participantManager = new ParticipantManager();

        public FormGestio()
        {
            InitializeComponent();
            lesFormations = formationManager.getList();
            lesFormations2 = formationManager.getList();

            lb_formations.DataSource = lesFormations;
            lb_formations.DisplayMember = "Nom";
            lb_formations.ValueMember = "ID";

            cb_formations.DataSource = lesFormations2;
            cb_formations.DisplayMember = "Nom";
            cb_formations.ValueMember = "ID";
        }

        private void btn_ajout_participants_Click(object sender, EventArgs e)
        {
            List<Formation> lesFormationsSelect = new List<Formation>();

            foreach (Formation laFormation in lb_formations.SelectedItems)
            {
                lesFormationsSelect.Add(laFormation);
            }
            
            FormAjouterParticipant formAjouterParticipant = new FormAjouterParticipant(lesFormationsSelect);
            formAjouterParticipant.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Session> lesSessionsChoisies = new List<Session>();

            // NEED METTRE LES LIGNES SELECTIONNES DE LA DG DANS LA LISTE SESSION
            foreach (DataGridViewRow ligne in dg_sessions.SelectedRows)
            {
                Session la_session = (Session)ligne.DataBoundItem;
                lesSessionsChoisies.Add(la_session);
            }
            
            FormCandidaterParticipant formCandidater = new FormCandidaterParticipant(laFormation, lesSessionsChoisies);
            formCandidater.ShowDialog();
        }


        private void cb_formations_SelectedIndexChanged(object sender, EventArgs e)
        {
            laFormation = (Formation)cb_formations.SelectedItem;
            lesSessions = sessionManager.getActiveList(laFormation);

            foreach (Session la_session in lesSessions)
            {
                la_session.LaFormation = laFormation;
                la_session.LeLieu = lieuManager.getLieu(la_session);
                la_session.LesInscrits = participantManager.getInscrits(la_session);
            }

            dg_sessions.DataSource = lesSessions;
            dg_sessions.Columns["Id"].Visible = false;
            dg_sessions.Columns["DateDebut"].HeaderText = "Début";
            dg_sessions.Columns["DateFin"].HeaderText = "Fin";
            dg_sessions.Columns["MsgAnnulation"].Visible = false;
            dg_sessions.Columns["LaFormation"].Visible = false;
            dg_sessions.Columns["LeLieu"].Visible = false;
            dg_sessions.Columns["NomLieu"].HeaderText = "Lieu";
            dg_sessions.Columns["NomLieu"].DisplayIndex = 1;
            dg_sessions.Columns["NbInscrits"].HeaderText = "Inscrits";


            dg_sessions.AutoSize = true;

            
        }

        private void btn_sms_Click(object sender, EventArgs e)
        {
            FormEnvoieSMS formEnvoieSMS = new FormEnvoieSMS();
            formEnvoieSMS.ShowDialog();
        }
    }
}
