using MediatR;
using MyJwtProject.Core.Application.Dtos;

namespace MyJwtProject.Core.Application.Features.Queries
{
	public class GetCategoriesQueryRequest:IRequest<List<CategoryListDto>>
	{
	}
}
