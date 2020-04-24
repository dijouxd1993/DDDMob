using System;
using System.Collections.Generic;

namespace Recrutement
{
    public class RecruteurMapper : IRecruteurMapper {
        public Recruteur RecruteurDTOToRecruteur(RecruteurDTO dto)
            => new Recruteur(dto.Nom, dto.Prenom, DateTime.Parse(dto.DateNaissance), (Competence)dto.Competence, dto.NbAnneesExp);
        public IEnumerator<Recruteur> RecruteurDTOsToRecruteurs(List<RecruteurDTO> dtos) {
            foreach (RecruteurDTO dto in dtos)
                yield return RecruteurDTOToRecruteur(dto);
        }
    }
}