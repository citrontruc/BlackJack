/*
A strategy that implements the casino design pattern.
Default strategy;
*/

using BlackJack.Entities.CardHandling;
namespace BlackJack.Entities.Players.CasinoStrategy;

public class DefaultStrategy : ICasinoStrategy
{
    public PlayerActions.Actions EvaluateNextAction(Hand hand)
    {
        int handValue = hand.EvaluateHandValue();
        if (handValue < 17)
        {
            return PlayerActions.Actions.Hit;
        }
        return PlayerActions.Actions.Stand;
    }
}
