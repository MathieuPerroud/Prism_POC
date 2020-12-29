

using Prism_POC.Model.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Prism_POC.Core.Repositories.Starships
{
    public interface IStarshipRepository
    {
        ICollection<Starship> GetAllStarships();
    }
}
