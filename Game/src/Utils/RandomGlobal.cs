/*
A class to put in place a global random number generator.
*/

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
