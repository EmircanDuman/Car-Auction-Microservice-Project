using System;
using Contracts;
using MassTransit;
using MongoDB.Entities;
using SearchService.Models;

namespace SearchService.Consumers;

public class AuctionDeletedConsumer : IConsumer<AuctionDeleted>
{
  public async Task Consume(ConsumeContext<AuctionDeleted> context)
  {
    Console.WriteLine($"Auction deleted event received for Auction ID: {context.Message.Id}");
    var result = await DB.DeleteAsync<Item>(context.Message.Id);
    if (!result.IsAcknowledged)
    {
      throw new Exception($"Failed to delete Item with ID: {context.Message.Id}");
    }
  }
}
