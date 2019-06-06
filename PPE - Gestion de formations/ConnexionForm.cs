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
    public partial class ConnexionForm : Form
    {
        UtilisateurManager utilisateurManager = new UtilisateurManager();
        public static Utilisateur leUser;
        public ConnexionForm()
        {
            InitializeComponent();
        }

        private void btn_connexion_Click(object sender, EventArgs e)
        {
            
            leUser = utilisateurManager.Connexion(tb_login.Text, tb_mdp.Text);
            if(leUser != null)
            {
                
                if (leUser.Type == 1)
                    new Form1(this).Show();
                else if (leUser.Type == 2)
                    new FormGestio(this).Show();
                else if (leUser.Type == 3)
                   new FormAdmin(this).Show();
                this.Hide();
            }
                          
        }
    }
}
