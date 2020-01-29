using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpClasseCommande
{
   public class Produit
    {
        //Compteur d'objet:
        private static int cmp;
        public static int getCompteur() { return cmp; }
       
        //Attributs
        private int codePro;
        private string nomPro;
        private string description;
        private double pu;
        //accesseurs en lecteur
        public int getCode()
        {
            return codePro;
        }
        public string getNom() { return nomPro; }
        public string getDescription() { return description; }
        public double getPrixUnitaire() { return pu; }
        //Accesseurs en ecriture
        public void setCode(int codePro)
        {
            this.codePro = codePro;
        }
        public void setNom(string nom) { this.nomPro = nom; }
        public void setDescription(string desc) { this.description = desc; }
        public void setPrixU(double pu) { this.pu = pu; }
        //constructeurs
        public Produit()
        { 
            this.codePro = cmp;
            cmp++;
        }
        public Produit(string nomPro,string description,double pu)
        {
            this.codePro = cmp;
            cmp++;
            this.nomPro = nomPro;
            this.description = description;
            this.pu = pu;
        }
    }
}
