using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classeCommandeGB
{
   public class DetailCommande
    {
        private int numCmd;
        private int codePro;
        private double quantité;
        //propriétés
        public int NumCmd
        {
            get { return numCmd; }
            set { numCmd = value; }
        }
        public int CodePro
        {
            get { return codePro; }
            set { codePro = value; }
        }
        public double Quantité
        {
            get { return quantité; }
            set { quantité = value; }
        }
        public DetailCommande()
        {

        }

        public DetailCommande(int numCmd, int codePro, double quantité)
        {
            this.numCmd = numCmd;
            this.codePro = codePro;
            this.quantité = quantité;
        }
    }
}
