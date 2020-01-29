using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoHeritageGA
{
   public class Responsable : Employé
    {
        private string intituléResp;
        private double prime;
        public string IntituléResp
        {
            get { return intituléResp; }
            set { intituléResp = value; }
        }
        public double Prime
        {
            get { return prime; }
            set { prime = value; }
        }
        public Responsable()
        {

        }

        public Responsable(string nom, string prénom, char genre, string adresse, DateTime dateNaiss, int matricule, double salaire, int echelle, string fonction,string intituléResp, double prime):base(nom,prénom,genre,adresse,dateNaiss,matricule,salaire,echelle,fonction)
        {
            this.intituléResp = intituléResp;
            this.prime = prime;
        }
        
        public override string ToString()
        {
            return base.ToString()+"-"+intituléResp+"-"+prime;
        }
        public override double getSalaire()
        {
            return base.getSalaire()+prime;
        }
    }
}
