using AutoMapper;
using MediatR;
using MyJwtProject.Core.Application.Dtos;
using MyJwtProject.Core.Application.Features.Queries;
using MyJwtProject.Core.Application.Interfaces;
using MyJwtProject.Core.Domain;

namespace MyJwtProject.Core.Application.Features.Handlers
{
	public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQueryRequest, List<ProductListDto>>
	{
		private readonly IRepository<Product> repository;
		private readonly IMapper mapper;

		public GetAllProductsQueryHandler(IMapper mapper, IRepository<Product> repository)
		{
			this.mapper = mapper;
			this.repository = repository;
		}

		public async Task<List<ProductListDto>> Handle(GetAllProductsQueryRequest request, CancellationToken cancellationToken)
		{
			var data = await this.repository.GetAllAsync();
			return this.mapper.Map<List<ProductListDto>>(data);
		}
	}
}
