/*
A class to launch our game
*/

public class Game
{
    public static void Main()
    {
        Console.WriteLine(
            $"Data value{MenuDataLoader.LoadMenuData("Game/Scenes/Menus/MainMenu.json")}"
        );
        GameHandler game = new();
        game.Initiliaze();
        game.RunGame();
    }
}
