using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE___Gestion_de_formations
{
    public class SessionManager
    {
        private MySqlConnection DB;

        public SessionManager()
        {
            string StrConnection = @"SERVER=localhost;PORT=3306;DATABASE=gestion_formations;UID=root;PWD=;";
            DB = new MySqlConnection(StrConnection);
        }

        public void Save(Session laSession)
        {
            string StrQuery = "INSERT INTO session(date_debut, date_fin, id_lieu, id_formation) VALUES(@date_debut, @date_fin, @id_lieu, @id_formation)";
            var parameters = new DynamicParameters();
            parameters.Add("date_debut", laSession.DateDebut);
            parameters.Add("date_fin", laSession.DateFin);
            parameters.Add("id_lieu", laSession.LeLieu.ID);
            parameters.Add("id_formation", laSession.LaFormation.ID);
            DB.Open();
            DB.Query(StrQuery, parameters);
            DB.Close();
        }

        public void Delete(Session laSession)
        {
            string StrQuery = "UPDATE session SET msg_annulation = @msg_annulation WHERE id = @id_session";
            var parameters = new DynamicParameters();
            parameters.Add("msg_annulation", laSession.MsgAnnulation);
            parameters.Add("id_session", laSession.ID);
            DB.Open();
            DB.Query(StrQuery, parameters);
            DB.Close();
        }

        public List<Session> getList(Formation la_formation) // Retourne toutes les sessions
        {
            string StrQuery = "SELECT id, date_debut, date_fin, msg_annulation FROM session WHERE id_formation=@la_formation";
            var parameters = new DynamicParameters();
            parameters.Add("la_formation", la_formation.ID);
            DB.Open();
            List<Session> sessions =  DB.Query<Session>(StrQuery, parameters).ToList();
            DB.Close();
            return sessions;
        }

        public List<Session> getActiveList(Formation la_formation) // Retourne les sessions actives (non annulées)
        {
            string StrQuery = "SELECT id, date_debut, date_fin, msg_annulation FROM session WHERE id_formation=@la_formation AND msg_annulation is null AND date_debut >= NOW()";
            var parameters = new DynamicParameters();
            parameters.Add("la_formation", la_formation.ID);
            DB.Open();
            List<Session> sessions = DB.Query<Session>(StrQuery, parameters).ToList();
            DB.Close();
            return sessions;
        }
    }
}
