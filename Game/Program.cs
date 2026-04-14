/*
A class to launch our game
*/

using BlackJack.Services.Handlers;

public class Game
{
    public static void Main()
    {
        GameHandler game = new();
        game.Initiliaze();
        game.RunGame();
    }
}
