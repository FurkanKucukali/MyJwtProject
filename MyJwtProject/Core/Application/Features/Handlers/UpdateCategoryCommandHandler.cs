using MediatR;
using MyJwtProject.Core.Application.Features.Commands;
using MyJwtProject.Core.Application.Interfaces;
using MyJwtProject.Core.Domain;

namespace MyJwtProject.Core.Application.Features.Handlers
{
	public class UpdateCategoryCommandHandler:IRequestHandler<UpdateCategoryCommandRequest>
	{
		private readonly IRepository<Category> repository;

		public UpdateCategoryCommandHandler(IRepository<Category> repository)
		{
			this.repository = repository;
		}

		public async Task<Unit> Handle(UpdateCategoryCommandRequest request, CancellationToken cancellationToken)
		{
			var updatedcategory = await repository.GetByIdAsync(request.Id);

			if (updatedcategory != null) {
				updatedcategory.Definition = request.Definition;
				await repository.UpdateAsync(updatedcategory);
			}
			return Unit.Value;
		}
	}
}
