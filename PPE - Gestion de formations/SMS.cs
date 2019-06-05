using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PPE___Gestion_de_formations
{
    class SMS
    {
        public static void Send(string msg)
        {
            string numero = "0640126739";

            string sURL;
            sURL = "https://SMStoB.com/http.php?email=accueil@agecif.com&pass=ZJ3R2Z&numero=$$num$$&message=$$msg$$";
            sURL = sURL.Replace("$$num$$", numero);
            sURL = sURL.Replace("$$msg$$", msg);
            WebRequest wrGETURL = WebRequest.Create(sURL);
            WebResponse response = wrGETURL.GetResponse();
        }
    }
}
