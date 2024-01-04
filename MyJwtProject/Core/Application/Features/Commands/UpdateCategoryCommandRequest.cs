using MediatR;

namespace MyJwtProject.Core.Application.Features.Commands
{
	public class UpdateCategoryCommandRequest:IRequest
	{
		public int Id { get; set;}
		public string? Definition { get; set;}
	}
}
