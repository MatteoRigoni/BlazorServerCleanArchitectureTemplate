using BlazorServerCleanArchitecture.Application.Interfaces.Repositories;
using BlazorServerCleanArchitecture.Domain.Common.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorServerCleanArchitecture.Persistance.Repositories
{
    public class StadiumRepository : IStadiumRepository
    {
        private readonly IGenericRepository<Stadium> _repository;

        public StadiumRepository(IGenericRepository<Stadium> repository)
        {
            _repository = repository;
        }

        public async Task<List<Stadium>> GetStadiumByCityAsync(string cityName)
        {
            return await _repository.Entities.Where(x => x.City == cityName).ToListAsync();
        }
    }
}
