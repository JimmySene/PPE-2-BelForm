using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PPE___Gestion_de_formations
{
    class IncidentManager
    {
        private MySqlConnection DB;
        public IncidentManager()
        {
            string StrConnection = @"SERVER=localhost;PORT=3306;DATABASE=gestion_formations;UID=root;PWD=;";
            DB = new MySqlConnection(StrConnection);
        }

        public void insertIncident(string lib, string message)
        {
            DateTime dateDuJour = DateTime.Now;
            string StrQuery = "INSERT INTO incident(lib, message, date_post, id_utilisateur) VALUES(@le_lib, @le_message, @la_date, @id_utilisateur)";

            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("le_lib", lib);
            parameters.Add("le_message", message);
            parameters.Add("la_date", dateDuJour);
            parameters.Add("id_utilisateur", ConnexionForm.leUser.ID);
            DB.Open();
            DB.Query(StrQuery, parameters);
            DB.Close();

        }

        public List<Incident> getIncidents()
        {
            string StrQuery = "SELECT * FROM incident";
            DB.Open();
            List<Incident> incidents = DB.Query<Incident>(StrQuery).ToList();
            DB.Close();

            return incidents;
        }

        public void modifIncident(Incident incident)
        {
            DateTime dateDuJour = DateTime.Now;
            string StrQuery = "UPDATE incident SET statut = @statut WHERE id = @id";

            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("id", incident.Id);
            parameters.Add("statut", incident.Statut);
           
            DB.Open();
            DB.Query(StrQuery, parameters);
            DB.Close();
        }
    }
}
