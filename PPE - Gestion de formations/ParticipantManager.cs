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

        public List<Participant> getList() // Obtient et retourne tous les participants
        {
            string StrQuery = "SELECT id, nom, prenom FROM participant";
            return DB.Query<Participant>(StrQuery).ToList();
        }

        public List<Participant> getInscrits(Session la_session) // Obtient et retourne tous les inscrits à la session
        {
            string StrQuery = "SELECT id, nom, prenom, adresse, ville, code_postal, email, mobile, motif_refus, signature FROM participant, inscrit_session WHERE id = id_participant AND id_session = @session_id AND validation = 1";
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("session_id", la_session.ID);
            List<Participant> les_inscrits = DB.Query<Participant>(StrQuery, parameters).ToList();

            return les_inscrits;
        }

        public List<Participant> getPostulants(Session la_session) // Obtient et retourne tous les candidats en attente ou refusés à la session
        {
            string StrQuery = "SELECT id, nom, prenom, adresse, ville, code_postal, email, mobile, motif_refus, signature FROM participant, inscrit_session WHERE id = id_participant AND id_session = @session_id AND (validation = 0 OR validation = 2)";
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("session_id", la_session.ID);
            List<Participant> les_postulants = DB.Query<Participant>(StrQuery, parameters).ToList();

            return les_postulants;
        }

        public List<Participant> getInteresses(Formation la_formation) // Obtient et retourne tous les intéressés à la formation
        {
            string StrQuery = "SELECT id, nom, prenom FROM participant, interet_formation WHERE participant.id = interet_formation.id_participant AND id_formation = @idformation";
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("idformation", la_formation.ID);
            return DB.Query<Participant>(StrQuery, parameters).ToList();
        }

        public void insertParticipant(Participant le_participant, List<Formation> les_formations) // Ajoute un nouveau participant avec ses intérêts de formation
        {
            // On insère le participant en base
            string StrQuery = "INSERT INTO participant VALUES(null, @nom, @prenom, @adresse, @ville, @codepostal, @email, @mobile)";
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("nom", le_participant.Nom);
            parameters.Add("prenom", le_participant.Prenom);
            parameters.Add("adresse", le_participant.Adresse);
            parameters.Add("ville", le_participant.Ville);
            parameters.Add("codepostal", le_participant.CodePostal);
            parameters.Add("email", le_participant.Email);
            parameters.Add("mobile", le_participant.Tel);

            DB.Open();
            DB.Query(StrQuery, parameters);
            DB.Close();

            // On récupère l'id du dernier participant en base
            string StrQuery2 = "SELECT MAX(id) FROM participant";
            DB.Open();
            int id_participant = DB.Query<int>(StrQuery2).Single();
            DB.Close();

            // On insère son interêt aux formations désirées
            foreach (Formation la_formation in les_formations)
            {
                string StrQuery3 = "INSERT INTO interet_formation VALUES(@idparticipant, @idformation)";
                DynamicParameters parameters2 = new DynamicParameters();
                parameters2.Add("idparticipant", id_participant);
                parameters2.Add("idformation", la_formation.ID);
                DB.Open();
                DB.Query(StrQuery3, parameters2);
                DB.Close();
            }

        }

        public void insertPostulant(Participant leParticipant, List<Session> lesSessions) // Ajoute un nouveau candidat à une session
        {
            foreach (Session la_session in lesSessions)
            {
                string StrQuery = "INSERT INTO inscrit_session(id_session, id_participant) VALUES(@idsession, @idparticipant)";
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("idsession", la_session.ID);
                parameters.Add("idparticipant", leParticipant.ID);
                DB.Open();
                DB.Query(StrQuery, parameters);
                DB.Close();
            }
            
        }

        public void inscrire(Participant leParticipant, Session laSession) // Inscrit et valide un candidat à une session
        {
            string StrQuery = "UPDATE inscrit_session SET validation = 1, motif_refus = null WHERE id_participant = @idparticipant AND id_session = @idsession";
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("idparticipant", leParticipant.ID);
            parameters.Add("idsession", laSession.ID);
            DB.Open();
            DB.Query(StrQuery, parameters);
            DB.Close();
        }

        public void desinscrire(Participant leParticipant, Session laSession) // Desinscrit un candidat à une session
        {
            string StrQuery = "UPDATE inscrit_session SET validation = 0 WHERE id_participant = @idparticipant AND id_session = @idsession";
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("idparticipant", leParticipant.ID);
            parameters.Add("idsession", laSession.ID);
            DB.Open();
            DB.Query(StrQuery, parameters);
            DB.Close();
        }

        public void refuser(Participant leParticipant, Session laSession, string leMotifRefus) // Refuse un candodat à une session en précisant un motif
        {
            string StrQuery = "UPDATE inscrit_session SET validation = 2, motif_refus = @motifrefus WHERE id_participant = @idparticipant AND id_session = @idsession";
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("idparticipant", leParticipant.ID);
            parameters.Add("idsession", laSession.ID);
            parameters.Add("motifrefus", leMotifRefus);
            DB.Open();
            DB.Query(StrQuery, parameters);
            DB.Close();
        }

        public void signer(List<Participant> lesInscrits, Session laSession) // Valide la présence ou non des inscrits à la session
        {
           foreach(Participant le_participant in lesInscrits)
            {
                string StrQuery = "UPDATE inscrit_session SET signature = @signature WHERE id_participant = @idparticipant AND id_session = @idsession";
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("idparticipant", le_participant.ID);
                parameters.Add("idsession", laSession.ID);
                parameters.Add("signature", le_participant.Signature);
                DB.Open();
                DB.Query(StrQuery, parameters);
                DB.Close();
            }
        }

    }
}
