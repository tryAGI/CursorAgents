namespace CursorAgents.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static CursorAgentsClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("CURSORAGENTS_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("CURSORAGENTS_API_KEY environment variable is not found.");

        var client = new CursorAgentsClient(apiKey);
        
        return client;
    }
}
