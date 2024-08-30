using AutoMapper;
using AutoMapper.QueryableExtensions;
using BlazorServerCleanArchitecture.Application.Interfaces.Repositories;
using BlazorServerCleanArchitecture.Domain.Common.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorServerCleanArchitecture.Application.Features.Stadiums.Queries.GetAllStadiums
{
    public record GetAllStadiumsQuery: IRequest<List<GetAllStadiumDto>>;

    internal class GetAllStadiumsQueryHandler : IRequestHandler<GetAllStadiumsQuery, List<GetAllStadiumDto>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetAllStadiumsQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<List<GetAllStadiumDto>> Handle(GetAllStadiumsQuery request, CancellationToken cancellationToken)
        {
            return await _unitOfWork.Repository<Stadium>().Entities
                .ProjectTo<GetAllStadiumDto>(_mapper.ConfigurationProvider) // to query only required columns on database
                .ToListAsync(cancellationToken);
        }
    }
}
