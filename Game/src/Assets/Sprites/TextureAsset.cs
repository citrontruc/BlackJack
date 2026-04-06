/*
An object to store a single image that can be shared with multiple objects.
*/

using Raylib_cs;

namespace BlackJack.Assets.Sprites;

public record TextureAsset : IAsset<Texture2D>
{
    private string? _textureName;
    private Texture2D _textureValue;
    private bool _disposed;

    #region Load, Getters and Setters
    public void Load(string textureName)
    {
        _textureName = textureName;
        Image imageValue = Raylib.LoadImage(_textureName);
        _textureValue = Raylib.LoadTextureFromImage(imageValue);
        Raylib.UnloadImage(imageValue);
    }

    public Texture2D GetAssetValue()
    {
        return _textureValue;
    }
    #endregion

    public void Draw(int x, int y)
    {
        Raylib.DrawTexture(_textureValue, x, y, Color.RayWhite);
    }

    public void Dispose()
    {
        if (!_disposed)
        {
            Raylib.UnloadTexture(_textureValue);
            _disposed = true;
        }
    }
}
