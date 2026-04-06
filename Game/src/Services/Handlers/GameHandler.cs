/*
A class to handle the whole game.
Unique, launches the game.
*/

using BlackJack.Assets.Sprites;
using BlackJack.Utils;
using BlackJack.Utils.Errors;
using Raylib_cs;

namespace BlackJack.Services.Handlers;

public class GameHandler : Singleton<GameHandler>
{
    #region Display information
    private static readonly int _screenHeight = 600;
    private static readonly int _screenWidth = 800;
    private static readonly int _targetFPS = 60;
    #endregion

    private TextureHandler _textureHandler = new();

    #region Initialization
    public void Initiliaze()
    {
        InitializeWindow();
        InitiliazeServices();
    }

    /// <summary>
    /// Creates the raylib game window.
    /// </summary>
    private void InitializeWindow()
    {
        Raylib.InitWindow(_screenWidth, _screenHeight, "BlackJack");
        Raylib.SetTargetFPS(_targetFPS);
        Raylib.InitAudioDevice();
    }

    /// <summary>
    /// Creates all the game services.
    /// </summary>
    private static void InitiliazeServices() { }
    #endregion

    #region Execution
    public void RunGame()
    {
        var imageName = "Game/resources/AceHeart.jpeg";
        Result loadSuccess = _textureHandler.LoadAsset(imageName);
        Console.WriteLine(loadSuccess.ToString());

        while (!Raylib.WindowShouldClose())
        {
            float dt = Raylib.GetFrameTime();
            //_inputHandler?.Update();
            //_sceneHandler?.Update(dt);

            Draw();
        }
        Raylib.CloseAudioDevice();
        Raylib.CloseWindow();
    }

    public void Draw()
    {
        var imageName = "Game/resources/AceHeart.jpeg";
        Raylib.BeginDrawing();
        _textureHandler.Draw(imageName, 0, 0);
        //_sceneHandler?.Draw();
        Raylib.EndDrawing();
    }
    #endregion
}
