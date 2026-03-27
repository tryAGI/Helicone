# Microsoft.Extensions.AI Integration

Helicone provides `AIFunction` tools compatible with
[Microsoft.Extensions.AI](https://www.nuget.org/packages/Microsoft.Extensions.AI),
allowing any `IChatClient` to query LLM observability metrics, costs, and prompts.

## Available Tools

| Method | Tool Name | Description |
|--------|-----------|-------------|
| `AsGetTotalCostTool()` | `GetTotalCost` | Gets total LLM API cost for a time range. |
| `AsGetTotalRequestsTool()` | `GetTotalRequests` | Gets total request count for a time range. |
| `AsGetAverageLatencyTool()` | `GetAverageLatency` | Gets average request latency for a time range. |
| `AsListPromptsTool()` | `ListPrompts` | Lists prompts with optional search filtering. |

## Usage

```csharp
using Helicone;
using Microsoft.Extensions.AI;

var helicone = new HeliconeClient(apiKey);

// Create tools
var tools = new[]
{
    helicone.AsGetTotalCostTool(),
    helicone.AsGetTotalRequestsTool(),
    helicone.AsGetAverageLatencyTool(),
    helicone.AsListPromptsTool(),
};

// Use with any IChatClient
var response = await chatClient.GetResponseAsync(
    "What was the total cost of LLM calls this week?",
    new ChatOptions { Tools = tools });
```

## Tool Details

### GetTotalCost

Gets total cost in USD for LLM API calls within a time range.
Takes ISO 8601 start and end dates.

### GetTotalRequests

Gets total number of LLM API requests within a time range.

### GetAverageLatency

Gets average response latency in milliseconds within a time range.

### ListPrompts

Lists prompts managed in Helicone with optional search filtering.
Returns prompt names, descriptions, tags, and version counts.

```csharp
var tool = helicone.AsListPromptsTool(pageSize: 10);
```
