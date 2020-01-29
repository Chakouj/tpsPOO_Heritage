using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classeCommandeGB
{
   public class Produit
    {
        private static int cmp = 1;
        public static int getCmp() { return cmp; }
        //attributs
        private  int codeP;
        private string nomP;
        private string description;
        private double pu;
        //accesseurs en lecture
        public int getCode()
        {
            return codeP;
        }
        public string getNom() { return nomP; }
        public string getDescription() { return description; }
        public double getPrixUnitaire() { return pu; }
        //accesseur en ecriture
        public void setCodePro(int codeP) {
            this.codeP = codeP;
        }
        public void setNom(string nom)
        {
            nomP = nom;
        }
        public void setDescription(string description)
        {
            this.description = description;
        }
        public void setPrixUnitaire(double pu)
        {
            this.pu = pu;
        }
        //constructeurs
        public Produit()
        {
            this.codeP = cmp;
            cmp++;
        }

        public Produit( string nomP, string description, double pu)
        {
            this.codeP = cmp;
            cmp++;
           
            this.nomP = nomP;
            this.description = description;
            this.pu = pu;
        }
    }
}
