using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoHeritageGA
{
    class Program
    {
        static void Main(string[] args)
        {
            // Personne p = new Personne("Alaoui", "Fatima", "Laayoune", 'F', new DateTime(1980, 2,10)) ;
            //Console.WriteLine(p.description());
            Personne[] tp = new Personne[3];
            tp[0] = new Employé("Saadi", "Anas", 'M', "Laayoune", new DateTime(1989, 2, 23), 11, 10000, 10, "Comptable");
        
            tp[1] = new Responsable("Didi", "Zakaria", 'M', "Rabat", new DateTime(1983, 4, 12), 222, 12000, 11, "Manager", "chef de service operations", 2000) ;
            tp[2] = new Employé("Alami", "Mouhsin", 'M', "Fes", new DateTime(1989, 2, 23), 11, 11000, 10, "RH");
            Console.WriteLine("Les employés:");
            foreach (Personne item in tp)
            {
                if(item is Employé)
                Console.WriteLine(item);
            }
            
            
            Console.ReadKey();
        }
    }
}
