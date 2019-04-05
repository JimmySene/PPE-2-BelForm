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
    public partial class FormGererFormations : Form
    {
        FormationManager formationManager = new FormationManager();
        List<Formation> listFormationsModif = new List<Formation>();
        List<Formation> listFormationsSup = new List<Formation>();
        public FormGererFormations()
        {
            InitializeComponent();
            /*
            listFormationsModif = formationManager.getList();
            listFormationsSup = formationManager.getList();

            cb_modifier_formation.DataSource = listFormationsModif;
            cb_supprimer_formation.DataSource = listFormationsSup;

            cb_modifier_formation.ValueMember = "ID";
            cb_modifier_formation.DisplayMember = "Nom";
            cb_supprimer_formation.ValueMember = "ID";
            cb_supprimer_formation.DisplayMember = "Nom";
            */
            rafraichirCombo(cb_modifier_formation);
            rafraichirCombo(cb_supprimer_formation);

        }

        private void rafraichirCombo(ComboBox cb)
        {
            List<Formation> lesFormations = new List<Formation>();
            lesFormations = formationManager.getList();
            cb.DataSource = lesFormations;
            cb.ValueMember = "ID";
            cb.DisplayMember = "Nom";
        }
        private void btn_ajouter_formation_Click(object sender, EventArgs e)
        {
           
            if(tb_nom_formation.Text != "")
            {
                Formation nouvelleFormation = new Formation(tb_nom_formation.Text);
                formationManager.Save(nouvelleFormation);

                MessageBox.Show("Vous avez ajouté une nouvelle formation !");

                rafraichirCombo(cb_modifier_formation);
                rafraichirCombo(cb_supprimer_formation);

                tb_nom_formation.Clear();
            }
            
        }

        private void cb_supprimer_formation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_supprimer_formation_Click(object sender, EventArgs e)
        {
            Formation laFormation = (Formation)cb_supprimer_formation.SelectedItem;
            formationManager.Delete(laFormation);

            MessageBox.Show("Vous avez supprimé la formation !");

            rafraichirCombo(cb_supprimer_formation);
            rafraichirCombo(cb_modifier_formation);
        }

        private void btn_modifier_formation_Click(object sender, EventArgs e)
        {
            Formation laFormation = (Formation)cb_modifier_formation.SelectedItem;
            if(tb_nom_formation_modif.Text != "")
            {
                laFormation.Nom = tb_nom_formation_modif.Text;
                formationManager.Update(laFormation);

                MessageBox.Show("La formation a bien été modifiée !");

                rafraichirCombo(cb_modifier_formation);
                rafraichirCombo(cb_supprimer_formation);

                tb_nom_formation_modif.Clear();
            }
        }
    }
}
