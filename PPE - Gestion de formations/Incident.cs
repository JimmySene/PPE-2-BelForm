using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE___Gestion_de_formations
{
    public class Incident
    {
        public int Id { get; set; }
        public string Lib { get; set; }
        public string Message { get; set; }
        public int Statut { get; set; }
        public DateTime DatePost { get; set; }
        public DateTime DateTrait { get; set; }
        public DateTime DateReso { get; set; }
        public Utilisateur UtilisateurTicket { get; set; }
        public int IdUtilisateur { get; set; }

        public Incident(int id, string lib, string message, int statut, DateTime date_post, DateTime date_trait, DateTime date_reso, int id_utilisateur)
        {
            Id = id;
            Lib = lib;
            Message = message;
            Statut = statut;
            DatePost = date_post;
            DateTrait = date_trait;
            DateReso = date_reso;
            IdUtilisateur = id_utilisateur;
        }
    }
}
