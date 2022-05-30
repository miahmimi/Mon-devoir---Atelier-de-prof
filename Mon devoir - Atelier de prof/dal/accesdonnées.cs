using Mon_devoir___Atelier_de_prof.connexion;
using Mon_devoir___Atelier_de_prof.modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace Mon_devoir___Atelier_de_prof.dal
{
    class accesdonnées
               
   {
        private static string connectionString = "server=localhost;user id=root;database=atelier2;SslMode=none";


        /// </summary>

        /// <summary>
        /// Controle si l'utillisateur a le droit de se connecter (nom, prénom, pwd est profil "admin")
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
       

        /// <summary>
        /// Récupère et retourne les développeurs provenant de la BDD
        /// </summary>
        /// <returns>liste des développeurs</returns>
        public static List<personnel> GetLesDeveloppeurs()
        {
            List<personnel> lespersonnels = new List<personnel>();
            string req = "select  idpersonnel , idservice,nom,prenomm,tel,mail from personnel";
           
            singleton curs = singleton.GetInstance(connectionString);
            curs.ReqSelect(req, null);
            while (curs.Read())
            {
                personnel developpeur = new personnel((int)curs.Field("idpersonnel"), (int)curs.Field("idservice"), (string)curs.Field("nom"), (string)curs.Field("prenom"), (string)curs.Field("tel"), (string)curs.Field("mail"));
                lespersonnels .Add(developpeur);
            }
            curs.Close();
            return lespersonnels ;
        }

        /// <summary>
        /// Récupère et retourne les profils provenant de la BDD
        /// </summary>
        /// <returns>liste des profils</returns>
        public static List<Profil> GetLesProfils()
        {
            List<Profil> lesProfils = new List<Profil>();
            string req = "select * from profil order by nom;";
            ConnexionBDD curs = ConnexionBDD.GetInstance(connectionString);
            curs.ReqSelect(req, null);
            while (curs.Read())
            {
                Profil profil = new Profil((int)curs.Field("idprofil"), (string)curs.Field("nom"));
                lesProfils.Add(profil);
            }
            curs.Close();
            return lesProfils;
        }



    }
}
