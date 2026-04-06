/*
An interface to evaluate the value of a hand in a card game.
*/

namespace BlackJack.Entities.CardHandling.HandEvaluationStrategy;

public interface IHandEvaluationStrategy
{
    public int Evaluate(List<Card> cards);
}
