/*
A class to handle all audio.
*/

using Raylib_cs;

public class AudioHandler
{
    private Dictionary<string, SoundAsset> _availableSounds = new();
    private Dictionary<string, MusicAsset> _availableMusic = new();

    #region Load, Set and get
    public Result AddMusicToDict(string musicName, MusicAsset musicValue)
    {
        if (_availableMusic.TryGetValue(musicName, out var response))
        {
            return Result.Failure(new Error("400", "ImageAsset already exists"));
        }
        _availableMusic[musicName] = musicValue;
        return Result.Success();
    }

    public MusicAsset GetMusic(string musicName)
    {
        if (_availableMusic.TryGetValue(musicName, out var response))
        {
            return response;
        }

        Result imageLoad = LoadMusic(musicName);
        if (imageLoad.IsSuccess)
        {
            return _availableMusic[musicName];
        }

        throw new FileLoadException(imageLoad.ToString());
    }

    public Result LoadMusic(string musicName)
    {
        if (!File.Exists(musicName))
        {
            return Result.Failure(new Error("404", "Image was not found"));
        }
        MusicAsset newMusicAsset = new(musicName);
        return AddMusicToDict(musicName, newMusicAsset);
    }
    #endregion

    public void PlayMusic(string musicName)
    {
        if (!_availableMusic.TryGetValue(musicName, out var response))
        {
            throw new Exception("Could not find the image to draw");
        }
    }
}
