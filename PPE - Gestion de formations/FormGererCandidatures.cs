using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPE___Gestion_de_formations
{
    public partial class FormGererCandidatures : Form
    {
        Session LaSession = null;
        ParticipantManager participantManager = new ParticipantManager();
        
        public FormGererCandidatures(Session laSession)
        {
            InitializeComponent();
            LaSession = laSession;
            lbl_session.Text = LaSession.StrSession();
            lbl_nb_inscrits.Text += LaSession.NbInscrits;

            raffraichir_dg();
        }

        private void FormGererCandidatures_Load(object sender, EventArgs e)
        {

        }

        private void raffraichir_dg() // Raffraichit les DataGridViews
        {

            
            dg_candidats.DataSource = participantManager.getPostulants(LaSession);
            dg_inscrits.DataSource = participantManager.getInscrits(LaSession);

            dg_candidats.Columns["Id"].Visible = false;
            dg_candidats.Columns["NomComplet"].Visible = false;
            dg_candidats.Columns["MotifRefus"].HeaderText = "Motif du refus";
            dg_candidats.Columns["Signature"].Visible = false;

            dg_inscrits.Columns["Id"].Visible = false;
            dg_inscrits.Columns["NomComplet"].Visible = false;
            dg_inscrits.Columns["MotifRefus"].Visible = false;
            dg_inscrits.Columns["Signature"].Visible = false;

        }

        private void btn_retirer_Click(object sender, EventArgs e)
        {
            if (dg_inscrits.CurrentRow != null)
            {
                Participant lInscrit = (Participant)dg_inscrits.CurrentRow.DataBoundItem;
                participantManager.desinscrire(lInscrit, LaSession);

                raffraichir_dg();
                lbl_nb_inscrits.Text = "Nombre d'inscrits : " + dg_inscrits.Rows.Count + " / " + LaSession.LeLieu.NbPlaces;
            }
        }

        private void btn_accepter_Click(object sender, EventArgs e)
        {
            if (dg_candidats.CurrentRow != null)
            {
                if (dg_inscrits.Rows.Count < LaSession.LeLieu.NbPlaces) // Si il y a assez de place, alors on autorise l'inscription et on créé la convocation
                {
                    Participant leCandidat = (Participant)dg_candidats.CurrentRow.DataBoundItem;
                    participantManager.inscrire(leCandidat, LaSession);

                    raffraichir_dg();
                    lbl_nb_inscrits.Text = "Nombre d'inscrits : " + dg_inscrits.Rows.Count + " / " + LaSession.LeLieu.NbPlaces;

                    string headerHtml = "<html>" +
                        "<head>" +
                        "<title>Convocation</title>" +
                        "<style>p{font-size:25px}</style>" +
                        "</head>" +
                        "<body>" +
                        "<p>";
                    string contentHtml = leCandidat.NomComplet + " est convié à se rendre à la session de formation \"" + LaSession.LaFormation.Nom + "\" se déroulant " + LaSession.StrSession();
                    string footerHtml = "</p></body></html>";
                    string documentHtml = headerHtml + contentHtml + footerHtml;

                    StreamWriter convocation = new StreamWriter(@"C:\Users\Jimmy\Documents\Dev\C#\PPE - Gestion de formations\PPE - Gestion de formations\Convocations\" + leCandidat.Nom + ".html");
                    convocation.Write(documentHtml);
                    MessageBox.Show("Une convocation a été éditée !", "ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    convocation.Close();
                }
                else
                    MessageBox.Show("Il n'y a pas assez de place !");
                
            }
        }

        private void btn_refuser_Click(object sender, EventArgs e)
        {
            
            if(dg_candidats.CurrentRow != null)
            {
                Participant leCandidat = (Participant)dg_candidats.CurrentRow.DataBoundItem;
                
                FormMotifRefus formMotifRefus = new FormMotifRefus(leCandidat, LaSession);
                formMotifRefus.ShowDialog();
                raffraichir_dg();
            }
            
        }
    }
}
