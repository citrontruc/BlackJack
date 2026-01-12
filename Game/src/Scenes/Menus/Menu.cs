/*
A class to represent the main menu of the game.
*/

using MenuData;
using Raylib_cs;

public class Menu : IScene
{
    #region Display information
    private int _screenWidth = Raylib.GetScreenWidth();
    private int _screenHeight = Raylib.GetScreenHeight();
    #endregion

    private string _dataDirectory;
    private JsonData? _jsonData;

    public Menu(string dataDirectory)
    {
        _dataDirectory = dataDirectory;
    }

    public Result LoadJson(string jsonDirectory)
    {
        _jsonData = MenuDataLoader.LoadMenuData(jsonDirectory);
        return Result.Success();
    }

    public Result Load()
    {
        return LoadJson(_dataDirectory);
    }

    public Result Unload()
    {
        return Result.Success();
    }

    public void Update(float deltaTime) { }

    public void Draw() { }
}
