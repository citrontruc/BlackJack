/*
A test file to check the evaluation of hands.
*/

using BlackJack.Entities.CardHandling;
using BlackJack.Entities.CardHandling.HandEvaluationStrategy;

namespace Game.Tests.Entities.CardHandling;

public class HandEvaluationTest
{
    [Fact]
    public void EvaluateHand_Valid_ReturnsScore()
    {
        // Arrange
        BlackJackEvaluationStrategy blackJackEvaluation = new();
        Hand hand = new(blackJackEvaluation);
        Card jackCard = new(Card.Values.Jack, Card.Colours.Heart);
        Card twoCard = new(Card.Values.Two, Card.Colours.Heart);

        // Act
        hand.AddCard(jackCard);
        hand.AddCard(twoCard);

        // Assert
        Assert.Equal(12, hand.EvaluateHandValue());
    }

    [Fact]
    public void EvaluateHand_WithAce_ReturnsScore()
    {
        // Arrange
        BlackJackEvaluationStrategy blackJackEvaluation = new();
        Hand hand = new(blackJackEvaluation);
        Card jackCard = new(Card.Values.Jack, Card.Colours.Heart);
        Card aceCard = new(Card.Values.Ace, Card.Colours.Heart);

        // Act
        hand.AddCard(jackCard);
        hand.AddCard(aceCard);

        // Assert
        Assert.Equal(21, hand.EvaluateHandValue());
    }

    [Fact]
    public void EvaluateHandThatCouldCrossThreshold_WithAce_ReturnsScore()
    {
        // Arrange
        BlackJackEvaluationStrategy blackJackEvaluation = new();
        Hand hand = new(blackJackEvaluation);
        Card jackCard = new(Card.Values.Jack, Card.Colours.Heart);
        Card aceHeartCard = new(Card.Values.Ace, Card.Colours.Heart);
        Card aceSpadesCard = new(Card.Values.Ace, Card.Colours.Spades);

        // Act
        hand.AddCard(jackCard);
        hand.AddCard(aceHeartCard);
        hand.AddCard(aceSpadesCard);

        // Assert
        Assert.Equal(12, hand.EvaluateHandValue());
    }
}
