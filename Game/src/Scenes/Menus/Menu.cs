/*
A class to represent the main menu of the game.
*/

using BlackJack.Assets.Sprites;
using BlackJack.Utils.Errors;
using Raylib_cs;

namespace BlackJack.Scenes.Menus;

public class Menu : IScene
{
    #region Display information
    private int _screenWidth = Raylib.GetScreenWidth();
    private int _screenHeight = Raylib.GetScreenHeight();
    #endregion

    #region LoadMenu
    private string _dataDirectory;
    private TextureHandler _textureHandler;
    private JsonData? _jsonData;
    #endregion

    public Menu(string dataDirectory, TextureHandler textureHandler)
    {
        _dataDirectory = dataDirectory;
        _textureHandler = textureHandler;
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
