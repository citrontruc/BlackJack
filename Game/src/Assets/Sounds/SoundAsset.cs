/*
An object to store a single sound that can be shared with multiple objects.
*/

using Raylib_cs;

public class SoundAsset : IDisposable
{
    private string _soundDirectory;
    private Sound _sound;
    private bool _disposed;

    #region Constructor
    public SoundAsset(string soundDirectory)
    {
        _soundDirectory = soundDirectory;
        LoadSoundValue();
    }
    #endregion

    #region Load, get and set
    public void LoadSoundValue()
    {
        _sound = Raylib.LoadSound(_soundDirectory);
    }

    public Sound GetSound()
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
