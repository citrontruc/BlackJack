/*
A strategy that implements the casino design pattern.
Default strategy;
*/

public class DefaultStrategy : CasinoStrategy
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
