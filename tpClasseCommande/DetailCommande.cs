using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpClasseCommande
{
   public class DetailCommande
    {
        private int nc;
        
        public int Nc
        {
            set { this.nc = value; }
            get { return this.nc; }
        }
        private int codePro;
        public int CodePro
        {
            set { this.codePro = value; }
            get { return this.codePro; }
        }
        private double qte;
        public double Quntité
        {
            set { this.qte = value; }
            get { return this.qte; }
        }
        public DetailCommande()
        {

        }
        public DetailCommande(int nc, int codePro, double qte)
        {
            this.nc = nc;
            this.codePro = codePro;
            this.qte = qte;
        }
    }
}
