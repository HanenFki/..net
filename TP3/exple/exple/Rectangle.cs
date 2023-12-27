using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exple
{
    internal class Rectangle
    {
        private double largeur, longeur, surface;
        public Rectangle(double largeur, double longeur)
        {
            this.largeur = largeur;
            this.longeur = longeur;
        }
        public double CalculeSurface(double largeur, double longeur)
        {
            return largeur * longeur;
        }
        public double GetLongeur()
        {
            return longeur;
        }
        public double GetLargeur()
        {
            return largeur;
        }
        public double GetSurface()
        {
            return largeur*longeur;
        }
        public void setLargeur(double largeur)
        {
            this.largeur = largeur;
        }
        public void setLongeur(double longeur)
        {
            this.longeur = longeur;
        }
    }
}
