using ErrorOr;
using FluentValidation;
using MediatR;

namespace Application.Common.Behaviors;

public class ValidationBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
    where TRequest : IRequest<TResponse>
    where TResponse : IErrorOr
{
    private readonly IValidator<TRequest> _validator;
    public ValidationBehavior(IValidator<TRequest> validator)
    {
        _validator = validator;
    }
    public async Task<TResponse> Handle(
        TRequest request,
        RequestHandlerDelegate<TResponse> next,
        CancellationToken cancellationToken)
    {
        var validationResult = _validator.Validate(request);
        if (validationResult.IsValid)
            return await next();

        var errors = validationResult.Errors.ConvertAll(validationFailure => Error.Validation(
            validationFailure.PropertyName,
            validationFailure.ErrorMessage));

        return (dynamic)errors;
    }
}