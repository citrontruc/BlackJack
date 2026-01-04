/*
An interface to implement the strategy pattern for our casino strategy.
*/

public interface CasinoStrategy
{
    public PlayerActions.Actions EvaluateNextAction(Hand hand);
}
