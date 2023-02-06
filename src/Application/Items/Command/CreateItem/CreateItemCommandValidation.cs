using FluentValidation;

namespace Application.Items.Command.CreateItem;
public class CreateItemCommandValidation : AbstractValidator<CreateItemCommand>
{
    public CreateItemCommandValidation()
    {
        RuleFor(x => x.Description)
            .NotEmpty()
            .MaximumLength(50);

    }
}