﻿using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyJwtProject.Core.Application.Features.Commands;
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
		[HttpGet("{id}")]
		public async Task<IActionResult> Get(int id)
		{
			var result = await this.mediator.Send(new GetProductQueryRequest(id));
			return result != null ? Ok(result) : NotFound();
		}
		[HttpDelete("{id}")]
		public async Task<IActionResult> Delete (int id)
		{
			 await this.mediator.Send(new DeleteProductCommandRequest(id));
			return NoContent();
		}
		[HttpPost]
		public async Task<IActionResult> Create(CreateProductCommandRequest request)
		{
			await this.mediator.Send(request);
			return Created("",request);
		}
	}
}
