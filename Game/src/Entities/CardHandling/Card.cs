/*
A representation of a card in a game of BlackJack.
*/

public struct Card
{
    #region Enums to define cards
    public enum Values
    {
        Ace,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
    }

    public enum Colours
    {
        Heart,
        Clubs,
        Diamond,
        Spades,
    }
    #endregion

    #region Properties
    public Values CardValue;
    public Colours CardColour;
    #endregion

    #region Constructor
    public Card(Values value, Colours colour)
    {
        CardValue = value;
        CardColour = colour;
    }
    #endregion
}
