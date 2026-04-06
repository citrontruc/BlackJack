/*
A players hand in the game of BlackJack
*/

namespace BlackJack.Entities.CardHandling;

public class Hand
{
    private List<Card> _cards = [];
    private readonly HandEvaluationStrategy.IHandEvaluationStrategy _evaluationStrategy;

    public Hand(HandEvaluationStrategy.IHandEvaluationStrategy strategy)
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

    public List<Card.Values> GetCardValues()
    {
        List<Card.Values> cardValuesList = new();
        foreach (Card card in _cards)
        {
            cardValuesList.Add(card.CardValue);
        }
        return cardValuesList;
    }

    public void ResetHand()
    {
        _cards = [];
    }
    #endregion

    public int EvaluateHandValue()
    {
        return _evaluationStrategy.Evaluate(_cards);
    }
}
