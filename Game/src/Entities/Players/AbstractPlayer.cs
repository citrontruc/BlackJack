/*
An Abstract class to define the components of a BlackJack player.
*/

public abstract class AbstractPlayer
{
    protected Hand _playerHand;
    protected Wallet _playerWallet = new();
    protected bool fold = false;

    public AbstractPlayer(HandEvaluationStrategy strategy)
    {
        _playerHand = new(strategy);
    }

    #region Hand handling
    public void DrawCardFromDeck(Deck deck)
    {
        Card card = deck.Draw();
        _playerHand.AddCard(card);
    }

    public void AddCardToHand(Card card)
    {
        _playerHand.AddCard(card);
    }
    #endregion
}
