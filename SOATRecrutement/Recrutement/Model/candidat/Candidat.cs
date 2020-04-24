using System;

namespace Recrutement
{
    public class Candidat
    {
        public Candidat(string nom, string prenom, DateTime dateNaissance, Competence competence, int nbAnneesExp) {
            this.Nom = nom;
            this.Prenom = prenom;
            this.DateNaissance = dateNaissance;
            this.Competence = competence;
            this.NbAnneesExp = nbAnneesExp;
        }
        
        public string Nom { get; private set; }
        public string Prenom { get; private set; } 
        public DateTime DateNaissance { get; private set; }
        public Competence Competence { get; set; }
        public int NbAnneesExp { get; private set; }
        
    }
}
