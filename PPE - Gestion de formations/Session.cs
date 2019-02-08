using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE___Gestion_de_formations
{
    public class Session
    {
        public int ID { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        public string Lieu { get; set; }
        public Formation LaFormation { get; set; }
        public List<Participant> LesPostulants { get; set; }
        public List<Participant> LesInscrits { get; set; }

        
        public Session(int id, DateTime date_Debut, DateTime date_Fin, string lieu)
        {
            ID = id;
            DateDebut = date_Debut;
            DateFin = date_Fin;
            Lieu = lieu;
        }
        public Session(int id, DateTime dateDebut, DateTime dateFin, string lieu, Formation laFormation, List<Participant> lesPostulants, List<Participant> lesInscrits)
        {
            ID = id;
            DateDebut = dateDebut;
            DateFin = dateFin;
            Lieu = lieu;
            LaFormation = laFormation;
            LesPostulants = lesPostulants;
            LesInscrits = lesInscrits;
        }
    
        public string StrSession()
        {
            return ID + " " + DateDebut + " " + DateFin + " " + Lieu;
        }

        public void SetLesDates(DateTime dateDebut, DateTime dateFin)
        {
            DateDebut = dateDebut;
            DateFin = dateFin;
        }
    }
}
