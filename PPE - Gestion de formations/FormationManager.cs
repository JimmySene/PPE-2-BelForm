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
            string StrQuery = "INSERT INTO formation(nom) VALUES(@nom)";

            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("nom", formation.Nom);
            DB.Open();
            DB.Query(StrQuery, parameters);
            DB.Close();
        }

        public void Delete(Formation formation)
        {
            string StrQuery = "DELETE FROM formation WHERE id = @id";
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("id", formation.ID);
            DB.Open();
            DB.Query(StrQuery, parameters);
            DB.Close();
        }

        public void Update(Formation formation)
        {
            string StrQuery = "UPDATE formation SET nom = @nom WHERE id = @id";
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("nom", formation.Nom);
            parameters.Add("id", formation.ID);
            DB.Open();
            DB.Query(StrQuery, parameters);
            DB.Close();
        }

        public List<Formation> getList()
        {
            string StrQuery = "SELECT Id, Nom FROM formation";
            
            DB.Open();
            List<Formation> formations = DB.Query<Formation>(StrQuery).ToList();
            DB.Close();

            return formations;
        }

      
    }
}
