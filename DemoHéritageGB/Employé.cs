using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoHéritageGB
{
   public class Employé : Personne
    {

        private int matricule;
        private double salaire;
        private int echelle;
        private string fonction;
        public int Matricule
        {
            get { return matricule; }
            set { matricule = value; }
        }
        public double Salaire
        {
            get { return salaire; }
            set { salaire = value; }
        }
        public int Echelle
        {
            get { return echelle; }
            set { echelle = value; }
        }
        public string Fonction
        {
            get { return fonction; }
            set { fonction = value; }
        }
        //constructeurs
        public Employé():base()
        {

        }

        public Employé(string nom, string prénom, string adresse, char genre, DateTime dateNaiss, int matricule, double salaire, int echelle, string fonction) : base(nom, prénom, dateNaiss, adresse,genre)
        {
            this.matricule = matricule;
            this.salaire = salaire;
            this.echelle = echelle;
            this.fonction = fonction;
        }
        public override string description()
        {
            return base.description()+"-"+  matricule + "-" + salaire + "-" + echelle + "-" + fonction;
        }
        public virtual double calculerSalaire()
        {
            return salaire;
        }
        public override string ToString()
        {
            return base.description() + "-" + matricule + "-" + salaire + "-" + echelle + "-" + fonction;
        }
    }
}
