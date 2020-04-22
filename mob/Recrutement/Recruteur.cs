using System;

namespace Recrutement
{
    public class Recruteur
    {
        public Recruteur(string nom, string prenom, DateTime dateNaissance) {
            this.Nom = nom;
            this.Prenom = prenom;
            this.DateNaissance = dateNaissance;
        }

        public string Nom { get; private set; }
        public string Prenom { get; private set; }  
        public DateTime DateNaissance { get; private set; }
    }
}
