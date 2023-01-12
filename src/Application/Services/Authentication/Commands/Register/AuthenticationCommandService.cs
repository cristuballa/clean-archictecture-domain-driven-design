using Application.Common.Interfaces;
using Application.Services.Authentication.Common;
using Domain.Common.Exceptions;
using Domain.Entities;
using ErrorOr;

namespace Application.Services.Authentication.Commands.Register
{
    public class AuthenticationCommandService : IAuthenticationCommandService
    {
        private readonly IJwtTokenGenerator? _jwtTokenGenerator;
        private readonly IUserRepository? _userRepository;

        public ErrorOr<AuthenticationResult> Register(string firstName, string lastName, string email, string password)
        {
            //Check if user already exists
            if (_userRepository?.GetUserByEmail(email) is not null)
                return Errors.User.DuplicateEmail;

            //Create user
            var user = new User
            {
                Id = Guid.NewGuid().ToString(),
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                Password = password
            };
            _userRepository?.CreateUser(user);

            //Generate token
            var token = _jwtTokenGenerator?.GenerateToken(
                user.Id,
                user.Email,
                user.FirstName,
                user.LastName);

            var response = new AuthenticationResult(user, token);
            return response;
        }
    }
}