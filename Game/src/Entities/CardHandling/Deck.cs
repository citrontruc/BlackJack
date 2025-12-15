/*
A deck to handle all our cards and how they are distributed to players.
*/

public class Deck
{
    private Queue<Card> _cards = [];

    /// <summary>
    /// Method to shuffle existing deck
    /// </summary>
    private void Shuffle() { }

    /// <summary>
    /// Method to reset the deck to original state.
    /// Cards are not shuffled here.
    /// </summary>
    private void ResetDeck() { }

    public void Reset()
    {
        ResetDeck();
        Shuffle();
    }

    public Card Draw()
    {
        return _cards.Dequeue();
    }
}
