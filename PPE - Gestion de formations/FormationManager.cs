using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE___Gestion_de_formations
{
    public class FormationManager
    {
        private MySqlConnection DB { get; set; }

        public FormationManager()
        {
            string StrConnection = @"SERVER=localhost;PORT=3306;DATABASE=gestion_formations;UID=root;PWD=;";
            DB = new MySqlConnection(StrConnection);
        }

        public void Save(Formation formation)
        {
            
        }

        public void Delete(Formation formation)
        {

        }

        public List<Formation> getList()
        {
            string StrQuery = "SELECT Id, Nom, Niveau FROM formation";
            
            DB.Open();
            List<Formation> formations = DB.Query<Formation>(StrQuery).ToList();
            DB.Close();

            return formations;
        }

      
    }
}
