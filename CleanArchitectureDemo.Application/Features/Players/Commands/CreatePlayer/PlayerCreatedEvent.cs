using CleanArchitectureDemo.Domain.Common;
using CleanArchitectureDemo.Domain.Entities;

namespace CleanArchitectureDemo.Application.Features.Players.Commands.CreatePlayer
{
    public class PlayerCreatedEvent : BaseEvent
    {
        public Player Player { get; }

        public PlayerCreatedEvent(Player player)
        {
            Player = player;
        }
    }
}
