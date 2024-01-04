using MediatR;

namespace MyJwtProject.Core.Application.Features.Commands
{
	public class CreateCategoryCommandRequest:IRequest
	{
		public string Definition { get; set; }
	}
}
