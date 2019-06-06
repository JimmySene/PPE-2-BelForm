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
        public string Login { get; set; }
        public string MotDePasse { get; set; }
        public int Type { get; set; }

        public Utilisateur(int id, string login, string mot_de_passe, int type)
        {
            ID = id;
            Login = login;
            MotDePasse = mot_de_passe;
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
