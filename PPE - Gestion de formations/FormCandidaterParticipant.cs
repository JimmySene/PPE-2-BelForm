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
    public partial class FormCandidaterParticipant : Form
    {
        Formation LaFormation = null;
        List<Session> LesSessions = new List<Session>();
        ParticipantManager participantManager = new ParticipantManager();
        public FormCandidaterParticipant(Formation laFormation, List<Session> lesSessions)
        {
            InitializeComponent();
            LesSessions = lesSessions;
            LaFormation = laFormation;
            cb_participants.DataSource = participantManager.getInteresses(LaFormation);
            cb_participants.DisplayMember = "NomComplet";
            cb_participants.ValueMember = "ID";
        }

        private void cb_participants_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_candidater_Click(object sender, EventArgs e)
        {
            Participant le_participant = (Participant)cb_participants.SelectedItem;
            participantManager.insertPostulant(le_participant, LesSessions);
            MessageBox.Show("Vous avez ajouté une nouvelle candidature !");
            this.DialogResult = DialogResult.OK;
        }
    }
}
