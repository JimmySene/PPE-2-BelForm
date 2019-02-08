using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Dapper;

namespace PPE___Gestion_de_formations
{
    public class Formation
    {
        public int ID { get; set; }
        public string Nom { get; set; }
        public int Niveau { get; set; }
        public Formation(int id, string nom, int niveau)
        {
            ID = id;
            Nom = nom;
            Niveau = niveau;
        }
        public Formation(int id, string nom)
        {
            ID = id;
            Nom = nom;
        }
        public string StrFormation()
        {
            return Nom + " : " + Niveau;
        }

    }
}
