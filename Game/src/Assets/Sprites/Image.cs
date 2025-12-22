/*
An object to store a single image that can be shared with multiple objects.
*/

using Raylib_cs;

public record ImageAsset
{
    private string _imageName;
    private Image _imageValue;
    private Texture2D _textureValue;

    public ImageAsset(string imageName)
    {
        _imageName = imageName;
        LoadImageValue();
    }

    public void LoadImageValue()
    {
        _imageValue = Raylib.LoadImage(_imageName);
        _textureValue = Raylib.LoadTextureFromImage(_imageValue);
        Raylib.UnloadImage(_imageValue);
    }
}
