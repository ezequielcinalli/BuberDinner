using ErrorOr;

namespace BuberDinner.Domain.Common.Errors;

public partial class Errors
{
    public static class Authentication
    {
        public static Error InvalidCredentials => Error.Validation("Auth.InvalidCredentials", "Invalid credentials.");
    }
}