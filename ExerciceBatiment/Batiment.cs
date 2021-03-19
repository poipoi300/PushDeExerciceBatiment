using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciceBatiment
{
    class Batiment
    {
        int _numero;
        string _adresse;

        public Batiment()
        {

        }
        public Batiment(string adresse)
        {
            _adresse = adresse;
        }

        private void SetAdresse(string adresse)
        {
            _adresse = adresse;
        }

        public string GetAdresse()
        {
            return _adresse;
        }

        public override string ToString()
        {
            string txt = "";
            txt += "L'adresse du batiment: " + _adresse + "\n";
            return txt;
        }

    }
}
