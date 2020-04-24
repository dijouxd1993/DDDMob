using System;
using System.Collections.Generic;

namespace Recrutement
{
    public class CandidatMapper : IcandidatMapper
    {
        public IEnumerator<Candidat> Map(List<CandidatDTO> candidats){
            foreach (CandidatDTO c in candidats)
            {
                yield return new Candidat(c.Nom,c.Prenom, stringToDate(c.DateNaissance),intToCompetence(c.Competence), c.NbAnneesExp);
            }
        }

        private DateTime stringToDate(string input)
            => DateTime.Parse(input);
        
        private Competence intToCompetence(int input)
            => (Competence)input;

    }
}
