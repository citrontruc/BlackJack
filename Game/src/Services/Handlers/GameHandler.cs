/*
A class to handle the whole game.
Unique, launches the game.
*/

using Raylib_cs;

public class GameHandler : Singleton<GameHandler>
{
    #region Display information
    private static readonly int _screenHeight = 600;
    private static readonly int _screenWidth = 800;
    private static readonly int _targetFPS = 60;
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
        Raylib.SetTargetFPS(_targetFPS);
        Raylib.InitWindow(_screenWidth, _screenHeight, "BlackJack");
    }

    /// <summary>
    /// Creates all the game services.
    /// </summary>
    private static void InitiliazeServices() { }
    #endregion

    #region Execution
    public void RunGame()
    {
        while (!Raylib.WindowShouldClose())
        {
            float dt = Raylib.GetFrameTime();
            //_inputHandler?.Update();
            //_sceneHandler?.Update(dt);
            Draw();
        }
        Raylib.CloseWindow();
    }

    public void Draw()
    {
        Raylib.BeginDrawing();
        //_sceneHandler?.Draw();
        Raylib.EndDrawing();
    }
    #endregion
}
