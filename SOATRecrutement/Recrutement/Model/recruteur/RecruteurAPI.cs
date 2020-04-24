using System;
using System.Collections.Generic;

namespace Recrutement {
    public class RecruteurAPI : IRecruteurAPI {
        private readonly List<RecruteurDTO> recruteurs = new List<RecruteurDTO>()
        {
            new RecruteurDTO("Pourtère", "Michel", new DateTime(1978, 5, 22), Competence.Java|Competence.JavaScript, 8),
            new RecruteurDTO("Leleu", "Bernard", new DateTime(1959, 2, 9), Competence.Java, 9),
            new RecruteurDTO("Filois", "Paul", new DateTime(1999, 23, 4), Competence.DotNet|Competence.JavaScript, 13),
            new RecruteurDTO("Dujardin", "Renaud", new DateTime(1995, 2, 14), Competence.DotNet, 11),
            new RecruteurDTO("Terrare", "Antoine", new DateTime(1988, 3, 16), Competence.JavaScript|Competence.DotNet, 7)
        };
        public static TousLesRecruteurs() => this.recruteurs;
    }
}