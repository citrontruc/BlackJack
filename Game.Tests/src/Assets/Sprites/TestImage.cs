/*
A series of tests to evaluate if our image assets are correctly loaded.
*/

using Raylib_cs;

public class TestImage : IDisposable
{
    private void InitilizeRaylib()
    {
        // Initialize once for the whole test class
        if (!Raylib.IsWindowReady())
        {
            Raylib.SetConfigFlags(ConfigFlags.HiddenWindow);
            Raylib.InitWindow(1, 1, "TestContext");
            Raylib.SetTargetFPS(1);
        }
    }

    [Fact]
    public void LoadImageAsset_Valid_ReturnsSuccess()
    {
        // Arrange
        InitilizeRaylib();
        ImageHandler imageHandler = new();
        var imageName = Path.Combine(
            AppDomain.CurrentDomain.BaseDirectory,
            "resources",
            "AceHeart.jpeg"
        );

        // Act
        Result loadSuccess = imageHandler.LoadImage(imageName);
        Console.WriteLine(loadSuccess.ToString());

        // Assert
        Assert.True(loadSuccess.IsSuccess);
    }

    [Fact]
    public void LoadImageAsset_InValid_ReturnsFailure()
    {
        // Arrange
        InitilizeRaylib();
        ImageHandler imageHandler = new();
        string imageName = "";

        // Act
        Result loadSuccess = imageHandler.LoadImage(imageName);

        // Assert
        Assert.True(loadSuccess.IsFailure);
    }

    [Fact]
    public void LoadImageAsset_MultipleTimes_ReturnsFailure()
    {
        // Arrange
        InitilizeRaylib();
        ImageHandler imageHandler = new();
        var imageName = Path.Combine(
            AppDomain.CurrentDomain.BaseDirectory,
            "resources",
            "AceHeart.jpeg"
        );

        // Act
        Result loadSuccess = imageHandler.LoadImage(imageName);
        loadSuccess = imageHandler.LoadImage(imageName);

        // Assert
        Assert.True(loadSuccess.IsFailure);
    }

    public void Dispose()
    {
        Raylib.CloseWindow();
    }
}
