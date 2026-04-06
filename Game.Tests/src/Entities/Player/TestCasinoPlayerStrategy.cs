/*
A test class to evaluate the strategies of the casino.
*/

using BlackJack.Entities.CardHandling;
using BlackJack.Entities.CardHandling.HandEvaluationStrategy;
using BlackJack.Entities.Players.CasinoStrategy;
using BlackJack.Entities.Players.Players;

namespace Game.Tests.Entities.Player;

public class CasinoPlayerStrategyEvaluation
{
    [Fact]
    public void EvaluateDefaultStrategy_OnSeventeen_ReturnsStand()
    {
        // Arrange
        BlackJackEvaluationStrategy handEvaluationStrategy = new();
        DefaultStrategy casinoStrategy = new();
        CasinoPlayer player = new(handEvaluationStrategy, casinoStrategy);
        Card aceCard = new(Card.Values.Ace, Card.Colours.Heart);
        Card sixCard = new(Card.Values.Six, Card.Colours.Heart);

        // Act
        player.AddCardToHand(aceCard);
        player.AddCardToHand(sixCard);

        // Assert
        Assert.Equal(PlayerActions.Actions.Stand, player.EvaluateNextAction());
    }

    [Fact]
    public void EvaluateDefaultStrategy_OnSmallValue_ReturnsHit()
    {
        // Arrange
        BlackJackEvaluationStrategy handEvaluationStrategy = new();
        DefaultStrategy casinoStrategy = new();
        CasinoPlayer player = new(handEvaluationStrategy, casinoStrategy);
        Card jackCard = new(Card.Values.Jack, Card.Colours.Heart);
        Card twoCard = new(Card.Values.Two, Card.Colours.Heart);

        // Act
        player.AddCardToHand(jackCard);
        player.AddCardToHand(twoCard);

        // Assert
        Assert.Equal(PlayerActions.Actions.Hit, player.EvaluateNextAction());
    }

    [Fact]
    public void EvaluateDefaultStrategy_OnLargeValue_ReturnsStand()
    {
        // Arrange
        BlackJackEvaluationStrategy handEvaluationStrategy = new();
        DefaultStrategy casinoStrategy = new();
        CasinoPlayer player = new(handEvaluationStrategy, casinoStrategy);
        Card jackCard = new(Card.Values.Jack, Card.Colours.Heart);
        Card queenCard = new(Card.Values.Queen, Card.Colours.Heart);

        // Act
        player.AddCardToHand(jackCard);
        player.AddCardToHand(queenCard);

        // Assert
        Assert.Equal(PlayerActions.Actions.Stand, player.EvaluateNextAction());
    }

    [Fact]
    public void EvaluateSoftSeventeenStrategy_OnLargeValue_ReturnsStand()
    {
        // Arrange
        BlackJackEvaluationStrategy handEvaluationStrategy = new();
        SoftSeventeenStrategy casinoStrategy = new();
        CasinoPlayer player = new(handEvaluationStrategy, casinoStrategy);
        Card jackCard = new(Card.Values.Jack, Card.Colours.Heart);
        Card queenCard = new(Card.Values.Queen, Card.Colours.Heart);

        // Act
        player.AddCardToHand(jackCard);
        player.AddCardToHand(queenCard);

        // Assert
        Assert.Equal(PlayerActions.Actions.Stand, player.EvaluateNextAction());
    }

    [Fact]
    public void EvaluateSoftSeventeenStrategy_OnSoftSeventeen_ReturnsHit()
    {
        // Arrange
        BlackJackEvaluationStrategy handEvaluationStrategy = new();
        SoftSeventeenStrategy casinoStrategy = new();
        CasinoPlayer player = new(handEvaluationStrategy, casinoStrategy);
        Card aceCard = new(Card.Values.Ace, Card.Colours.Heart);
        Card sixCard = new(Card.Values.Six, Card.Colours.Heart);

        // Act
        player.AddCardToHand(aceCard);
        player.AddCardToHand(sixCard);

        // Assert
        Assert.Equal(PlayerActions.Actions.Hit, player.EvaluateNextAction());
    }

    [Fact]
    public void EvaluateSoftSeventeenStrategy_OnHardSeventeen_ReturnsStand()
    {
        // Arrange
        BlackJackEvaluationStrategy handEvaluationStrategy = new();
        SoftSeventeenStrategy casinoStrategy = new();
        CasinoPlayer player = new(handEvaluationStrategy, casinoStrategy);
        Card tenCard = new(Card.Values.Ten, Card.Colours.Heart);
        Card sevenCard = new(Card.Values.Seven, Card.Colours.Heart);

        // Act
        player.AddCardToHand(tenCard);
        player.AddCardToHand(sevenCard);

        // Assert
        Assert.Equal(PlayerActions.Actions.Stand, player.EvaluateNextAction());
    }

    [Fact]
    public void EvaluateSoftSeventeenStrategy_OnSoftSeventeenWithFourCards_ReturnsHit()
    {
        // Arrange
        BlackJackEvaluationStrategy handEvaluationStrategy = new();
        SoftSeventeenStrategy casinoStrategy = new();
        CasinoPlayer player = new(handEvaluationStrategy, casinoStrategy);
        Card aceHeartCard = new(Card.Values.Ace, Card.Colours.Heart);
        Card twoCard = new(Card.Values.Two, Card.Colours.Heart);
        Card threeCard = new(Card.Values.Three, Card.Colours.Heart);
        Card aceSpadesCard = new(Card.Values.Ace, Card.Colours.Spades);

        // Act
        player.AddCardToHand(aceHeartCard);
        player.AddCardToHand(twoCard);
        player.AddCardToHand(threeCard);
        player.AddCardToHand(aceSpadesCard);

        // Assert
        Assert.Equal(PlayerActions.Actions.Hit, player.EvaluateNextAction());
    }

    [Fact]
    public void EvaluateSoftSeventeentrategy_OnSmallValue_ReturnsHit()
    {
        // Arrange
        BlackJackEvaluationStrategy handEvaluationStrategy = new();
        SoftSeventeenStrategy casinoStrategy = new();
        CasinoPlayer player = new(handEvaluationStrategy, casinoStrategy);
        Card jackCard = new(Card.Values.Jack, Card.Colours.Heart);
        Card twoCard = new(Card.Values.Two, Card.Colours.Heart);

        // Act
        player.AddCardToHand(jackCard);
        player.AddCardToHand(twoCard);

        // Assert
        Assert.Equal(PlayerActions.Actions.Hit, player.EvaluateNextAction());
    }
}