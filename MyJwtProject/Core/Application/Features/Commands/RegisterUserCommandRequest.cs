using MediatR;

namespace MyJwtProject.Core.Application.Features.Commands
{
	public class RegisterUserCommandRequest:IRequest
	{
		public string? Username { get; set; }
		public string? Password { get; set; }
	}
}
