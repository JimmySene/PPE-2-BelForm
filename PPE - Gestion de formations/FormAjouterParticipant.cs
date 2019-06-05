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
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace PPE___Gestion_de_formations
{
    public partial class FormAjouterParticipant : Form
    {
       
        List<Formation> LesFormations;
        
        ParticipantManager participantManager = new ParticipantManager();
        SessionManager sessionManager = new SessionManager();
        LieuManager lieuManager = new LieuManager();
        public FormAjouterParticipant(List<Formation> lesFormations)
        {
            InitializeComponent();
            LesFormations = lesFormations;
        }

        private void FormAjouterParticipant_Load(object sender, EventArgs e)
        {

        }

        private void btn_ajout_Click(object sender, EventArgs e)
        {
            Participant leParticipant = new Participant(tb_nom.Text,tb_prenom.Text,tb_adresse.Text,tb_ville.Text,tb_codepostal.Text,tb_email.Text,tb_mobile.Text);
            participantManager.insertParticipant(leParticipant, LesFormations);
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "PDF file|*.pdf", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    iTextSharp.text.Document doc = new iTextSharp.text.Document(PageSize.A4.Rotate());
                    try
                    {
                        PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                        doc.Open();
                        doc.Add(new iTextSharp.text.Paragraph(tb_nom.Text + " " + tb_prenom.Text + " peut participer aux sessions de formation suivantes :"));
                        foreach(Formation la_formation in LesFormations)
                        {
                            doc.Add(new iTextSharp.text.Paragraph("\n" + la_formation.Nom + " : "));
                            List<Session> les_sessions = sessionManager.getActiveList(la_formation);
                            if (les_sessions.Count == 0)
                                doc.Add(new iTextSharp.text.Phrase("\n Il n'y a aucune session disponible pour le moment."));
                            else
                            {
                                List list = new List();
                                foreach (Session la_session in les_sessions)
                                {
                                    la_session.LeLieu = lieuManager.getLieu(la_session);
                                    list.Add(la_session.StrSession());
                                }
                                doc.Add(list);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally
                    {
                        doc.Close();
                    }
                }
            }
            MessageBox.Show("Vous avez ajouté un nouveau participant !");
            this.DialogResult = DialogResult.OK;
        }
    }
}
