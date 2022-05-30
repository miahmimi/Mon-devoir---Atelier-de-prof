using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mon_devoir___Atelier_de_prof.modele
{
    public class personnel
    {
        private int idpersonnel;
        private int idservice;
        private string nom;
        private string prenom;
        private string tel;
        private string mail;

        public int Idpersonnel { get => idpersonnel; }
        public string Nom { get => nom; }
        public string Prenom { get => prenom; }
        public string Tel { get => tel; }
        public string Mail { get => mail; }
        public int Idservice { get => idservice; }

        /// <summary>
        /// Constructeur : valorise les propriétés
        /// </summary>
        /// <param name="idpersonnel"></param>
        /// <param name="nom"></param>
        /// <param name="idservice"></param>
        /// <param name="tel"></param>
        /// <param name="mail"></param>
        /// <param name="prenom"></param>
       

        public personnel(int idpersonnel, int idservice, string nom, string prenom, string tel, string mail)
        {
            this.idpersonnel = idpersonnel;
            this.idservice = idservice;
            this.nom = nom;
            this.prenom = prenom;
            this.tel = tel;
            this.mail = mail;
        }
    }
}
