using BlazorServerCleanArchitecture.Domain.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorServerCleanArchitecture.Application.Interfaces.Repositories
{
    public interface IStadiumRepository
    {
        Task<List<Stadium>> GetStadiumByCityAsync(string cityName);
    }
}
