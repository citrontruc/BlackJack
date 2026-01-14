/*
A class to handle images.
Check if they are already loaded.
*/

public class ImageHandler
{
    private Dictionary<string, ImageAsset> _availableImages = new();

    public Result AddImageToDict(string imageName, ImageAsset imageValue)
    {
        if (_availableImages.TryGetValue(imageName, out var response))
        {
            return Result.Failure(new Error("400", "ImageAsset already exists"));
        }
        _availableImages[imageName] = imageValue;
        return Result.Success();
    }

    public ImageAsset GetImage(string imageName)
    {
        if (_availableImages.TryGetValue(imageName, out var response))
        {
            return response;
        }

        Result imageLoad = LoadImage(imageName);
        if (imageLoad.IsSuccess)
        {
            return _availableImages[imageName];
        }

        throw new FileLoadException(imageLoad.ToString());
    }

    public Result LoadImage(string imageName)
    {
        if (!File.Exists(imageName))
        {
            return Result.Failure(new Error("404", "Image was not found"));
        }
        ImageAsset newImageAsset = new(imageName);
        return AddImageToDict(imageName, newImageAsset);
    }

    public void Draw(string imageName, int x, int y)
    {
        if (!_availableImages.TryGetValue(imageName, out var response))
        {
            throw new Exception("Could not find the image to draw");
        }
        response.Draw(x, y);
    }
}
