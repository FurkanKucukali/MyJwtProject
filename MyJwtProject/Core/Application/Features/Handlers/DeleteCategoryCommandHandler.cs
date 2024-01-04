using MediatR;
using MyJwtProject.Core.Application.Features.Commands;
using MyJwtProject.Core.Application.Interfaces;
using MyJwtProject.Core.Domain;

namespace MyJwtProject.Core.Application.Features.Handlers
{
	public class DeleteCategoryCommandHandler : IRequestHandler<DeleteCategoryCommandRequest>
	{
		private readonly IRepository<Category> repository;

		public DeleteCategoryCommandHandler(IRepository<Category> repository)
		{
			this.repository = repository;
		}

		public async Task<Unit> Handle(DeleteCategoryCommandRequest request, CancellationToken cancellationToken)
		{
			var deletedRepository = await repository.GetByIdAsync(request.Id);
			await repository.RemoveAsync(deletedRepository);
			return Unit.Value;
		}
	}
}
