using Application.Common.Interfaces;
using ErrorOr;
using MediatR;
using Domain.Common.Exceptions;
using Domain.Entities;
using Application.Authentication.Common;

namespace Application.Authentication.Queries.Login;

public class LoginQueryHandler : IRequestHandler<LoginQuery, ErrorOr<AuthenticationResult>>
{
    private readonly IJwtTokenGenerator _jwtTokenGenerator;
    private readonly IUserRepository _userRepository;
    public LoginQueryHandler(IUserRepository userRepository, IJwtTokenGenerator jwtTokenGenerator)
    {
        _userRepository = userRepository;
        _jwtTokenGenerator = jwtTokenGenerator;
    }
    public async Task<ErrorOr<AuthenticationResult>> Handle(LoginQuery query, CancellationToken cancellationToken)
    {
         await Task.CompletedTask;
        //Check if user exists
        if (_userRepository.GetUserByEmail(query.email) is not User user)
            return Errors.Authentication.InvalidUser;

        //Check if password is valid
        if (user.Password != query.password)
            return Errors.Authentication.InvalidPassword;

        var token = _jwtTokenGenerator.GenerateToken(
            user.Id,
            user.Email,
            user.FirstName,
            user.LastName);

        return new AuthenticationResult(user, token);

    }
}
