using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE___Gestion_de_formations
{
    class UtilisateurManager
    {
        private MySqlConnection DB;
        public UtilisateurManager()
        {
            string StrConnection = @"SERVER=localhost;PORT=3306;DATABASE=gestion_formations;UID=root;PWD=;";
            DB = new MySqlConnection(StrConnection);
        }

        public Utilisateur Connexion(string login, string motDePasse)
        {
            var hash = SHA.GenerateSHA256String(motDePasse);
            string StrQuery = "SELECT * FROM utilisateur WHERE login = @login AND mot_de_passe = @mdp";
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("login", login);
            parameters.Add("mdp", hash);
            DB.Open();
            Utilisateur leUser = DB.Query<Utilisateur>(StrQuery, parameters).FirstOrDefault();
            DB.Close();

            return leUser;
        }

       
    }
}
