/*
A players hand in the game of BlackJack
*/

public class Hand
{
    private List<Card> _cards = [];
    private HandEvaluationStrategy _evaluationStrategy;

    public Hand(HandEvaluationStrategy strategy)
    {
        _evaluationStrategy = strategy;
    }

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

    public int GetHandValue()
    {
        return _evaluationStrategy.Evaluate(_cards);
    }
}
