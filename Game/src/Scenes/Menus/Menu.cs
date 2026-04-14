/*
A class to represent the main menu of the game.
*/

using BlackJack.Assets.Sprites;
using BlackJack.Utils.Errors;
using Raylib_cs;

namespace BlackJack.Scenes.Menus;

public abstract class Menu : IScene
{
    #region Display information
    protected readonly int _screenWidth = Raylib.GetScreenWidth();
    protected readonly int _screenHeight = Raylib.GetScreenHeight();
    #endregion

    #region LoadMenu
    protected string _dataDirectory;
    protected TextureHandler _textureHandler;
    protected JsonData? _jsonData;
    #endregion

    protected bool _shouldChangeScene = false;

    public Menu(TextureHandler textureHandler)
    {
        _textureHandler = textureHandler;
    }

    Result LoadJson(string jsonDirectory)
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

    public abstract void Update(float deltaTime);

    public abstract void Draw();

    public bool ShouldChangeScene()
    {
        return _shouldChangeScene;
    }

    public Result TryGetNextScene(out IScene scene)
    {
        scene = null;
        return Result.Failure(new Error("500", "Not implemented yet"));
    }
}
