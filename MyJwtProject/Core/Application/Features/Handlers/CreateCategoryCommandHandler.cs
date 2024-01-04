using MediatR;
using MyJwtProject.Core.Application.Features.Commands;
using MyJwtProject.Core.Application.Interfaces;
using MyJwtProject.Core.Domain;

namespace MyJwtProject.Core.Application.Features.Handlers
{
	public class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommandRequest>
	{
		private readonly IRepository<Category> repository;

		public CreateCategoryCommandHandler(IRepository<Category> repository)
		{
			this.repository = repository;
		}

		public async Task<Unit> Handle(CreateCategoryCommandRequest request, CancellationToken cancellationToken)
		{
			await repository.CreateAsync(new Category
			{
				Definition = request.Definition
			});
			return Unit.Value;
		}
	}
}
