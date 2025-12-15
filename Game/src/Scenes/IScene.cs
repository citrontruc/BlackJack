/*
An interface to define Scenes for menus and levels.
*/

public interface IScene
{
    /// <summary>
    /// Load any elements and assets for the scene.
    /// </summary>
    public void Load();

    /// <summary>
    /// Unload all the elements exclusive for the scene.
    /// </summary>
    public void Unload();

    /// <summary>
    /// Update all the entities in the scene.
    /// </summary>
    /// <param name="DeltaTime">Time between frames</param>
    public void Update(float DeltaTime);

    /// <summary>
    /// Draw all the elements in the scene.
    /// </summary>
    public void Draw();
}
