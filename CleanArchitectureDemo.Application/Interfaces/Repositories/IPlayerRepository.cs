using CleanArchitectureDemo.Domain.Entities;

namespace CleanArchitectureDemo.Application.Interfaces.Repositories
{
    public interface IPlayerRepository
    {
        Task<List<Player>> GetPlayersByClubAsync(int clubId);
    }
}
