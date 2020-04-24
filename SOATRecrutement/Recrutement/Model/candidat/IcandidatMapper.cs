using System.Collections.Generic;

namespace Recrutement
{
    public interface IcandidatMapper
    {
        IEnumerator<Candidat> Map(List<CandidatDTO> candidats);
    }
}