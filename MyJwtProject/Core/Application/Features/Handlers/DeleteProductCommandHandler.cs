using AutoMapper;
using MediatR;
using MyJwtProject.Core.Application.Features.Commands;
using MyJwtProject.Core.Application.Interfaces;
using MyJwtProject.Core.Domain;

namespace MyJwtProject.Core.Application.Features.Handlers
{
	public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommandRequest>
	{
		private readonly IRepository<Product> repository;
		

		public DeleteProductCommandHandler( IRepository<Product> repository)
		{
			
			this.repository = repository;
		}

		public async Task<Unit> Handle(DeleteProductCommandRequest request, CancellationToken cancellationToken)
		{
			var deletedEntity = await this.repository.GetByIdAsync(request.Id) ;
			await repository.RemoveAsync(deletedEntity);
			return Unit.Value;
			
		}
	}
}
