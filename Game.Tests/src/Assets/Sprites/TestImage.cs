/*
A series of tests to evaluate if our image assets are correctly loaded.
*/

using BlackJack.Assets.Sprites;
using BlackJack.Utils.Errors;
using Raylib_cs;

namespace Game.Tests.Assets.Sprites;

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

    [RaylibFact]
    public void LoadImageAsset_Valid_ReturnsSuccess()
    {
        // Arrange
        InitilizeRaylib();
        TextureHandler imageHandler = new();
        var imageName = Path.Combine(
            AppDomain.CurrentDomain.BaseDirectory,
            "resources",
            "AceHeart.jpeg"
        );

        // Act
        Result loadSuccess = imageHandler.LoadAsset(imageName);
        Console.WriteLine(loadSuccess.ToString());

        // Assert
        Assert.True(loadSuccess.IsSuccess);
    }

    [RaylibFact]
    public void LoadImageAsset_InValid_ReturnsFailure()
    {
        // Arrange
        InitilizeRaylib();
        TextureHandler imageHandler = new();
        string imageName = "";

        // Act
        Result loadSuccess = imageHandler.LoadAsset(imageName);

        // Assert
        Assert.True(loadSuccess.IsFailure);
    }

    [RaylibFact]
    public void LoadImageAsset_MultipleTimes_ReturnsFailure()
    {
        // Arrange
        InitilizeRaylib();
        TextureHandler imageHandler = new();
        var imageName = Path.Combine(
            AppDomain.CurrentDomain.BaseDirectory,
            "resources",
            "AceHeart.jpeg"
        );

        // Act
        Result loadSuccess = imageHandler.LoadAsset(imageName);
        loadSuccess = imageHandler.LoadAsset(imageName);

        // Assert
        Assert.True(loadSuccess.IsFailure);
    }

    public void Dispose()
    {
        Raylib.CloseWindow();
    }
}