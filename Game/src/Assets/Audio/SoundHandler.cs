/*
A class to handle sound effects.
*/

using Raylib_cs;

public class SoundHandler : AssetHandler<Sound>
{
    private Dictionary<string, Asset<Sound>> _availableSounds = new();

    #region Load, Set and get
    public Result StoreAsset(string soundName, Asset<Sound> soundValue)
    {
        if (_availableSounds.TryGetValue(soundName, out var response))
        {
            return Result.Failure(new Error("400", "SoundAsset already exists"));
        }
        _availableSounds[soundName] = soundValue;
        return Result.Success();
    }

    public Asset<Sound> Get(string soundName)
    {
        if (_availableSounds.TryGetValue(soundName, out var response))
        {
            return response;
        }

        Result soundLoad = LoadAsset(soundName);
        if (soundLoad.IsSuccess)
        {
            return _availableSounds[soundName];
        }

        throw new FileLoadException(soundLoad.ToString());
    }

    public Result LoadAsset(string soundName)
    {
        if (!File.Exists(soundName))
        {
            return Result.Failure(new Error("404", "Sound was not found"));
        }
        SoundAsset newSoundAsset = new();
        newSoundAsset.Load(soundName);
        return StoreAsset(soundName, newSoundAsset);
    }
    #endregion

    public void PlaySound(string soundName)
    {
        if (!_availableSounds.TryGetValue(soundName, out var response))
        {
            throw new Exception("Could not find the sound to play");
        }
    }
}
