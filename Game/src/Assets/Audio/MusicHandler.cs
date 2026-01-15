/*
A class to handle musics.
*/

using Raylib_cs;

public class MusicHandler : AssetHandler<Music>
{
    private Dictionary<string, Asset<Music>> _availableMusic = new();

    #region Load, Set and get
    public Result StoreAsset(string musicName, Asset<Music> musicValue)
    {
        if (_availableMusic.TryGetValue(musicName, out var response))
        {
            return Result.Failure(new Error("400", "MusicAsset already exists"));
        }
        _availableMusic[musicName] = musicValue;
        return Result.Success();
    }

    public Asset<Music> Get(string musicName)
    {
        if (_availableMusic.TryGetValue(musicName, out var response))
        {
            return response;
        }

        Result musicLoad = LoadAsset(musicName);
        if (musicLoad.IsSuccess)
        {
            return _availableMusic[musicName];
        }

        throw new FileLoadException(musicLoad.ToString());
    }

    public Result LoadAsset(string musicName)
    {
        if (!File.Exists(musicName))
        {
            return Result.Failure(new Error("404", "Music was not found"));
        }
        MusicAsset newMusicAsset = new();
        newMusicAsset.Load(musicName);
        return StoreAsset(musicName, newMusicAsset);
    }
    #endregion

    public void PlayMusic(string musicName)
    {
        if (!_availableMusic.TryGetValue(musicName, out var response))
        {
            throw new Exception("Could not find the music to play");
        }
    }
}
