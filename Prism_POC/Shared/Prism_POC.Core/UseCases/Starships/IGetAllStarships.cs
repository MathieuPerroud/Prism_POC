using Prism_POC.Core.Repositories.Starships;
using Prism_POC.Model.Entities;
using System.Collections.Generic;

namespace Prism_POC.Core.UseCases.Starships
{
    public interface IGetAllStarships : IUseCase<IEnumerable<Starship>>
    {

    }
}
