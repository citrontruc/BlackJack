/*
A class to handle the whole game.
Unique, launches the game.
*/

using BlackJack.Assets.Sprites;
using BlackJack.Scenes;
using BlackJack.Scenes.Menus;
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

    #region Services

    private SceneHandler _sceneHandler;
    private TextureHandler _textureHandler;
    #endregion


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
    private void InitiliazeServices()
    {
        _textureHandler = new();
        _sceneHandler = new(new MainMenu(_textureHandler));
    }
    #endregion

    #region Execution
    public void RunGame()
    {
        while (!Raylib.WindowShouldClose())
        {
            float dt = Raylib.GetFrameTime();
            Update(dt);
            Draw();
        }
        Raylib.CloseAudioDevice();
        Raylib.CloseWindow();
    }
    #endregion

    #region Update
    public void Update(float deltaTime)
    {
        //_inputHandler?.Update();
        _sceneHandler.UpdateScene(deltaTime);
    }
    #endregion

    #region draw
    public void Draw()
    {
        Raylib.BeginDrawing();
        _sceneHandler.DrawScene();
        Raylib.EndDrawing();
    }
    #endregion
}
