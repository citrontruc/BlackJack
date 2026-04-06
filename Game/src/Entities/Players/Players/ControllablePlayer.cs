/*
A class to define a player controlled by a person.
*/

using BlackJack.Entities.CardHandling.HandEvaluationStrategy;

namespace BlackJack.Entities.Players.Players;

public class ControllablePlayer : AbstractPlayer
{
    private readonly int _playerId = 0;

    public ControllablePlayer(IHandEvaluationStrategy strategy)
        : base(strategy) { }
}
