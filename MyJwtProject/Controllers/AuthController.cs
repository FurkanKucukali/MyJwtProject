using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyJwtProject.Core.Application.Features.Commands;

namespace MyJwtProject.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AuthController : ControllerBase
	{
		private readonly IMediator mediator;

		public AuthController(IMediator mediator)
		{
			this.mediator = mediator;
		}

		[HttpPost("Register")]
		public async Task<IActionResult> Register (RegisterUserCommandRequest request)
		{
			await this.mediator.Send(request);
			return Created("",request);
		}
	}
}
