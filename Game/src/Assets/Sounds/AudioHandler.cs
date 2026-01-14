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
            return Result.Failure(new Error("400", "MusicAsset already exists"));
        }
        _availableMusic[musicName] = musicValue;
        return Result.Success();
    }

    public Result AddSoundToDict(string soundName, SoundAsset soundValue)
    {
        if (_availableSounds.TryGetValue(soundName, out var response))
        {
            return Result.Failure(new Error("400", "SoundAsset already exists"));
        }
        _availableSounds[soundName] = soundValue;
        return Result.Success();
    }

    public MusicAsset GetMusic(string musicName)
    {
        if (_availableMusic.TryGetValue(musicName, out var response))
        {
            return response;
        }

        Result musicLoad = LoadMusic(musicName);
        if (musicLoad.IsSuccess)
        {
            return _availableMusic[musicName];
        }

        throw new FileLoadException(musicLoad.ToString());
    }

    public SoundAsset GetSound(string soundName)
    {
        if (_availableSounds.TryGetValue(soundName, out var response))
        {
            return response;
        }

        Result soundLoad = LoadMusic(soundName);
        if (soundLoad.IsSuccess)
        {
            return _availableSounds[soundName];
        }

        throw new FileLoadException(soundLoad.ToString());
    }

    public Result LoadMusic(string musicName)
    {
        if (!File.Exists(musicName))
        {
            return Result.Failure(new Error("404", "Music was not found"));
        }
        MusicAsset newMusicAsset = new(musicName);
        return AddMusicToDict(musicName, newMusicAsset);
    }

    public Result LoadSound(string soundName)
    {
        if (!File.Exists(soundName))
        {
            return Result.Failure(new Error("404", "Sound was not found"));
        }
        SoundAsset newSoundAsset = new(soundName);
        return AddSoundToDict(soundName, newSoundAsset);
    }
    #endregion

    public void PlayMusic(string musicName)
    {
        if (!_availableMusic.TryGetValue(musicName, out var response))
        {
            throw new Exception("Could not find the music to play");
        }
    }

    public void PlaySound(string soundName)
    {
        if (!_availableSounds.TryGetValue(soundName, out var response))
        {
            throw new Exception("Could not find the sound to play");
        }
        Raylib.PlaySound(response.GetSound());
    }
}
