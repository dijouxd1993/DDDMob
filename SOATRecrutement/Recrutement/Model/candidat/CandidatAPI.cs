using System;
using System.Collections.Generic;

namespace Recrutement {
    public class CandidatAPI : ICandidatAPI {
        private List<CandidatDTO> candidats = new List<CandidatDTO>()
        {
            new CandidatDTO("Dupont", "Jean", "12/04/1996", 4, 2),
            new CandidatDTO("Harly", "Pierre", "24/01/1990", 1, 5),
            new CandidatDTO("Maghales", "Enzo", "03/10/1994", 7, 8),
            new CandidatDTO("Chatelain", "Gérard","17/02/74", 2, 1),
            new CandidatDTO("Mittel", "Henri", "09/09/91", 1, 4)
        };

        public List<CandidatDTO> GetAll() => this.candidats;
    }
}
