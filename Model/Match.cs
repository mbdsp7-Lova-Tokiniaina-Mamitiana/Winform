using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winform.Model
{
    class Match
    {
        private Equipe domicile, exterieur;
        private double localistionX, localisationY;
        private string description;

        public double LocalistionX { get => localistionX; set => localistionX = value; }
        public double LocalisationY { get => localisationY; set => localisationY = value; }
        public string Description { get => description; set => description = value; }
        internal Equipe Domicile { get => domicile; set => domicile = value; }
        internal Equipe Exterieur { get => exterieur; set => exterieur = value; }
    }
}
