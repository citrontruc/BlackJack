/*
A class to write tests about wallets.
*/

using BlackJack.Entities.BetsHandling;
using BlackJack.Utils.Errors;

namespace Game.Tests.Entities.BetsHandling;

public class WalletTest
{
    [Fact]
    public void RetrieveMoney_Valid_ReturnsSuccess()
    {
        // Arrange
        Wallet wallet = new(20);

        // Act
        Result result = wallet.DebitWallet(20);

        // Assert
        Assert.True(result.IsSuccess);
    }

    [Fact]
    public void RetrieveMoney_InValid_ReturnsFailure()
    {
        // Arrange
        Wallet wallet = new(20);

        // Act
        Result result = wallet.DebitWallet(21);

        // Assert
        Assert.True(result.IsFailure);
    }
}
