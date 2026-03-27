/* order: 10, title: MEAI Tools, slug: meai-tools */

using Microsoft.Extensions.AI;

namespace Helicone.IntegrationTests;

public partial class Tests
{
    //// Helicone provides AIFunction tools that can be used with any
    //// `Microsoft.Extensions.AI.IChatClient` to give AI agents access to
    //// LLM observability metrics, cost tracking, and prompt management.

    [TestMethod]
    public async Task Meai_AsGetTotalCostTool()
    {
        using var client = GetAuthenticatedClient();

        //// Create a tool that gets total LLM API cost:
        var tool = client.AsGetTotalCostTool();

        tool.Name.Should().Be("GetTotalCost");
        tool.Description.Should().Contain("cost");
    }

    [TestMethod]
    public async Task Meai_AsGetTotalRequestsTool()
    {
        using var client = GetAuthenticatedClient();

        //// Create a tool that gets total request count:
        var tool = client.AsGetTotalRequestsTool();

        tool.Name.Should().Be("GetTotalRequests");
        tool.Description.Should().Contain("request");
    }

    [TestMethod]
    public async Task Meai_AsGetAverageLatencyTool()
    {
        using var client = GetAuthenticatedClient();

        //// Create a tool that gets average latency:
        var tool = client.AsGetAverageLatencyTool();

        tool.Name.Should().Be("GetAverageLatency");
        tool.Description.Should().Contain("latency");
    }

    [TestMethod]
    public async Task Meai_AsListPromptsTool()
    {
        using var client = GetAuthenticatedClient();

        //// Create a tool that lists prompts:
        var tool = client.AsListPromptsTool();

        tool.Name.Should().Be("ListPrompts");
        tool.Description.Should().Contain("prompt");
    }
}
