using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classeCommandeGB
{
    public class Commande
    {
        private static int cmp = 1;
        public static int Cmp
        {
            get { return cmp; }
        }
        //Attributs
        private int nc;
        private DateTime dateCmd;
        private string client;
        private string adresse;
        //Propriétés
        public int Nc
        {
            get { return nc; }
            
        }
        public string Client
        {
            get { return client; }
            set { client = value; }
        }
        public DateTime DateCmd
        {
            get { return dateCmd; }
            
        }
        public string Adresse
        {
            get { return adresse; }
            set { adresse = value; }
        }

        //Constructeurs
        public Commande()
        {
            this.dateCmd = DateTime.Now;
            this.nc = cmp;
            cmp++;
        }

        public Commande( string client, string adresse)
        {
            this.nc = cmp;
            cmp++;
            this.client = client;
            this.adresse = adresse;
            this.dateCmd = DateTime.Now;
        }
    }
}
