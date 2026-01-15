/*
An object to store a single sound that can be shared with multiple objects.
*/

using Raylib_cs;

public class SoundAsset : Asset<Sound>
{
    private string? _soundDirectory;
    private Sound _sound;
    private bool _disposed;

    #region Load, get and set
    public void Load(string soundDirectory)
    {
        _soundDirectory = soundDirectory;
        _sound = Raylib.LoadSound(_soundDirectory);
    }

    public Sound GetAssetValue()
    {
        return _sound;
    }
    #endregion

    public void Dispose()
    {
        if (!_disposed)
        {
            Raylib.UnloadSound(_sound);
            _disposed = true;
        }
    }
}
