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
        public List<Session> LesSessionsChoisies { get; set; }
        public List<Session> LesSessionsInscrites { get; set; }

        public Participant(int id, string nom, string prenom, List<Session> lesSessionsChoisies, List<Session> lesSessionsInscrites)
        {
            ID = id;
            Nom = nom;
            Prenom = prenom;
            LesSessionsChoisies = lesSessionsChoisies;
            LesSessionsInscrites = lesSessionsInscrites;

        }
        public Participant(int id, string nom, string prenom)
        {
            ID = id;
            Nom = nom;
            Prenom = prenom;
            LesSessionsChoisies = new List<Session>();
            LesSessionsInscrites = new List<Session>();
        }
        public string StrParticipant()
        {
            return Nom + " " + Prenom;
        }
    }
}
