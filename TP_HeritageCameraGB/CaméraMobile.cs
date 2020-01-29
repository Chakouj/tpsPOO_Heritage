using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_HeritageCameraGB
{
   public  class CaméraMobile : Caméra
    {
        private int abs;
        private int ord;
        public CaméraMobile():base()
        {

        }
        public CaméraMobile(int code,string marque,int abs,int ord) : base(code,marque)
        {
            this.abs = abs;
            this.ord = ord;
        }
        public void afficherPosition()
        {
            Console.WriteLine("Position du caméra : x={0} y={1}", abs, ord);
        }
        public void avancer(int d)
        {
            switch (orientation)
            {
                case 1: this.ord = this.ord + d;
                    break;
                case 2:this.abs += d;
                    break;
                case 3:
                    this.ord = this.ord - d;
                    break;
                case 4:
                    this.abs -= d;
                    break;
                default:
                    break;
            }
        }
        public override void afficher()
        {
            base.afficher();
            this.afficherPosition();
        }

    }
}
