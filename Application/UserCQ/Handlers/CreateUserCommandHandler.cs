using Application.Response;
using Application.UserCQ.Commands;
using Application.UserCQ.ViewModels;
using Azure;
using Domain.Entity;
using Infra.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UserCQ.Handlers
{
	public class CreateUserCommandHandler(TasksDbContext context) : IRequestHandler<CreateUserCommand, ResponseBase<UserInfoViewModel>>
	{
		private readonly TasksDbContext _context = context;

		public async Task<ResponseBase<UserInfoViewModel>> Handle(CreateUserCommand request, CancellationToken cancellationToken)
		{
		
			var user = new User()
			{
				Name = request.Name,
				Surname = request.Surname,
				Email = request.Email,
				Password = request.Password,
				Username = request.Username,
				RefreshToken = Guid.NewGuid().ToString(),
				RefreshTokenExpirationTime = DateTime.Now.AddDays(5) // Define o tempo de expiração do token para 5 dias a partir de agora
			};

			_context.Users.Add(user);
			_context.SaveChanges();

			var userInfo = new ResponseBase<UserInfoViewModel>
			{
				ResponseInfo = null,
				Value = new()
				{
					Name = user.Name,
					Surname = user.Surname,
					Email = user.Email,
					Username = user.Username,
					RefreshToken = user.RefreshToken,
					RefreshTokenExpirationTime = (DateTime)user.RefreshTokenExpirationTime,
					TokenJWT = Guid.NewGuid().ToString() // Simula a geração de um token JWT
				}
			};

			return userInfo;
		}
	}
}
