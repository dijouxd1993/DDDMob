using System.Collections.Generic;

namespace Recrutement
{
    public interface IRecruteurMapper {
        Recruteur RecruteurDTOToRecruteur(RecruteurDTO dto);
        IEnumerator<Recruteur> RecruteurDTOsToRecruteurs(List<RecruteurDTO> dtos);
    }
}