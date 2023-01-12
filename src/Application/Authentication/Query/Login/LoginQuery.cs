using Application.Services.Authentication.Common;
using ErrorOr;
using MediatR;

namespace Application.Authentication.Query.Login;

public record LoginQuery(
string email,
string password) : IRequest<ErrorOr<AuthenticationResult>>;
