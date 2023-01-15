using FluentValidation;

namespace Application.Authentication.Queries.Login;

public class LoginQueryValidator : AbstractValidator<LoginQuery>
{
    public LoginQueryValidator()
    {
        RuleFor(x => x.email).NotEmpty();
        RuleFor(x => x.password).NotEmpty();
    }
}
