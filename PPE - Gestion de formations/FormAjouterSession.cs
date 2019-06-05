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
    public partial class FormAjouterSession : Form
    {
        List<Lieu> lesLieux = new List<Lieu>();
        LieuManager lieuManager = new LieuManager();
        SessionManager sessionManager = new SessionManager();
        Formation laFormation;
        public FormAjouterSession(Formation la_formation)
        {
            InitializeComponent();
            laFormation = la_formation;
        }

        private void FormAjouterSession_Load(object sender, EventArgs e)
        {
            lesLieux = lieuManager.getList();
            cb_lieux.DataSource = lesLieux;
            cb_lieux.ValueMember = "ID";
            cb_lieux.DisplayMember = "Nom";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(dt_debut.Value < dt_fin.Value)
            {
                if(dt_debut.Value.Date == dt_fin.Value.Date)
                {
                    Session nouvelleSession = new Session(dt_debut.Value, dt_fin.Value, (Lieu)cb_lieux.SelectedItem, laFormation);
                    sessionManager.Save(nouvelleSession);
                    MessageBox.Show("Vous avez ajouté une nouvelle session !");
                    this.DialogResult = DialogResult.OK;
                }
                else
                    MessageBox.Show("Une session doit se dérouler sur une même journée !");
            }
            else
                MessageBox.Show("La date de début doit être antérieure à la date de fin !");

        }
    }
}
