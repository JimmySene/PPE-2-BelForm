using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE___Gestion_de_formations
{
    public class StatutIncident
    {
        public int ID { get; set; }
        public string Nom { get; set; }

        public StatutIncident(int id, string nom)
        {
            ID = id;
            Nom = nom;
        }
    }
}
