/*
A class to put in place a global random number generator.
*/

// Random is an insecure number generator.
// We however have no sensitive information to encrypt. We can disable the warning.
#pragma warning disable CA5394
public static class RandomGlobal
{
    /// <summary>
    /// Our random number generator.
    /// Remove Seed in production.
    /// </summary>
    static readonly Random _rnd = new(42);

    public static Random GetGlobalRandom()
    {
        return _rnd;
    }
}
#pragma warning restore CA5394
