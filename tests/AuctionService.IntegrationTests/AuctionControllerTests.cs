using System;
using System.Net.Http.Json;
using AuctionService.Data;
using AuctionService.DTOs;
using AuctionService.IntegrationTests.Fixtures;
using AuctionService.IntegrationTests.Util;
using Microsoft.Extensions.DependencyInjection;

namespace AuctionService.IntegrationTests;

public class AuctionControllerTests : IClassFixture<CustomWebAppFactory>, IAsyncLifetime
{
  private readonly CustomWebAppFactory _factory;
  private readonly HttpClient _client;
  public AuctionControllerTests(CustomWebAppFactory customWebAppFactory)
  {
    _factory = customWebAppFactory;
    _client = _factory.CreateClient();
  }

  [Fact]
  public async Task GetAuctions_ShouldReturn3Auctions()
  {
    var response = await _client.GetFromJsonAsync<List<AuctionDTO>>("api/auctions");
    
    Assert.Equal(3, response.Count);
  }

  public Task InitializeAsync() => Task.CompletedTask;

  public Task DisposeAsync()
  {
    using var scope = _factory.Services.CreateScope();
    var db = scope.ServiceProvider.GetService<AuctionDbContext>();
    DbHelper.ReinitDbForTests(db);
    return Task.CompletedTask;
  }

}
