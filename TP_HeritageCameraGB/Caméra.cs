using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_HeritageCameraGB
{
  public  class Caméra
    {
        //attributs
        private int code;
        private string marque;
        protected int orientation;
       
        //constructeurs
        public Caméra()
        {

        }
        public Caméra(int code, string marque,int orientation)
        {
            this.code = code;
            this.marque = marque;
            this.orientation = orientation;
        }
        public Caméra(int code, string marque)
        {
            this.code = code;
            this.marque = marque;
           
        }
        public void tourner(int sens)
        {
            if(sens==1 ||sens==2 ||sens==3 ||sens==4)
            this.orientation = sens;

        }
        public virtual void afficher()
        {
            Console.WriteLine("Code :" + code + " Orientation :" + orientation);
        }
    }
}
