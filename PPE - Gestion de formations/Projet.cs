using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE___Gestion_de_formations
{
    public class Projet
    {
        // Instanciation des managers de classes métiers
        IncidentManager incidentManager = new IncidentManager();
        UtilisateurManager utilisateurManager = new UtilisateurManager();
        FormationManager formationManager = new FormationManager();
        SessionManager sessionManager = new SessionManager();
        ParticipantManager participantManager = new ParticipantManager();

        // Utilisateur connecté
        Utilisateur leUser;
    }
}
