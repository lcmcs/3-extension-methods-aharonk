using Sefirah;

namespace ExtensionMethods;

public static class IntegerExtensions
{
    private static readonly SefirahCalculator CurrentSefirahCalculator = new();

    /// <summary>
    /// An extension method for <see cref="SefirahCalculator.GetSefirahStatement"/> using <see cref="SefirahCalculator.English"/>.
    /// </summary>
    /// <param name="i">A day number</param>
    /// <returns>The sefirah count of the given day.</returns>
    public static string EnglishSefira(this int i)
    {
        return CurrentSefirahCalculator.GetSefirahStatement(i, SefirahCalculator.English);
    }

    /// <summary>
    /// An extension method to get the factorial of a number.
    /// </summary>
    /// <param name="i">A number.</param>
    /// <returns><paramref name="i"/>!</returns>
    /// <exception cref="NotImplementedException">If <paramref name="i"/> is negative.</exception>
    public static long Factorial(this int i)
    {
        return i switch
        {
            < 0 => throw new NotImplementedException("Cannot currently compute factorial of a negative number."),
            > 1 => i * (i - 1).Factorial(),
            _ => 1
        };
    }

    /// <summary>
    /// An extension method to get the summation of a number.
    /// </summary>
    /// <param name="i">A number.</param>
    /// <returns>The summation of 0...<paramref name="i"/>.</returns>
    public static long Summation(this int i)
    {
        return i switch
        {
            0 => 0,
            < 0 => i + (i + 1).Summation(),
            > 0 => (i * (i + 1)) / 2 // If there's a formula, no need to do recursion
        };
    }
}