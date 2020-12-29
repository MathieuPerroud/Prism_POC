using Prism_POC.Core.Repositories.Starships;
using Prism_POC.Model.Entities;
using System.Collections.Generic;

namespace Prism_POC.Core.UseCases.Starships
{
    public class GetAllStarships: IGetAllStarships
    {
        private readonly IStarshipRepository starshipRepository;
        public GetAllStarships(IStarshipRepository starshipRepository)
        {
            this.starshipRepository = starshipRepository;
        }

        public IEnumerable<Starship> Execute()
        {
            return starshipRepository.GetAllStarships();
        }
    }
}
