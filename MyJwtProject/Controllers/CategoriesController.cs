using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyJwtProject.Core.Application.Features.Commands;
using MyJwtProject.Core.Application.Features.Handlers;
using MyJwtProject.Core.Application.Features.Queries;

namespace MyJwtProject.Controllers
{
	[Authorize(Roles = "Admin,Member")]
	[Route("api/[controller]")]
	[ApiController]
	public class CategoriesController:ControllerBase
	{
		private readonly IMediator mediator;

		public CategoriesController(IMediator mediator)
		{
			this.mediator = mediator;
		}

		[HttpGet]
		public async Task<IActionResult> List()
		{
			var result  = await this.mediator.Send(new GetCategoriesQueryRequest());
			return Ok(result);

		}
		[HttpGet("{id}")]
		public async Task<IActionResult> Get(int id)
		{
			var result = await mediator.Send(new GetCategoryQueryRequest(id));
			return result == null? NotFound() : Ok(result);
		}
		[HttpPost]
		public async Task<IActionResult> Create(CreateCategoryCommandRequest request)
		{
			await this.mediator.Send(request);
			return Created("", request);
		}
		[HttpPut]
		public async Task<IActionResult> Update(UpdateCategoryCommandRequest request)
		{
			var result = await this.mediator.Send(request);
			return Ok(result);
		}
		[HttpDelete]
		public async Task<IActionResult> Delete(DeleteCategoryCommandRequest request)
		{
			var result = await this.mediator.Send(request);
			return Ok(result);
		}

	}
}
