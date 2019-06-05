using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE___Gestion_de_formations
{
    class LieuManager
    {
        private MySqlConnection DB;
        public LieuManager()
        {
            string StrConnection = @"SERVER=localhost;PORT=3306;DATABASE=gestion_formations;UID=root;PWD=;";
            DB = new MySqlConnection(StrConnection);
        }

        public Lieu getLieu(Session laSession)
        {
            string StrQuery = "SELECT * FROM lieu WHERE id IN (SELECT id_lieu FROM session WHERE id = @id_session)";
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("id_session", laSession.ID);
            DB.Open();
            Lieu leLieu = DB.Query<Lieu>(StrQuery, parameters).Single();
            DB.Close();

            return leLieu;
        }

        public List<Lieu> getList()
        {
            string StrQuery = "SELECT * FROM lieu";
            DB.Open();
            List<Lieu> lesLieux = DB.Query<Lieu>(StrQuery).ToList();
            DB.Close();

            return lesLieux;
        }
    }
}
