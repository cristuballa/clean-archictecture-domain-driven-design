using Application.Services.Authentication.Common;
using ErrorOr;

namespace Application.Services.Authentication.Query.Login
{
    public interface IAuthenticationQueryService
    {
        public ErrorOr<AuthenticationResult> Login(string email, string password);
    }
}