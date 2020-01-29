using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpClasseCommande
{
    class Program
    {
        static void Main(string[] args)
        {    //a
            Produit[] tp = { new Produit("AAA", "DDDA", 490.5),
                     new Produit("BB", "DDDB", 12.5),
                     new Produit("CC", "DDDC", 23.5),
                     new Produit("DD", "DDD", 49)
            };
            //b
            Commande cmd = new Commande("Alaoui Saad", "Laayoune");
            DetailCommande[] detailsCmd = { new DetailCommande(cmd.Nc, tp[0].getCode(), 123)
                               , new DetailCommande(cmd.Nc, tp[1].getCode(), 222)};
            //Affichage:
            Console.WriteLine("Commande Num : " + cmd.Nc +" Date : "+cmd.DateCmd);
            Console.WriteLine("Detail commande:");
            foreach (DetailCommande item in detailsCmd)
            {
                Console.WriteLine(item.CodePro + "|" + item.Quntité);
            }
            //Calcule total
            double total = 0;
            foreach (DetailCommande d in detailsCmd)
            {
                double q = d.Quntité;
                int codeP = d.CodePro;
                foreach (Produit p in tp)
                {
                    if (p.getCode() == codeP)
                    {
                        double pu = p.getPrixUnitaire();
                        total = total + q * pu;
                    }
                }

            }
            Console.WriteLine("Total commande :" + total);

            Console.ReadKey();
        }


        }
    }

