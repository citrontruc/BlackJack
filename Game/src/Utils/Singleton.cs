/*
A singleton class to make sure some components are unique.
*/

public abstract class Singleton<T> where T : class, new()
{
    private static readonly Lazy<T> _instance = new(() => new T());
    public static T Instance => _instance.Value;
}
