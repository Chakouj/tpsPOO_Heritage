using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_HeritageCameraGB
{
    class Program
    {
        static void Main(string[] args)
        {
            CaméraMobile cm = new CaméraMobile(1, "Canon", 0, 0);
            cm.afficher();
            //a
            cm.tourner(2);
            //b
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
