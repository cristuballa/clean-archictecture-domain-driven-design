using Microsoft.AspNetCore.Mvc;
using Contracts.Authentication;
using Microsoft.AspNetCore.Authorization;
using WebApi.Controllers;
using ErrorOr;
using MediatR;
using Application.Authentication.Commands.Register;
using Application.Authentication.Query.Login;
using Application.Authentication.Common;

namespace Api.Controllers.V1
{
    [Route("auth")]
    [ApiVersion("1.1")]
    [ApiVersion("1.0")]
    [AllowAnonymous]
    public class AuthenticationController : ApiController
    {
        private readonly IMediator _mediator;
        private object _authenticationQueryService;

        public AuthenticationController(IMediator mediator)
        {
            _mediator = mediator;
        }
        ///<summary>
        /// Register a new user
        ///</summary>
        [MapToApiVersion("1.1")]
        [HttpPost("register")]
        public async Task<IActionResult> Register(RegisterRequest request)
        {
            var command = new RegisterCommand(
                request.FirstName,
                request.LastName,
                request.Email,
                request.Password);

            ErrorOr<AuthenticationResult> authResult = await _mediator.Send(command);
            return authResult.Match(
                authResult => Ok(authResult),
                errors => Problem(errors));
        }

        ///<summary>
        /// Register a new user
        ///</summary>
        [HttpPost("login")]
        [MapToApiVersion("1.1")]
        public async Task<IActionResult> Login(LoginRequest request)
        {
            var query = new LoginQuery(
                request.Email,
                request.Password);
            ErrorOr<AuthenticationResult> authResult = await _mediator.Send(query);

            return authResult.Match(
                authResult => Ok(authResult),
                errors => Problem(errors));
        }
    }
}