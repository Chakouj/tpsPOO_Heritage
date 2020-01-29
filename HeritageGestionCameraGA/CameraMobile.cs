using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeritageGestionCameraGA
{
    public class CameraMobile : Camera
    {
        private int abs;
        private int ord;
        public int Abs
        {
            get { return abs; }
            set { abs = value; }
        }
        public int Ord
        {
            get { return ord; }
            set { ord = value; }
        }

        public CameraMobile() : base()
        {

        }
        public CameraMobile(int code, string marque, int orientation, int ord, int abs) : base(code, marque, orientation)
        {
            this.abs = abs;
            this.ord = ord;
        }
        public void afficherPosition()
        {
            Console.WriteLine("Position du caméra:(abscisse,ordonné)= ({0},{1})", abs, ord);
        }

        public void avancer(int d)
        {
            switch (Orientation)
            {
                case 1: this.ord = this.ord + d;
                    break;
                case 2:this.abs = this.abs + d;
                    break;
                case 3:
                    this.ord = this.ord - d;
                    break;
                case 4:
                    this.abs = this.abs - d;
                    break;
                default: break;
            }
            
        }
        public override void afficher()
        {
            base.afficher();
            this.afficherPosition();
            
        }
    }
}
