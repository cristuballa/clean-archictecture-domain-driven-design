using Application.Authentication.Common;
using ErrorOr;
using MediatR;

namespace Application.Authentication.Queries.Login;

public record LoginQuery(
string email,
string password) : IRequest<ErrorOr<AuthenticationResult>>;
