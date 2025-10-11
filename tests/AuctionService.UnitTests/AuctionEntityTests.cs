using System;
using AuctionService.Entities;

namespace AuctionService.UnitTests;

public class AuctionEntityTests
{
    [Fact]
    public void hasReservedPrice_ReservePriceGreaterThanZero_True()
    {
        // Arrange
        var auction = new Auction { Id = Guid.NewGuid(), ReservedPrice = 10 };

        // Act
        var result = auction.hasReservedPrice();

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void hasReservedPrice_ReservePriceIsZero_False()
    {
        // Arrange
        var auction = new Auction { Id = Guid.NewGuid(), ReservedPrice = 0 };

        // Act
        var result = auction.hasReservedPrice();

        // Assert
        Assert.False(result);
    }
}
