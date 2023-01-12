namespace Contracts.Authentication;

public record LoginResponse(
    string FirstName,
    string LastName,
    string Email,
    string Token
);