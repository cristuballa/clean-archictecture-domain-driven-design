using Application.Services.Authentication.Common;
using ErrorOr;

namespace Application.Services.Authentication.Commands.Register
{
    public interface IAuthenticationCommandService
    {
        public ErrorOr<AuthenticationResult> Register(string FirstName, string LastName, string Email, string Password);
    }
}