using Application.Common.Interfaces;
using Application.Services.Authentication.Common;
using ErrorOr;
using MediatR;
using Domain.Common.Exceptions;
using Domain.Entities;

namespace Application.Authentication.Commands.Register;

public class RegisterCommandHandler : IRequestHandler<RegisterCommand, ErrorOr<AuthenticationResult>>
{
    private readonly IJwtTokenGenerator _jwtTokenGenerator;
    private readonly IUserRepository? _userRepository;
    public RegisterCommandHandler(IJwtTokenGenerator jwtTokenGenerator, IUserRepository userRepository)
    {
        _jwtTokenGenerator = jwtTokenGenerator;
        _userRepository = userRepository;
    }
    public async Task<ErrorOr<AuthenticationResult>> Handle(RegisterCommand command, CancellationToken cancellationToken)
    {
        if (_userRepository?.GetUserByEmail(command.Email) is not null)
            return Errors.User.DuplicateEmail;

        //Create user
        var user = new User
        {
            Id = Guid.NewGuid().ToString(),
            FirstName = command.FirstName,
            LastName = command.LastName,
            Email = command.Email,
            Password = command.Password
        };
        _userRepository?.CreateUser(user);

        //Generate token
        var token = _jwtTokenGenerator.GenerateToken(
            user.Id,
            user.Email,
            user.FirstName,
            user.LastName);

        return new AuthenticationResult(user, token);
    }
}
