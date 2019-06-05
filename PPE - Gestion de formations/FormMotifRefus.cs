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
    public partial class FormMotifRefus : Form
    {
        Participant LeCandidat = null;
        Session LaSession = null;
        ParticipantManager participantManager = new ParticipantManager();
        public FormMotifRefus(Participant leCandidat, Session laSession)
        {
            InitializeComponent();
            LeCandidat = leCandidat;
            LaSession = laSession;
        }

        private void btn_motif_Click(object sender, EventArgs e)
        {
            participantManager.refuser(LeCandidat, LaSession, tb_motif.Text);
            MessageBox.Show("Le candidat a bien été refusé !");
            this.DialogResult = DialogResult.OK;
        }
    }
}
