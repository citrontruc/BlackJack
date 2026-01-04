/*
A class to define the Casino's behaviour.
*/

public class CasinoPlayer : AbstractPlayer
{
    private CasinoStrategy _casinoStrategy;

    public CasinoPlayer(
        HandEvaluationStrategy handEvaluationstrategy,
        CasinoStrategy casinoStrategy
    )
        : base(handEvaluationstrategy)
    {
        _casinoStrategy = casinoStrategy;
    }

    public PlayerActions.Actions EvaluateNextAction()
    {
        return _casinoStrategy.EvaluateNextAction(_playerHand);
    }
}
