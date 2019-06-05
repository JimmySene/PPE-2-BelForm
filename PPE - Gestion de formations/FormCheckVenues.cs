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
    public partial class FormCheckVenues : Form
    {
        Session LaSession = null;
        ParticipantManager participantManager = new ParticipantManager();
        List<Participant> lesInscrits = new List<Participant>();
        public FormCheckVenues(Session la_session)
        {
            InitializeComponent();
            LaSession = la_session;
            lesInscrits = participantManager.getInscrits(LaSession);
            dg_signature.DataSource = lesInscrits;
            dg_signature.Columns["Id"].Visible = false;
            dg_signature.Columns["NomComplet"].Visible = false;
            dg_signature.Columns["MotifRefus"].Visible = false;
            dg_signature.Columns["Adresse"].Visible = false;
            dg_signature.Columns["CodePostal"].Visible = false;
            dg_signature.Columns["Ville"].Visible = false;
            dg_signature.Columns["Email"].Visible = false;
            dg_signature.Columns["Tel"].Visible = false;
            dg_signature.Columns["Nom"].ReadOnly = true;
            dg_signature.Columns["Prenom"].ReadOnly = true;
            dg_signature.Columns["Signature"].ReadOnly = false;
        }

        private void btn_signature_Click(object sender, EventArgs e)
        {
            participantManager.signer(lesInscrits, LaSession);
            this.DialogResult = DialogResult.OK;
        }
    }
}
