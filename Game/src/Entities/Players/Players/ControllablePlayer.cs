/*
A class to define a player controlled by a person.
*/

public class ControllablePlayer : AbstractPlayer
{
    private int _playerId = 0;

    public ControllablePlayer(HandEvaluationStrategy strategy)
        : base(strategy) { }
}
