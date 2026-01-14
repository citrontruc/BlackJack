/*
An object to store a single sound that can be shared with multiple objects.
*/

using Raylib_cs;

public class MusicAsset : IDisposable
{
    private string _musicDirectory;
    private Music _music;
    private bool _disposed;

    #region Constructor
    public MusicAsset(string musicDirectory)
    {
        _musicDirectory = musicDirectory;
        LoadMusicValue();
    }
    #endregion

    #region Load, get and set
    public void LoadMusicValue()
    {
        _music = Raylib.LoadMusicStream(_musicDirectory);
    }

    public Music GetMusic()
    {
        return _music;
    }
    #endregion

    public void Dispose()
    {
        if (!_disposed)
        {
            Raylib.UnloadMusicStream(_music);
            _disposed = true;
        }
    }
}
