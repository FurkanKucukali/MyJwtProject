using MediatR;
using MyJwtProject.Core.Application.Enums;
using MyJwtProject.Core.Application.Features.Commands;
using MyJwtProject.Core.Application.Interfaces;
using MyJwtProject.Core.Domain;

namespace MyJwtProject.Core.Application.Features.Handlers
{
	public class RegisterUserCommandHandler : IRequestHandler<RegisterUserCommandRequest>
	{
		private readonly IRepository<AppUser> repository;

		public RegisterUserCommandHandler(IRepository<AppUser> repository)
		{
			this.repository = repository;
		}

		public async Task<Unit> Handle(RegisterUserCommandRequest request, CancellationToken cancellationToken)
		{
			await repository.CreateAsync(new AppUser
			{
				Password = request.Password,
				Username = request.Username,
				AppRoleId = (int)RoleType.Member
			});
			return Unit.Value;
		}
	}
}
