/*
An Abstract class to define the components of a BlackJack player.
*/

using BlackJack.Entities.BetsHandling;
using BlackJack.Entities.CardHandling;
using BlackJack.Entities.CardHandling.HandEvaluationStrategy;

namespace BlackJack.Entities.Players.Players;

public abstract class AbstractPlayer
{
    protected Hand PlayerHand;
    protected Wallet PlayerWallet = new();
    protected bool Fold = false;

    protected AbstractPlayer(IHandEvaluationStrategy strategy)
    {
        PlayerHand = new(strategy);
    }

    #region Hand handling
    public void DrawCardFromDeck(Deck deck)
    {
        Card card = deck.Draw();
        PlayerHand.AddCard(card);
    }

    public void AddCardToHand(Card card)
    {
        PlayerHand.AddCard(card);
    }
    #endregion
}