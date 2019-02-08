using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace PPE___Gestion_de_formations
{
    public class ParticipantManager
    {
        private MySqlConnection DB;
        public ParticipantManager()
        {
            string StrConnection = @"SERVER=localhost;PORT=3306;DATABASE=gestion_formations;UID=root;PWD=;";
            DB = new MySqlConnection(StrConnection);
        }

        public List<Participant> getInscrits(Session la_session)
        {
            string StrQuery = "SELECT id, nom, prenom FROM participant, inscrit_session WHERE id = id_participant AND id_session = @session_id AND validation = 1";
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("session_id", la_session.ID);
            List<Participant> les_inscrits = DB.Query<Participant>(StrQuery, parameters).ToList();

            return les_inscrits;
        }

        public List<Participant> getPostulants(Session la_session)
        {
            string StrQuery = "SELECT id, nom, prenom FROM participant, inscrit_session WHERE id = id_participant AND id_session = @session_id AND validation = 0";
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("session_id", la_session.ID);
            List<Participant> les_postulants = DB.Query<Participant>(StrQuery, parameters).ToList();

            return les_postulants;
        }

    }
}
