using ErrorOr;

namespace Domain.Common.Exceptions;

public static partial class Errors
{
    public static class Authentication
    {
        public static Error InvalidUser => Error.Validation(
          code: "Auth.InvalidUser",
          description: "Invalid User.");

        public static Error InvalidPassword => Error.Validation(
        code: "Auth.InvalidPassword",
        description: "Invalid Password.");
    }
}
