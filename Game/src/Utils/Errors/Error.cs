/*
A class to implement the Result design pattern.
*/

namespace BlackJack.Utils.Errors;

public sealed record Error(string Code, string Description)
{
    public static readonly Error None = new(string.Empty, string.Empty);
}
