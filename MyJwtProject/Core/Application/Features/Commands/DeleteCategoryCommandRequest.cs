using MediatR;

namespace MyJwtProject.Core.Application.Features.Commands
{
	public class DeleteCategoryCommandRequest:IRequest
	{
		public int Id { get; set;}

		public DeleteCategoryCommandRequest(int id)
		{
			Id = id;
		}
	}
}
