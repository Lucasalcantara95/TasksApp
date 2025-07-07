using Application.UserCQ.Commands;
using Application.UserCQ.ViewModels;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class UserController(IMediator mediator) : ControllerBase
	{
		private readonly IMediator _mediator = mediator;

		[HttpPost("Create-User")]
		public async Task<ActionResult<UserInfoViewModel>> CreateUser(CreateUserCommand command)
		{
			//var result = await _mediator.Send(command);

			return Ok(await _mediator.Send(command));
		}
	}
}
