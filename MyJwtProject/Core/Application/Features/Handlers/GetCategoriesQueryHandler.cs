using AutoMapper;
using MediatR;
using MyJwtProject.Core.Application.Dtos;
using MyJwtProject.Core.Application.Features.Queries;
using MyJwtProject.Core.Application.Interfaces;
using MyJwtProject.Core.Domain;

namespace MyJwtProject.Core.Application.Features.Handlers
{
	public class GetCategoriesQueryHandler : IRequestHandler<GetCategoriesQueryRequest, List<CategoryListDto>>
	{
		private readonly IRepository<Category> repository;
		private readonly IMapper mapper;

		public GetCategoriesQueryHandler(IRepository<Category> repository, IMapper mapper)
		{
			this.repository = repository;
			this.mapper = mapper;
		}

		public async  Task<List<CategoryListDto>> Handle(GetCategoriesQueryRequest request, CancellationToken cancellationToken)
		{
			var data = await this.repository.GetAllAsync();
			return this.mapper.Map<List<CategoryListDto>>(data);
		}
	}
}
