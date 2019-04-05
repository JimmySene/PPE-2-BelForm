using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE___Gestion_de_formations
{
    public class Lieu
    {
        public int ID { get; set; }
        public string Nom { get; set; }
        public int NbPlaces { get; set; }

        public Lieu(int id, string nom, int nb_Places)
        {
            ID = id;
            Nom = nom;
            NbPlaces = nb_Places;
        }
    }
}
