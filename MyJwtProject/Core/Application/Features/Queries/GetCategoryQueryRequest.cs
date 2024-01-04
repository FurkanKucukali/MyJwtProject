using MediatR;
using MyJwtProject.Core.Application.Dtos;

namespace MyJwtProject.Core.Application.Features.Queries
{
	public class GetCategoryQueryRequest:IRequest<CategoryListDto?>
	{
		public int Id { get; set; }
		public GetCategoryQueryRequest(int id )
		{
			Id = id;
		}
	}
}
