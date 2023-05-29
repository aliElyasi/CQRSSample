using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CQRSSample.Application.Services;
using CQRSSample.Data;
using MediatR;

namespace CQRSSample.Application.Qeries
{

    public class GetUserRequest : IRequest<List<User>>
    {

    }

    public class CreateUsersCommandHandler : IRequestHandler<GetUserRequest, List<User>>
    {

        private UserService UserService;

        public CreateUsersCommandHandler(UserService userService)
        {
            UserService = userService;
        }


        public Task<List<User>> Handle(GetUserRequest request, CancellationToken cancellationToken)
        {
            return Task.FromResult(UserService.GetUsers());
        }
    }
}