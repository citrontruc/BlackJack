/*
An interface to implement the strategy pattern for our casino strategy.
*/

using BlackJack.Entities.CardHandling;

namespace BlackJack.Entities.Players.CasinoStrategy;

public interface ICasinoStrategy
{
    public PlayerActions.Actions EvaluateNextAction(Hand hand);
}
