using MediatR;

namespace MyJwtProject.Core.Application.Features.Commands
{
	public class DeleteProductCommandRequest:IRequest
	{
		public int Id { get; set; }

		public DeleteProductCommandRequest(int id) { 
			
			Id = id;
		}
	}
}
