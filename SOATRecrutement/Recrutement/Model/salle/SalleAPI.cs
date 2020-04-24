using System;
using System.Collections.Generic;

namespace Recrutement {
    public class SalleAPI : ISalleAPI {
        private List<SalleDTO> salles = new List<SalleDTO>()
        {
            new SalleDTO("Salle François Mitterand"),
            new SalleDTO("Salle Jacques Chirac"),
            new SalleDTO("Salle Jean Gabin"),
            new SalleDTO("Salle Mireille Darc")
        };

        public List<SalleDTO> GetAll() => this.salles;
    }
}
