/*
A strategy to evaluate a hand of blackjack.
*/

namespace BlackJack.Entities.CardHandling.HandEvaluationStrategy;

public class BlackJackEvaluationStrategy : IHandEvaluationStrategy
{
    private readonly Dictionary<Card.Values, int[]> _cardValues = new()
    {
        { Card.Values.Ace, [1, 11] },
        { Card.Values.Two, [2] },
        { Card.Values.Three, [3] },
        { Card.Values.Four, [4] },
        { Card.Values.Five, [5] },
        { Card.Values.Six, [6] },
        { Card.Values.Seven, [7] },
        { Card.Values.Eight, [8] },
        { Card.Values.Nine, [9] },
        { Card.Values.Ten, [10] },
        { Card.Values.Jack, [10] },
        { Card.Values.Queen, [10] },
        { Card.Values.King, [10] },
    };

    public int Evaluate(List<Card> cards)
    {
        int numAces = 0;
        int handValue = 0;
        int thresholdValue = 21;

        foreach (Card card in cards)
        {
            if (card.CardValue == Card.Values.Ace)
            {
                numAces++;
            }
            else
            {
                handValue += _cardValues[card.CardValue][0];
            }
        }

        handValue += numAces;

        for (int i = 0; i < numAces; i++)
        {
            if (handValue + 10 <= thresholdValue)
            {
                handValue += 10;
            }
        }

        return handValue;
    }
}
