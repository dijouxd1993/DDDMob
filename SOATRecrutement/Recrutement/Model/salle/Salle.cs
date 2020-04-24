using System;

namespace Recrutement
{
    public class Salle
    {
        private string nom;
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public Salle(string nom)
        {
            this.Nom = nom;
        }
    }
}