/*
Main menu of the game.
*/

using BlackJack.Assets.Sprites;

namespace BlackJack.Scenes.Menus;

public class MainMenu : Menu
{
    public MainMenu(TextureHandler textureHandler)
        : base(textureHandler)
    {
        _dataDirectory = "Game/Scenes/Menus/MainMenu.json";
        var result = Load();
        if (result.IsFailure)
            throw new Exception($"{result.Error.Code}: {result.Error.Description}.");
        Console.WriteLine(_jsonData?.ToString());
    }

    public override void Draw()
    {
        //_textureHandler.Draw("AceHeart.jpeg", 0, 0);
    }

    public override void Update(float deltaTime)
    {
        // Take user input and see if something happens.
    }
}
