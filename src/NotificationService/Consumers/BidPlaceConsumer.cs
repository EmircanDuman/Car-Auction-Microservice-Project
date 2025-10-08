using System;
using Contracts;
using MassTransit;
using Microsoft.AspNetCore.SignalR;
using NotificationService.Hubs;

namespace NotificationService.Consumers;

public class BidPlaceConsumer
{
  private readonly IHubContext<NotificationHub> _hubContext;

  public BidPlaceConsumer(IHubContext<NotificationHub> hubContext)
  {
    _hubContext = hubContext;
  }

  public async Task Consume(ConsumeContext<BidPlaced> context)
  {
    Console.WriteLine("Bid placed message received in NotificationService");
    await _hubContext.Clients.All.SendAsync("BidPlaced", context.Message);
  }
}
