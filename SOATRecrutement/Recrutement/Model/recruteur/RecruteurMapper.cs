namespace Recrutement
{
    public class RecruteurMapper {
        public Recruteur RecruteurDTOToRecruteur(RecruteurDTO dto)
            => new Recruteur(dto.Nom, dto.Prenom, DateTime.Parse(dto.DateNaissance), (Competence)dto.Competence, dto.NbAnneesExp);
        public List<Recruteur> RecruteurDTOsToRecruteurs(List<RecruteurDTO> dtos)
            =>  dtos.Select(dtos => RecruteurDTOToRecruteur(dto))
    }
}