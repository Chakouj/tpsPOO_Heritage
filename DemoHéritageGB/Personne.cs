using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoHéritageGB
{
   public class Personne
    {
        //attributs
        private string nom;
        private string prénom;
        private DateTime dateNaiss;
        private string adresse;
        private char genre;
        //propriétés
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        public string Prénom
        {
            get { return prénom; }
            set { prénom = value; }
        }
        public string Adresse
        {
            get { return adresse; }
            set { adresse = value; }
        }
        public DateTime DateNaiss
        {
            get { return dateNaiss; }
            set { dateNaiss = value; }
        }
        public char Genre
        {
            get { return genre; }
            set { genre = value; }
        }
        //constructeurs
        public Personne()
        {

        }

        public Personne(string nom, string prénom, DateTime dateNaiss, string adresse, char genre)
        {
            this.nom = nom;
            this.prénom = prénom;
            this.dateNaiss = dateNaiss;
            this.adresse = adresse;
            this.genre = genre;
        }
        public virtual string description()
        { string g = (genre == 'F') ? "Femme" : "Homme";
            return nom + "-" + prénom + "-" + dateNaiss.ToShortDateString() + "-" + g + "-" + adresse;
        }
        public override string ToString()
        {
            string g = (genre == 'F') ? "Femme" : "Homme";
            return nom + "-" + prénom + "-" + dateNaiss.ToShortDateString() + "-" + g + "-" + adresse;
        }
    }
}
