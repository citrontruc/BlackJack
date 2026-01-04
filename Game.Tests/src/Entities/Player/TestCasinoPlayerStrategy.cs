/*
A test class to evaluate the strategies of the casino.
*/

public class CasinoPlayerStrategyEvaluation
{
    [Fact]
    public void EvaluateDefaultStrategy_OnSeventeen_ReturnsStand()
    {
        // Arrange
        BlackJackEvaluationStrategy handEvaluationStrategy = new();
        DefaultStrategy casinoStrategy = new();
        CasinoPlayer player = new(handEvaluationStrategy, casinoStrategy);
        Card AceCard = new(Card.Values.Ace, Card.Colours.Heart);
        Card sixCard = new(Card.Values.Six, Card.Colours.Heart);

        // Act
        player.AddCardToHand(AceCard);
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
        Card QueenCard = new(Card.Values.Queen, Card.Colours.Heart);

        // Act
        player.AddCardToHand(jackCard);
        player.AddCardToHand(QueenCard);

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
        Card QueenCard = new(Card.Values.Queen, Card.Colours.Heart);

        // Act
        player.AddCardToHand(jackCard);
        player.AddCardToHand(QueenCard);

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
        Card AceCard = new(Card.Values.Ace, Card.Colours.Heart);
        Card sixCard = new(Card.Values.Six, Card.Colours.Heart);

        // Act
        player.AddCardToHand(AceCard);
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
        Card TenCard = new(Card.Values.Ten, Card.Colours.Heart);
        Card sevenCard = new(Card.Values.Seven, Card.Colours.Heart);

        // Act
        player.AddCardToHand(TenCard);
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
        Card AceHeartCard = new(Card.Values.Ace, Card.Colours.Heart);
        Card TwoCard = new(Card.Values.Two, Card.Colours.Heart);
        Card ThreeCard = new(Card.Values.Three, Card.Colours.Heart);
        Card AceSpadesCard = new(Card.Values.Ace, Card.Colours.Spades);

        // Act
        player.AddCardToHand(AceHeartCard);
        player.AddCardToHand(TwoCard);
        player.AddCardToHand(ThreeCard);
        player.AddCardToHand(AceSpadesCard);

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
