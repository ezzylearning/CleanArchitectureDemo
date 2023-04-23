using CleanArchitectureDemo.Domain.Common;
using CleanArchitectureDemo.Domain.Entities;

namespace CleanArchitectureDemo.Application.Features.Players.Commands.UpdatePlayer
{
    public class PlayerUpdatedEvent : BaseEvent
    {
        public Player Player { get; }

        public PlayerUpdatedEvent(Player player)
        {
            Player = player;
        }
    }
}
