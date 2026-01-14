/*
An object to store a single image that can be shared with multiple objects.
*/

using Raylib_cs;

public record ImageAsset : IDisposable
{
    private string _imageName;
    private Texture2D _textureValue;
    private bool _disposed;

    #region Constructor
    public ImageAsset(string imageName)
    {
        _imageName = imageName;
        LoadImageValue();
    }

    #region Load, Getters and Setters
    public void LoadImageValue()
    {
        Image imageValue = Raylib.LoadImage(_imageName);
        _textureValue = Raylib.LoadTextureFromImage(imageValue);
        Raylib.UnloadImage(imageValue);
    }
    #endregion

    public Texture2D GetTexture()
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
