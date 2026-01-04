/*
An Abstract class to define the components of a BlackJack player.
*/

public abstract class AbstractPlayer
{
    protected Hand _playerHand;
    protected Wallet _playerWallet = new();

    public AbstractPlayer(HandEvaluationStrategy strategy)
    {
        _playerHand = new(strategy);
    }
}
