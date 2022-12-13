
namespace Ordering.FunctionalTests.Controllers;

[Collection("Sequential")]
public class ProjectCreate : IClassFixture<CustomWebApplicationFactory<ApiMarker>>
{
    private readonly HttpClient _client;

    public ProjectCreate(CustomWebApplicationFactory<ApiMarker> factory)
    {
        _client = factory.CreateClient();
    }

    [Fact]
    public async Task ShouldReturnSuccessStatus()
    {
        var response = await _client.GetAsync("/api/weatherforecast");
        response.StatusCode.Should().Be(HttpStatusCode.OK);
    }
}
