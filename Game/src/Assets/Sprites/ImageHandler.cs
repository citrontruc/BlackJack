/*
A class to handle images.
Check if they are already loaded.
*/

public class ImageHandler
{
    private Dictionary<string, ImageAsset> _availableImages = new();

    public ImageAsset GetImage(string imageName)
    {
        ImageAsset? response;
        if (_availableImages.TryGetValue(imageName, out response))
        {
            return response;
        }
        Result imageLoad = LoadImage(imageName);
        if (imageLoad.IsSuccess)
        {
            return GetImage(imageName);
        }
        throw new FileLoadException(imageLoad.ToString());
    }

    public Result LoadImage(string imageName)
    {
        return Result.Failure(new Error("FileNotFound", $"Couldn't find asset: {imageName}."));
    }
}
