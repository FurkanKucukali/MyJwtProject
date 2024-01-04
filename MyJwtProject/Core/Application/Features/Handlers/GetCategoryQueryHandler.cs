using AutoMapper;
using MediatR;
using MyJwtProject.Core.Application.Dtos;
using MyJwtProject.Core.Application.Features.Queries;
using MyJwtProject.Core.Application.Interfaces;
using MyJwtProject.Core.Domain;
using System.Transactions;

namespace MyJwtProject.Core.Application.Features.Handlers
{
	public class GetCategoryQueryHandler : IRequestHandler<GetCategoryQueryRequest, CategoryListDto>
	{
		private readonly IRepository<Category> repository;
		private readonly IMapper mapper;

		public GetCategoryQueryHandler(IRepository<Category> repository, IMapper mapper)
		{
			this.repository = repository;
			this.mapper = mapper;
		}

		public async Task<CategoryListDto> Handle(GetCategoryQueryRequest request, CancellationToken cancellationToken)
		{
			var data = await repository.GetByFilterAsync(x=>x.Id== request.Id);		
			return this.mapper.Map<CategoryListDto>(data);

		}
	}
}
