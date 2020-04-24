using System;
using System.Collections.Generic;

namespace Recrutement {
    public class RecruteurAPI : IRecruteurAPI {
        private readonly List<RecruteurDTO> recruteurs = new List<RecruteurDTO>()
        {
            new RecruteurDTO("Pourtère", "Michel", "1978/05/22", 6, 8),
            new RecruteurDTO("Leleu", "Bernard", "1959/02/09", 1, 9),
            new RecruteurDTO("Filois", "Paul", "1999/23/04", 3, 13),
            new RecruteurDTO("Dujardin", "Renaud", "1995/02/14", 2, 11),
            new RecruteurDTO("Terrare", "Antoine", "1988/03/16", 5, 7)
        };
        public List<RecruteurDTO> GetAll() => this.recruteurs;
    }
}