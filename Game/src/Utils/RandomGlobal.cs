/*
A class to put in place a global random number generator.
*/

public static class RandomGlobal
{
    static readonly Random _rnd = new(42);

    public static Random GetGlobalRandom()
    {
        return _rnd;
    }
}
