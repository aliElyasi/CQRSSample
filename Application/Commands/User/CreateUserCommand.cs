using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CQRSSample.Application.Services;
using MediatR;

namespace CQRSSample.Application.Commands.User
{
    public class CreateUsersCommand:IRequest<Guid>
    {
        public string name { get; set; }
        
    }

    public class CreateUsersCommandHandler : IRequestHandler<CreateUsersCommand, Guid>
    {
        private UserService UserService;

        public CreateUsersCommandHandler(UserService userService)
        {
            UserService = userService;
        }

        public Task<Guid> Handle(CreateUsersCommand request, CancellationToken cancellationToken)
        {
           var userId=Guid.NewGuid();
           UserService.AddUsers(new Data.User(userId,request.name));

           return Task.FromResult(userId);
        }
    }
}