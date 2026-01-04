/*
An interface to evaluate the value of a hand in a card game.
*/

public interface HandEvaluationStrategy
{
    public int Evaluate(List<Card> cards);
}
