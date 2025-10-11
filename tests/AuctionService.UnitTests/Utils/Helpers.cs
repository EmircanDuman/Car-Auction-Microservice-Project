using System;
using System.Security.Claims;

namespace AuctionService.UnitTests.Utils;

public class Helpers
{
  public static ClaimsPrincipal GetClaimsPrincipal()
  {
    var claims = new List<Claim> { new Claim(ClaimTypes.Name, "test") };
    var identity = new ClaimsIdentity(claims, "Testing");
    return new ClaimsPrincipal(identity);
  }
}
