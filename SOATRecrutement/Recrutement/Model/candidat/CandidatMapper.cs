using System;
using System.Collections.Generic;

namespace Recrutement
{
    public class CandidatMapper
    {
        public List<Candidat> Map(List<CandidatDTO> candidats){
            foreach (CandidatDTO c in candidats)
            {
                yield return new Candidat(c.Nom,c.Prenom, stringToDate(c.DateNaissance),c.Competence, c.NbAnneesExp);
            }
        }

        private DateTime stringToDate(string input)
            => DateTime.Parse(input);


    }
}
