using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoHéritageGB
{
    class Program
    {
        static void Main(string[] args)
        {
            Personne p = new Personne("Daoudi","Fatima",new DateTime(1980,2,11),"Tantan",'F');
            //Console.WriteLine(p.description());

            Personne[] tp = new Personne[3];
                tp[0] = new Employé("Alami", "Saad", "Laayoune", 'M', new DateTime(1989, 3, 22), 1110, 10000, 10, "Comptable");
        
            tp[1] = new Responsable("Haasani", "Fatima", "Rabat", 'F', new DateTime(1989, 5, 22), 324, 11000, 11, "RH", "Chef de service", 2000);
            tp[2] = new Employé("Alaoui", "Ahmed", "Laayoune", 'M', new DateTime(1980, 3, 22), 1110, 12000, 10, "Logistique");

            foreach (Personne e in tp)
            {
                if(e is Responsable)
                Console.WriteLine(((Responsable)e).Intitule);
            }
            Console.ReadKey();
        }
    }
}
