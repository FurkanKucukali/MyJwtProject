using MediatR;
using MyJwtProject.Core.Application.Features.Commands;
using MyJwtProject.Core.Application.Interfaces;
using MyJwtProject.Core.Domain;

namespace MyJwtProject.Core.Application.Features.Handlers
{
	public class CreateProductCommandHandler : IRequestHandler<CreateProductCommandRequest>
	{
		private readonly IRepository<Product> repository;

		public CreateProductCommandHandler(IRepository<Product> repository)
		{
			this.repository = repository;
		}

		public async Task<Unit> Handle(CreateProductCommandRequest request, CancellationToken cancellationToken)
		{
			await this.repository.CreateAsync(new Product
			{
				CategoryId= request.CategoryId,
				Name= request.Name,
				Price= request.Price,
				Stock= request.Stock,
			});
			return Unit.Value;
		}
	}
}
