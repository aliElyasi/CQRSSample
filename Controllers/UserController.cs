using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CQRSSample.Application.Commands.User;
using CQRSSample.Application.DTOs;
using CQRSSample.Application.Qeries;
using CQRSSample.Data;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CQRSSample.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private IMediator _mediator;

        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]

        public async Task<IActionResult> GetUser()
        {
            var result = await _mediator.Send(new GetUserRequest());
            return Ok(result);
        }

        [HttpPost]

        public async Task<IActionResult> AddUser(AddUserDto request)
        {
            var userId = await _mediator.Send(new CreateUsersCommand()
            {
                name = request.Name
            });
            return Ok(new User(userId
            , request.Name));

        }






    }
}