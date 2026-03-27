# Authentication

The Helicone API uses Bearer token authentication.

## Getting an API Key

1. Sign up at [helicone.ai](https://www.helicone.ai/)
2. Navigate to your dashboard settings
3. Create a new API key

## Client Initialization

```csharp
using Helicone;

var client = new HeliconeClient(
    apiKey: Environment.GetEnvironmentVariable("HELICONE_API_KEY")!);
```

## Environment Variables

For integration tests, set the following environment variable:

```bash
export HELICONE_API_KEY=your-api-key-here
```
