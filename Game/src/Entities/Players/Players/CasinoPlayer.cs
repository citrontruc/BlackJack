/*
A class to define the Casino's behaviour.
*/

using BlackJack.Entities.CardHandling.HandEvaluationStrategy;
using BlackJack.Entities.Players.CasinoStrategy;

namespace BlackJack.Entities.Players.Players;

public class CasinoPlayer : AbstractPlayer
{
    private readonly ICasinoStrategy _casinoStrategy;

    public CasinoPlayer(
        IHandEvaluationStrategy handEvaluationstrategy,
        ICasinoStrategy casinoStrategy
    )
        : base(handEvaluationstrategy)
    {
        _casinoStrategy = casinoStrategy;
    }

    public PlayerActions.Actions EvaluateNextAction()
    {
        return _casinoStrategy.EvaluateNextAction(PlayerHand);
    }
}
