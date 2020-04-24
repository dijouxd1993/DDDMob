using System;

namespace Recrutement
{
    public class CandidatDTO
    {
        public CandidatDTO(string nom, string prenom, string dateNaissance, int competence, int nbAnneesExp) {
            this.Nom = nom;
            this.Prenom = prenom;
            this.DateNaissance = dateNaissance;
            this.Competence = competence;
            this.NbAnneesExp = nbAnneesExp;
        }
        
        public string Nom { get; private set; }
        public string Prenom { get; private set; } 
        public string DateNaissance { get; private set; }
        public int Competence { get; set; }
        public int NbAnneesExp { get; private set; }
        
    }
}
