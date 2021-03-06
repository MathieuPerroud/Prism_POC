﻿using Prism_POC.Core.Repositories.Starships;
using Prism_POC.Model.Entities;
using System.Collections.Generic;

namespace Prism_POC.Core.UseCases.Starships
{
    public class GetAllStarshipsDroid: IGetAllStarships
    {
        private readonly IStarshipRepository starshipRepository;
        public GetAllStarshipsDroid(IStarshipRepository starshipRepository)
        {
            this.starshipRepository = starshipRepository;
        }

        public IEnumerable<Starship> Execute()
        {
            return starshipRepository.GetAllStarships();
        }
    }
}
