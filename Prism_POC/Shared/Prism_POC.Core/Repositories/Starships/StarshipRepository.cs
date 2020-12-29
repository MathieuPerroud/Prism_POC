
using Prism_POC.Core.Sources;
using Prism_POC.Model.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Prism_POC.Core.Repositories.Starships
{
    public class StarshipRepository : IStarshipRepository
    {
        public ICollection<Starship> GetAllStarships()
        {
            SWAPI api = new SWAPI();
            return api.GetAllStarships();
        }

    }
}
