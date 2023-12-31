using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyJwtProject.Core.Application.Features.Queries;

namespace MyJwtProject.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductsController : ControllerBase
	{
		private readonly IMediator mediator;

		public ProductsController(IMediator mediator)
		{
			this.mediator = mediator;
		}
		[HttpGet]
		public async Task<IActionResult> List()
		{
			var result = await this.mediator.Send(new GetAllProductsQueryRequest());
			return Ok(result);
		}
	}
}
