﻿using AutoMapper;
using MediatR;
using MyJwtProject.Core.Application.Dtos;
using MyJwtProject.Core.Application.Features.Queries;
using MyJwtProject.Core.Application.Interfaces;
using MyJwtProject.Core.Domain;

namespace MyJwtProject.Core.Application.Features.Handlers
{
	public class GetProductQueryHandler : IRequestHandler<GetProductQueryRequest, ProductListDto>
	{
		private readonly IRepository<Product> repository;
		private readonly IMapper mapper;

		public GetProductQueryHandler(IRepository<Product> repository, IMapper mapper)
		{
			this.repository = repository;
			this.mapper = mapper;
		}


		public async Task<ProductListDto> Handle(GetProductQueryRequest request, CancellationToken cancellationToken)
		{
			var data = await this.repository.GetByFilterAsync(x => x.Id == request.Id); 
			return this.mapper.Map<ProductListDto>(data);
		}
	}
}
