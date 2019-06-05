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
    public partial class FormGererSession : Form
    {
        List<Formation> listFormations = new List<Formation>();
        FormationManager formationManager = new FormationManager();

        List<Session> listSessions = new List<Session>();
        SessionManager sessionManager = new SessionManager();

        LieuManager lieuManager = new LieuManager();

        Session laSession = null;



        ParticipantManager participantManager = new ParticipantManager();
        public FormGererSession()
        {
            InitializeComponent();
        }

        private void FormGererSession_Load(object sender, EventArgs e)
        {
            listFormations = formationManager.getList();
            cb_formations.DataSource = listFormations;
            cb_formations.ValueMember = "ID";
            cb_formations.DisplayMember = "Nom";
        }

        private void cb_formations_SelectedIndexChanged(object sender, EventArgs e)
        {
            raffraichir_dg();
        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            FormAjouterSession formAjouterSession = new FormAjouterSession((Formation)cb_formations.SelectedItem);
            if(formAjouterSession.ShowDialog() == DialogResult.OK)
            {
                raffraichir_dg();
            }
        }

        private void raffraichir_dg() // Raffraichit la DataGridView des sessions de la formation selectionnée
        {
            Formation laFormation = (Formation)cb_formations.SelectedItem;
            listSessions = sessionManager.getList(laFormation);


            foreach (Session la_session in listSessions)
            {
                la_session.LaFormation = laFormation;
                la_session.LeLieu = lieuManager.getLieu(la_session);
                la_session.LesInscrits = participantManager.getInscrits(la_session);
            }

            // On les affiche dans la datagrid
            dg_sessions.DataSource = listSessions;

            dg_sessions.Columns["Id"].Visible = false;
            dg_sessions.Columns["DateDebut"].HeaderText = "Début";
            dg_sessions.Columns["DateFin"].HeaderText = "Fin";
            dg_sessions.Columns["MsgAnnulation"].HeaderText = "Annulation";
            dg_sessions.Columns["MsgAnnulation"].DisplayIndex = 7;
            dg_sessions.Columns["LaFormation"].Visible = false;
            dg_sessions.Columns["LeLieu"].Visible = false;
            dg_sessions.Columns["NomLieu"].HeaderText = "Lieu";
            dg_sessions.Columns["NomLieu"].DisplayIndex = 1;
            dg_sessions.Columns["NbInscrits"].HeaderText = "Inscrits";


            dg_sessions.AutoSize = true;
        }


        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            laSession = (Session)dg_sessions.CurrentRow.DataBoundItem;
            PromptForm pform = new PromptForm("Message d'anulation", "Entrez un message d'annulation : ");
            if(pform.ShowDialog() == DialogResult.OK)
            {
                laSession.MsgAnnulation = pform.getMessage();
                sessionManager.Delete(laSession);
                MessageBox.Show("Vous avez bien supprimé la session !");
                raffraichir_dg();
            }
            
        }

        private void btn_candidatures_Click(object sender, EventArgs e)
        {
            laSession = (Session)dg_sessions.CurrentRow.DataBoundItem;
            FormGererCandidatures formGererCandidatures = new FormGererCandidatures(laSession);
            formGererCandidatures.ShowDialog();
        }
    }
}
