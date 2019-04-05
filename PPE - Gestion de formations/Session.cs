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
        public string MsgAnnulation { get; set; }
        public Lieu LeLieu { get; set; }
        public string NomLieu
        {
            get
            {
                return LeLieu.Nom;
            }
        }
        public Formation LaFormation { get; set; }
        public List<Participant> LesPostulants { get; set; }
        public List<Participant> LesInscrits { get; set; }

        
        public Session(int id, DateTime date_Debut, DateTime date_Fin)
        {
            ID = id;
            DateDebut = date_Debut;
            DateFin = date_Fin;
        }
        public Session(int id, DateTime dateDebut, DateTime dateFin, Lieu lieu, Formation laFormation, List<Participant> lesPostulants, List<Participant> lesInscrits)
        {
            ID = id;
            DateDebut = dateDebut;
            DateFin = dateFin;
            LeLieu = lieu;
            LaFormation = laFormation;
            LesPostulants = lesPostulants;
            LesInscrits = lesInscrits;
        }
    
        public string StrSession()
        {
            return ID + " " + DateDebut + " " + DateFin + " " + LeLieu.Nom;
        }

        public void SetLesDates(DateTime dateDebut, DateTime dateFin)
        {
            DateDebut = dateDebut;
            DateFin = dateFin;
        }
    }
}
