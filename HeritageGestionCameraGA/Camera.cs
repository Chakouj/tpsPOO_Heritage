using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeritageGestionCameraGA
{
   public class Camera
    {
        //attributs
        private int code;
        private string marque;
        private int orientation;
        //Propriétés
        public int Code
        {
            get { return code; }
            set { code = value; }
        }
        public String Marque
        {
            get { return marque; }
            set { marque = value; }
        }
        public int Orientation
        {
            get { return orientation; }
            
        }
        //Constructeurs
        public Camera()
        {

        }
        public Camera(int code,string marque,int orientation)
        {
            this.code = code;
            this.marque = marque;
            this.orientation = orientation;

        }
         public void tourner(int sense)
        {
            if(sense==1 ||sense==2||sense==3 ||sense==4)
            this.orientation = sense;
        }
        public virtual void afficher()
        {
            Console.WriteLine("Code : "+code + "  Orientation :" + orientation);
        }

    }
}
