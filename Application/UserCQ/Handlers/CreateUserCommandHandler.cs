using Application.UserCQ.Commands;
using Application.UserCQ.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UserCQ.Handlers
{
	public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, UserInfoViewModel>
	{
		public Task<UserInfoViewModel> Handle(CreateUserCommand request, CancellationToken cancellationToken)
		{
			throw new NotImplementedException();
		}
	}
}
