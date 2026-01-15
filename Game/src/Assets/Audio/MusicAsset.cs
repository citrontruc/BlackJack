/*
An object to store a single sound that can be shared with multiple objects.
*/

using Raylib_cs;

public class MusicAsset : Asset<Music>
{
    private string? _musicDirectory;
    private Music _music;
    private bool _disposed;

    #region Load, get and set
    public void Load(string musicDirectory)
    {
        _musicDirectory = musicDirectory;
        _music = Raylib.LoadMusicStream(_musicDirectory);
    }

    public Music GetAssetValue()
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
