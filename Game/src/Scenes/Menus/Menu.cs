/*
A class to represent the main menu of the game.
*/

using Raylib_cs;

public class Menu : IScene
{
    #region Display information
    protected static int _screenWidth = Raylib.GetScreenWidth();
    protected static int _screenHeight = Raylib.GetScreenHeight();
    #endregion

    public Result Load()
    {
        return Result.Success();
    }

    public Result Unload()
    {
        return Result.Success();
    }

    public void Update(float deltaTime) { }

    public void Draw() { }
}
