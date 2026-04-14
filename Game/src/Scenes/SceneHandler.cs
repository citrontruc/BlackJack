/*
A class to handle transitions between scenes and notably that assets are loaded and unloaded.
*/

using BlackJack.Utils.Errors;

namespace BlackJack.Scenes;

public class SceneHandler
{
    private IScene _currentScene;

    public SceneHandler(IScene initialScene)
    {
        _currentScene = initialScene;
        _currentScene.Load();
    }

    public Result ChangeScene(IScene newScene)
    {
        Result unloadSuccessful = _currentScene.Unload();
        if (unloadSuccessful.IsSuccess == false)
        {
            Error unloadFailed = new("500", "Unloading of scene failed");
            return Result.Failure(unloadFailed);
        }

        Result loadSuccessful = newScene.Load();
        if (!loadSuccessful.IsSuccess)
        {
            Error loadFailed = new("500", "Loading of scene failed");
            return Result.Failure(loadFailed);
        }
        _currentScene = newScene;
        return Result.Success();
    }

    public void UpdateScene(float deltaTime)
    {
        if (_currentScene.ShouldChangeScene())
        {
            var result = _currentScene.TryGetNextScene(out var newScene);
            if (result.IsFailure)
                throw new Exception(
                    $"{result.Error.Code} with message {result.Error.Description}."
                );
            ChangeScene(newScene);
        }
        _currentScene.Update(deltaTime);
    }

    public void DrawScene()
    {
        _currentScene.Draw();
    }
}
