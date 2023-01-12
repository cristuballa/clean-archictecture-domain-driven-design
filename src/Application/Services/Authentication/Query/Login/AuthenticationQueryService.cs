using Application.Common.Interfaces;
using Application.Services.Authentication.Common;
using Domain.Common.Exceptions;
using Domain.Entities;
using ErrorOr;

namespace Application.Services.Authentication.Query.Login
{
    public class AuthenticationQueryService : IAuthenticationQueryService
    {
        private readonly IJwtTokenGenerator _jwtTokenGenerator;
        private readonly IUserRepository _userRepository;
        public AuthenticationQueryService(IJwtTokenGenerator jwtTokenGenerator, IUserRepository userRepository)
        {
            _jwtTokenGenerator = jwtTokenGenerator;
            _userRepository = userRepository;
        }
        public ErrorOr<AuthenticationResult> Login(string email, string password)
        {
            //Validate user
            if (_userRepository.GetUserByEmail(email) is not User user)
                return Errors.Authentication.InvalidUser;

            //Check if password is valid
            if (user.Password != password)
                return Errors.Authentication.InvalidPassword;

            var token = _jwtTokenGenerator.GenerateToken(
                user.Id,
                user.Email,
                user.FirstName,
                user.LastName);

            var response = new AuthenticationResult(user, token);
            return response;
        }
    }
}