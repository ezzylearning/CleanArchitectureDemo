using AutoMapper;
using AutoMapper.QueryableExtensions;

using CleanArchitectureDemo.Application.Extensions;
using CleanArchitectureDemo.Application.Interfaces.Repositories;
using CleanArchitectureDemo.Domain.Entities;
using CleanArchitectureDemo.Shared;
using MediatR;

using Microsoft.EntityFrameworkCore; 

namespace CleanArchitectureDemo.Application.Features.Players.Queries.GetPlayersWithPagination
{
    public record GetPlayersByClubQuery : IRequest<Result<List<GetPlayersByClubDto>>>
    {
        public int ClubId { get; set; }

        public GetPlayersByClubQuery()
        {

        }

        public GetPlayersByClubQuery(int clubId)
        {
            ClubId = clubId;
        }
    }

    internal class GetPlayersByClubQueryHandler : IRequestHandler<GetPlayersByClubQuery, Result<List<GetPlayersByClubDto>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IPlayerRepository _playerRepository;
        private readonly IMapper _mapper;

        public GetPlayersByClubQueryHandler(IUnitOfWork unitOfWork, IPlayerRepository playerRepository, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _playerRepository = playerRepository;
            _mapper = mapper;
        }

        public async Task<Result<List<GetPlayersByClubDto>>> Handle(GetPlayersByClubQuery query, CancellationToken cancellationToken)
        {
            var entities = await _playerRepository.GetPlayersByClubAsync(query.ClubId);
            var players = _mapper.Map<List<GetPlayersByClubDto>>(entities);
            return await Result<List<GetPlayersByClubDto>>.SuccessAsync(players);
        }
    }
}
