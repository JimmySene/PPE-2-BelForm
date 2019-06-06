using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Dapper;

namespace PPE___Gestion_de_formations
{
    public partial class Form1 : Form
    {
        
        FormationManager formationManager = new FormationManager();
        List<Formation> formations = new List<Formation>();

        SessionManager sessionManager = new SessionManager();
        List<Session> sessions = new List<Session>();

        LieuManager lieuManager = new LieuManager();
        ParticipantManager participantManager = new ParticipantManager();

        ConnexionForm leFormDeConnexion = null;

        public Form1(ConnexionForm connexionForm)
        {
            InitializeComponent();

            leFormDeConnexion = connexionForm;

            // On récupère les formations
            formations = formationManager.getList();

            // On les affiche dans la ComboBox
            cb_formation.DataSource = formations;
            cb_formation.DisplayMember = "Nom";
            cb_formation.ValueMember = "ID";

        }

        private void cb_formation_SelectedIndexChanged(object sender, EventArgs e)
        {
            // On récupère la formation selectionnée
            Formation la_formation = (Formation)cb_formation.SelectedItem;
            
            // On récupère les sessions de la formation
            sessions = sessionManager.getList(la_formation);

            foreach(Session la_session in sessions)
            {
                la_session.LaFormation = la_formation;
                la_session.LeLieu = lieuManager.getLieu(la_session);
                la_session.LesPostulants = participantManager.getPostulants(la_session);
                la_session.LesInscrits = participantManager.getInscrits(la_session);
            }
           
            // On les affiche dans la datagrid
            dg_sessions.DataSource = sessions;

            dg_sessions.Columns["Id"].Visible = false;
            dg_sessions.Columns["DateDebut"].HeaderText = "Début";
            dg_sessions.Columns["DateFin"].HeaderText = "Fin";
            dg_sessions.Columns["MsgAnnulation"].Visible = false;
            dg_sessions.Columns["LaFormation"].Visible = false;
            dg_sessions.Columns["LeLieu"].Visible = false;
            dg_sessions.Columns["NomLieu"].HeaderText = "Lieu";
            dg_sessions.Columns["NbInscrits"].HeaderText = "Inscrits";


            dg_sessions.AutoSize = true;
        }

      

        private void link_incident_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormInsererIncident formInsererIncident = new FormInsererIncident();
            formInsererIncident.ShowDialog();
        }

        private void dg_sessions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void link_deconnexion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            leFormDeConnexion.Show();
            this.Close();
        }
    }
}
