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

        public void Save(Session formation)
        {

        }

        public void Delete(Session formation)
        {

        }

        public List<Session> getList(Formation la_formation)
        {
            string StrQuery = "SELECT id, date_debut, date_fin, lieu FROM session WHERE id_formation=@la_formation";
            var parameters = new DynamicParameters();
            parameters.Add("la_formation", la_formation.ID);
            DB.Open();
            List<Session> sessions =  DB.Query<Session>(StrQuery, parameters).ToList();
            DB.Close();
            return sessions;
        }
    }
}
