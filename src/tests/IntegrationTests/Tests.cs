namespace Helicone.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static HeliconeClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("HELICONE_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("HELICONE_API_KEY environment variable is not found.");

        var client = new HeliconeClient(apiKey);
        
        return client;
    }
}
