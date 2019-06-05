using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPE___Gestion_de_formations
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]

        
     
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ConnexionForm form_de_connexion = new ConnexionForm();
            form_de_connexion.ShowDialog();
            if(form_de_connexion.DialogResult == DialogResult.OK)
            {
                form_de_connexion.Close();
                if (ConnexionForm.leUser.Type == 1)
                    Application.Run(new Form1());
                else if (ConnexionForm.leUser.Type == 2)
                    Application.Run(new FormGestio());
                else if (ConnexionForm.leUser.Type == 3)
                    Application.Run(new FormAdmin());
            }
            
        }
    }
}
