using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classeCommandeGB
{
    class Program
    {
        static void Main(string[] args)
        {
            Produit[] tp = { new Produit("HPProBook", "Pc prtable", 7800),
                          new Produit("Sony","Imprimante",1200),
                        new Produit("DEL","PC Bureu",4000) };
            Commande cmd = new Commande("Alaoui Hassan", "Laayoune");
            DetailCommande[] dt ={
                new DetailCommande(cmd.Nc, tp[0].getCode(), 123),
                new DetailCommande(cmd.Nc, tp[1].getCode(), 222) } ;

            //clacule total
            double total = 0;
            foreach (DetailCommande item in dt)
            {
                double qte = item.Quantité;
                int codeP = item.CodePro;
                foreach (Produit p in tp)
                {
                    if (p.getCode() == codeP)
                    {
                        double pu = p.getPrixUnitaire();
                        total = total + pu * qte;
                        break;
                    }
                   
                }
            }
            Console.WriteLine("Total : " + total + " DH");
        }
    }
}
