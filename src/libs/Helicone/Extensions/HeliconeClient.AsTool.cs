#pragma warning disable CS3002 // Return type is not CLS-compliant
using System.Text.Json;
using Microsoft.Extensions.AI;

namespace Helicone;

/// <summary>
/// Extensions for using HeliconeClient operations as MEAI tools with any IChatClient.
/// </summary>
public static class HeliconeToolExtensions
{
    /// <summary>
    /// Creates an <see cref="AIFunction"/> that gets the total cost of LLM API calls.
    /// </summary>
    /// <param name="client">The Helicone client.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsGetTotalCostTool(this HeliconeClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string startDate, string endDate, CancellationToken cancellationToken) =>
            {
                var response = await client.Metrics.GetTotalCostAsync(
                    request: new MetricsFilterBody
                    {
                        Filter = new FilterNode(),
                        TimeFilter = new MetricsFilterBodyTimeFilter
                        {
                            Start = startDate,
                            End = endDate,
                        },
                    },
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return JsonSerializer.Serialize(new
                {
                    total_cost = response.Success?.Data,
                    start_date = startDate,
                    end_date = endDate,
                });
            },
            name: "GetTotalCost",
            description: "Gets the total cost of LLM API calls within a time range. Provide ISO 8601 start and end dates (e.g., '2026-03-01T00:00:00Z'). Returns the total cost in USD.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that gets the total number of LLM requests.
    /// </summary>
    /// <param name="client">The Helicone client.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsGetTotalRequestsTool(this HeliconeClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string startDate, string endDate, CancellationToken cancellationToken) =>
            {
                var response = await client.Metrics.GetTotalRequestsAsync(
                    request: new MetricsFilterBody
                    {
                        Filter = new FilterNode(),
                        TimeFilter = new MetricsFilterBodyTimeFilter
                        {
                            Start = startDate,
                            End = endDate,
                        },
                    },
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return JsonSerializer.Serialize(new
                {
                    total_requests = response.Success?.Data,
                    start_date = startDate,
                    end_date = endDate,
                });
            },
            name: "GetTotalRequests",
            description: "Gets the total number of LLM API requests within a time range. Provide ISO 8601 start and end dates. Returns the request count.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that gets the average latency of LLM requests.
    /// </summary>
    /// <param name="client">The Helicone client.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsGetAverageLatencyTool(this HeliconeClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string startDate, string endDate, CancellationToken cancellationToken) =>
            {
                var response = await client.Metrics.GetAverageLatencyAsync(
                    request: new MetricsFilterBody
                    {
                        Filter = new FilterNode(),
                        TimeFilter = new MetricsFilterBodyTimeFilter
                        {
                            Start = startDate,
                            End = endDate,
                        },
                    },
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return JsonSerializer.Serialize(new
                {
                    average_latency_ms = response.Success?.Data,
                    start_date = startDate,
                    end_date = endDate,
                });
            },
            name: "GetAverageLatency",
            description: "Gets the average latency of LLM API requests in milliseconds within a time range. Provide ISO 8601 start and end dates.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that lists prompts.
    /// </summary>
    /// <param name="client">The Helicone client.</param>
    /// <param name="pageSize">Number of prompts per page (default: 20).</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsListPromptsTool(
        this HeliconeClient client,
        int pageSize = 20)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string? search, CancellationToken cancellationToken) =>
            {
                var response = await client.Prompt2025.GetPrompts2025Async(
                    request: new GetPrompts2025Request
                    {
                        PageSize = pageSize,
                        Page = 1,
                        TagsFilter = [],
                        Search = search ?? string.Empty,
                    },
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return JsonSerializer.Serialize(response.Success);
            },
            name: "ListPrompts",
            description: "Lists prompts managed in Helicone. Optionally filter by search term. Returns prompt names, descriptions, tags, and version counts.");
    }
}
