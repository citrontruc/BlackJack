/*
A class to handle images.
Check if they are already loaded.
*/

using BlackJack.Utils.Errors;
using Raylib_cs;

namespace BlackJack.Assets.Sprites;

public class TextureHandler : IAssetHandler<Texture2D>
{
    private Dictionary<string, IAsset<Texture2D>> _availableTextures = new();

    #region Load, Set and get
    public Result StoreAsset(string textureName, IAsset<Texture2D> textureAsset)
    {
        if (_availableTextures.TryGetValue(textureName, out var response))
        {
            return Result.Failure(new Error("400", "textureAsset already exists"));
        }
        _availableTextures[textureName] = textureAsset;
        return Result.Success();
    }

    public IAsset<Texture2D> Get(string textureName)
    {
        if (_availableTextures.TryGetValue(textureName, out var response))
        {
            return response;
        }

        Result textureLoad = LoadAsset(textureName);
        if (textureLoad.IsSuccess)
        {
            return _availableTextures[textureName];
        }
        throw new FileLoadException(textureLoad.ToString());
    }

    public Result LoadAsset(string textureName)
    {
        if (!File.Exists(textureName))
        {
            return Result.Failure(new Error("404", "Image was not found"));
        }
        TextureAsset newTextureAsset = new();
        newTextureAsset.Load(textureName);
        return StoreAsset(textureName, newTextureAsset);
    }
    #endregion

    public void Draw(string textureName, int x, int y)
    {
        if (!_availableTextures.TryGetValue(textureName, out var response))
        {
            throw new Exception("Could not find the image to draw");
        }
        Raylib.DrawTexture(response.GetAssetValue(), x, y, Color.RayWhite);
    }
}
