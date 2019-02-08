using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE___Gestion_de_formations
{
    class ComboValue
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ComboValue(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
