/*
A players hand in the game of BlackJack
*/

public class Hand
{
    private List<Card> _cards = [];

    #region Getters & Setters
    public void AddCard(Card card)
    {
        _cards.Add(card);
    }

    public List<Card> GetHand()
    {
        return _cards;
    }

    public void ResetHand()
    {
        _cards = [];
    }
    #endregion
}
