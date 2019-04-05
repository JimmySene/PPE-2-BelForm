using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE___Gestion_de_formations
{
    public class Utilisateur
    {
        public int ID { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Login { get; set; }
        public string MotDePasse { get; set; }
        public string Email { get; set; }
        public int Type { get; set; }

        public Utilisateur(int id, string nom, string prenom, string login, string mot_de_passe, string email, int type)
        {
            ID = id;
            Nom = nom;
            Prenom = prenom;
            Login = login;
            MotDePasse = mot_de_passe;
            Email = email;
            Type = type;
        }

        public string IntituleType()
        {
            switch (Type)
            {
                case 1:
                    return "Invite";
                case 2:
                    return "Gestionnaire";
                case 3:
                    return "Admin métier";
                default:
                    return "Invite";
            }
        }
    }
}
