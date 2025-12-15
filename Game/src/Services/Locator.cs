/*
Service locator who returns which services exist and are registered.
The service locator is unique, it is a Singleton to make sure of its unicity and accessibility.
It is then used to do dependency injection.
*/

public class ServiceLocator : Singleton<ServiceLocator>
{
    private Dictionary<Type, object> _services = new Dictionary<Type, object>();

    public void Register<T>(T service)
    {
        if (_services.ContainsKey(typeof(T)))
            throw new InvalidOperationException(
                $"Service of type {typeof(T)} is already registered."
            );
        if (service is null)
        {
            throw new NullReferenceException($"Service of type {typeof(T)} is null.");
        }
        _services[typeof(T)] = service;
    }

    public T Get<T>()
    {
        if (!_services.ContainsKey(typeof(T)))
            throw new InvalidOperationException($"Service of type {typeof(T)} is not registered.");
        return (T)_services[typeof(T)];
    }

    public void Unregister<T>()
    {
        if (_services.ContainsKey(typeof(T)))
            _services.Remove(typeof(T));
    }

    public void Reset()
    {
        _services.Clear();
    }
}
