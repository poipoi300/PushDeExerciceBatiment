using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciceBatiment
{
    class Entrepot : Batiment
    {
        private string _typeRevetement;
        private int _quaisDeChargement;

        public Entrepot(string adresse, string typeRevetement, int quaisDeChargement) : base(adresse)
        {
            _typeRevetement = typeRevetement;
            _quaisDeChargement = quaisDeChargement;
        }

        private void SetTypeRevetement(string typeRevetement)
        {
            _typeRevetement = typeRevetement;
        }
        public string GetTypeRevetement()
        {
            return _typeRevetement;
        }

        private void SetQuaisDeChargement(int quaisDeChargement)
        {
            _quaisDeChargement = quaisDeChargement;
        }
        public int GetQuaisDeChargement()
        {
            return _quaisDeChargement;
        }

        public override string ToString()
        {
            return base.ToString() + "Type de revetement: " + _typeRevetement + "\n"
            + "Nombre de quais de chargement: " + GetQuaisDeChargement() + "\n";
        }
    }
}
