using MediatR;
using MyJwtProject.Core.Application.Dtos;

namespace MyJwtProject.Core.Application.Features.Queries
{
	public class GetProductQueryRequest:IRequest<ProductListDto>
	{
		public int Id { get; set; }

		public GetProductQueryRequest(int id)
		{
			Id = id;
		}
	}
}
