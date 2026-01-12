/*
A class to handle transitions between scenes and notably that assets are loaded and unloaded.
*/

public class SceneHandler
{
    private IScene? _currentScene;

    public Result ChangeScene(IScene newScene)
    {
        Result? unloadSuccessful = _currentScene?.Unload();
        if (unloadSuccessful?.IsSuccess == false)
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

    public void UpdateScene(float DeltaTime)
    {
        _currentScene?.Update(DeltaTime);
    }

    public void DrawScene()
    {
        _currentScene?.Draw();
    }
}
