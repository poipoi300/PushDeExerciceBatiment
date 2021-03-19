using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciceBatiment
{
    class Maison : Batiment
    {

        private int _nbChambres;

        public Maison(string adresse, int nbChambres) : base(adresse)
        {
            _nbChambres = nbChambres;
        }

        private void SetNbChambres(int nbChambres)
        {
            _nbChambres = nbChambres;
        }
        public int GetNbChambres()
        {
            return _nbChambres;
        }

        public override string ToString()
        {
            return base.ToString() + "Nombre de chambres: " + _nbChambres
                + "\n";
        }

    }
}
