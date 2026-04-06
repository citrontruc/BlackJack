/*
An optimized strategy that takes into account the fact that you should hit on a hand
containing a 6 + an Ace.
*/

using BlackJack.Entities.CardHandling;

namespace BlackJack.Entities.Players.CasinoStrategy;

public class SoftSeventeenStrategy : ICasinoStrategy
{
    public PlayerActions.Actions EvaluateNextAction(Hand hand)
    {
        int handValue = hand.EvaluateHandValue();
        if (handValue < 17)
        {
            return PlayerActions.Actions.Hit;
        }
        if (handValue == 17 && hand.GetCardValues().Contains(Card.Values.Ace))
        {
            // In the soft seventeen strategy, we Hit if we have an ace in hand.
            return PlayerActions.Actions.Hit;
        }
        return PlayerActions.Actions.Stand;
    }
}
