using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoHeritageGA
{
    public class Personne
    { //Attributs
        private string nom;
        private string prénom;
        private string adresse;
        private char genre;
        private DateTime dateNaiss;
        //Propriétés
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
        public Char Genre   
        {
            get { return genre; }
            set { genre = value; }
        }
        //Constructeur
        public Personne()
        {

        }

        public Personne(string nom, string prénom, string adresse, char genre, DateTime dateNaiss)
        {
            this.nom = nom;
            this.prénom = prénom;
            this.adresse = adresse;
            this.genre = genre;
            this.dateNaiss = dateNaiss;
        }
        public virtual string description()
        { string g = (genre == 'F') ? "Femme" : "Homme";
            return nom + "-" + prénom + "-" + dateNaiss.ToShortDateString() + "-" + adresse + "-" + g;
        }
        public override string ToString()
        {
            string g = (genre == 'F') ? "Femme" : "Homme";
            return nom + "-" + prénom + "-" + dateNaiss.ToShortDateString() + "-" + adresse + "-" + g;
        }
    }
}
