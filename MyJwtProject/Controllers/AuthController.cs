﻿using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyJwtProject.Core.Application.Features.Commands;
using MyJwtProject.Core.Application.Features.Queries;
using MyJwtProject.Infrastracture.Tools;
using System.IdentityModel.Tokens.Jwt;

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
		[HttpPost("[action]")]
		public async Task<IActionResult> Login(CheckUserQueryRequest request)
		{
			var dto = await this.mediator.Send(request);
			if(dto.IsExist)
			{
				return Created("", JwtTokenGenerator.GenerateToken(dto));

			}
			else
			{
				return BadRequest("Kullanici adi veya şifre hatali");
			}
		}
	}
}
