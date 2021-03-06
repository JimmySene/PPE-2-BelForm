﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

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
        public string NbInscrits
        {
            get
            {   if (LesInscrits != null)
                    return LesInscrits.Count() + " / " + LeLieu.NbPlaces;
                else
                    return "0 / " + LeLieu.NbPlaces;
            }
        }


        public Session(DateTime date_debut, DateTime date_fin, Lieu le_lieu, Formation la_formation)
        {
            DateDebut = date_debut;
            DateFin = date_fin;
            LeLieu = le_lieu;
            LaFormation = la_formation;
        }
        public Session(int id, DateTime date_Debut, DateTime date_Fin, string msg_annulation)
        {
            ID = id;
            DateDebut = date_Debut;
            DateFin = date_Fin;
            MsgAnnulation = msg_annulation;
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
            return "A " + LeLieu.Nom + " le " + DateDebut.ToString("d", CultureInfo.CreateSpecificCulture("fr-FR")) + " de " + DateDebut.Hour + ":" + DateDebut.Minute + " à " + DateFin.Hour + ":" + DateFin.Minute;
        }

        public void SetLesDates(DateTime dateDebut, DateTime dateFin)
        {
            DateDebut = dateDebut;
            DateFin = dateFin;
        }
    }
}
