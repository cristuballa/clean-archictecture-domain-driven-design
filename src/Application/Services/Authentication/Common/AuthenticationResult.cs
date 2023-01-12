using Domain.Entities;

namespace Application.Services.Authentication.Common
{
    public record AuthenticationResult
   (
        User User,
        string Token
    );
}