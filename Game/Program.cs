/*
A class to launch our game
*/

public class Game
{
    public static void Main()
    {
        MenuDataLoader menuDataLoader = new();
        Console.WriteLine(
            $"Data value{menuDataLoader.LoadMenuData("Game/Scenes/Menus/MainMenu.json")}"
        );
        GameHandler game = new();
        game.Initiliaze();
        game.RunGame();
    }
}
