using CleanArchitectureDemo.Domain.Common;
using CleanArchitectureDemo.Domain.Entities;

namespace CleanArchitectureDemo.Application.Features.Players.Commands.DeletePlayer
{
    public class PlayerDeletedEvent : BaseEvent
    {
        public Player Player { get; }

        public PlayerDeletedEvent(Player player)
        {
            Player = player;
        }
    }
}
