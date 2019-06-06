using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE___Gestion_de_formations
{
    public class Participant
    {

        public int ID { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Adresse { get; set; }
        public string Ville { get; set; }
        public string CodePostal { get; set; }
        public string Email { get; set; }
        public string Tel { get; set; }

        public string NomComplet { get; set; } // Nom + Prénom

        public bool Signature { get; set; } // équivalent du champs validation de la table inscrit_session
        public string MotifRefus { get; set; } // équivalent du champs motif_refus de la table inscrit_session

        public List<Session> LesSessionsChoisies { get; set; }
        public List<Session> LesSessionsInscrites { get; set; }

       
        public Participant(int id, string nom, string prenom, string adresse, string ville, string code_postal, string email, string mobile, string motif_refus, bool signature)
        {
            ID = id;
            Nom = nom;
            Prenom = prenom;
            Adresse = adresse;
            Ville = ville;
            CodePostal = code_postal;
            Email = email;
            Tel = mobile;
            MotifRefus = motif_refus;
            LesSessionsChoisies = new List<Session>();
            LesSessionsInscrites = new List<Session>();
            Signature = signature;
        }
        public Participant(string nom, string prenom, string adresse, string ville, string code_postal, string email, string mobile)
        {
            Nom = nom;
            Prenom = prenom;
            Adresse = adresse;
            Ville = ville;
            CodePostal = code_postal;
            Email = email;
            Tel = mobile;
        }
        public Participant(int id, string nom, string prenom)
        {
            ID = id;
            Nom = nom;
            Prenom = prenom;
            LesSessionsChoisies = new List<Session>();
            LesSessionsInscrites = new List<Session>();
            NomComplet = StrParticipant();
        }
        public string StrParticipant() // Retourne le nom complet
        {
            return Nom + " " + Prenom;
        }

        public string AdresseComplete() // Retourne l'adresse complète
        {
            return Adresse + " " + Ville + " " + CodePostal;
        }
    }
}
