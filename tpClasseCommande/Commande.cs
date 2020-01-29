using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpClasseCommande
{
   public class Commande
    {
        private static int cmp;
        public static int Cmp { get { return cmp; } }
        //attributs
        private int nc;
        private string client;
        private string adresse;
        private DateTime dateC;
        //Propriétés
        public int Nc { 
            
            get { return this.nc; }
        }
        public string Client
        {
            get { return client; }
            set { client = value; }
        }
        public string Adresse
        {
            get { return adresse; }
            set { adresse = value; }
        }
        public DateTime DateCmd
        {
            get { return dateC; }
        }

        public Commande()
        {
            this.nc = cmp;
            cmp++;
            this.dateC = DateTime.Now;
        }

        public Commande(string client, string adresse)
        {
            this.nc = cmp;
            cmp++;
            this.dateC = DateTime.Now;
            this.client = client;
            this.adresse = adresse;
        }
    }
}

