using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeritageGestionCameraGA
{
    class Program
    {
        static void Main(string[] args)
        {
            CameraMobile cm = new CameraMobile(1, "Canon", 1, 10, 15);
            cm.afficher();
            //a-
            cm.tourner(2);
            //b-
            cm.tourner(4);
            cm.avancer(10);
            //c
            cm.tourner(1);
            cm.avancer(16);
            //d
            cm.tourner(2);
            cm.avancer(5);
            //e
            cm.tourner(1);
            cm.avancer(-12);
        }
    }
}
