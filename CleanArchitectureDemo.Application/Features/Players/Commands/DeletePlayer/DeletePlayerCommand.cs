using AutoMapper;

using CleanArchitectureDemo.Application.Common.Mappings;
using CleanArchitectureDemo.Application.Features.Players.Commands.UpdatePlayer;
using CleanArchitectureDemo.Application.Interfaces.Repositories;
using CleanArchitectureDemo.Domain.Entities;
using CleanArchitectureDemo.Shared;

using MediatR;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace CleanArchitectureDemo.Application.Features.Players.Commands.DeletePlayer
{
    public record DeletePlayerCommand : IRequest<Result<int>>, IMapFrom<Player>
    {
        public int Id { get; set; }

        public DeletePlayerCommand()
        {

        }

        public DeletePlayerCommand(int id)
        {
            Id = id; 
        }
    }

    internal class DeletePlayerCommandHandler : IRequestHandler<DeletePlayerCommand, Result<int>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public DeletePlayerCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Result<int>> Handle(DeletePlayerCommand command, CancellationToken cancellationToken)
        {
            var player = await _unitOfWork.Repository<Player>().GetByIdAsync(command.Id);
            if (player != null)
            {
                await _unitOfWork.Repository<Player>().DeleteAsync(player);
                player.AddDomainEvent(new PlayerDeletedEvent(player));

                await _unitOfWork.Save(cancellationToken);

                return await Result<int>.SuccessAsync(player.Id, "Product Deleted");
            }
            else
            {
                return await Result<int>.FailureAsync("Player Not Found.");
            }
        }
    }
}
