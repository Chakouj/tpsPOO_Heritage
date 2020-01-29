using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoHéritageGB
{
  public  class Responsable :Employé
    {
        private string intitulé;
        private double prime;

        public string Intitule
        {
            get { return intitulé; }
            set { intitulé = value; }
        }
        public double Prime
        {
            get { return prime; }
            set { prime = value; }
        }
        public Responsable()
        {

        }

        public Responsable(string nom, string prénom, string adresse, char genre, DateTime dateNaiss, int matricule, double salaire, int echelle, string fonction, string intitulé, double prime) : base(nom, prénom,  adresse, genre,dateNaiss,matricule,salaire,echelle,fonction)
        {
            this.intitulé = intitulé;
            this.prime = prime;
        }
        public override string description()
        {
            return base.description()+"-"+intitulé+"-"+prime;
        }
        public override double calculerSalaire()
        {
            return base.calculerSalaire()+prime;
        }
        public override string ToString()
        {
            return base.description() + "-" + intitulé + "-" + prime;
        }
    }
}
