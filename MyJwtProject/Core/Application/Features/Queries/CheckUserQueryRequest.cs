using MediatR;
using MyJwtProject.Core.Application.Dtos;

namespace MyJwtProject.Core.Application.Features.Queries
{
    public class CheckUserQueryRequest:IRequest<CheckUserResponseDto>
    {
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
    }
}
