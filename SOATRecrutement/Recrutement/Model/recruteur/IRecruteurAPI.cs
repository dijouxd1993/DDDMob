using System.Collections.Generic;

namespace Recrutement
{
    public interface IRecruteurAPI {
        List<RecruteurDTO> GetAll();
    }
}
