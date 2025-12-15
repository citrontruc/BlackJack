/*
A deck to handle all our cards and how they are distributed to players.
*/

public class Deck
{
    private Queue<Card> _cards = [];
    private List<Card> _allCards = Enum.GetValues<Card.Values>()
        .SelectMany(v => Enum.GetValues<Card.Colours>().Select(c => new Card(v, c)))
        .ToList();

    private Random _rnd;

    public Deck(Random rnd)
    {
        _rnd = rnd;
    }

    /// <summary>
    /// Method to shuffle existing deck
    /// </summary>
    private void Shuffle()
    {
        List<Card> cardList = _cards.ToList();
        // Shuffle using Fisher–Yates
        for (int i = cardList.Count - 1; i > 0; i--)
        {
            int j = _rnd.Next(i + 1);
            (cardList[i], cardList[j]) = (cardList[j], cardList[i]);
        }
        _cards = new Queue<Card>(cardList);
    }

    /// <summary>
    /// Method to reset the deck to original state.
    /// Cards are not shuffled here.
    /// </summary>
    private void ResetDeck()
    {
        _cards = new Queue<Card>(_allCards);
    }

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
