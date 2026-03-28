# CLAUDE.md — Helicone SDK

## Overview

Auto-generated C# SDK for [Helicone](https://helicone.ai/) — LLM observability and monitoring platform for requests, traces, sessions, prompts, experiments, evaluators, datasets, metrics, dashboards, and agent management.
OpenAPI spec from the official [Helicone/helicone](https://github.com/Helicone/helicone) repo.

## Build & Test

```bash
dotnet build Helicone.slnx
dotnet test src/tests/IntegrationTests/
```

## Auth

Bearer token auth:

```csharp
var client = new HeliconeClient(apiKey); // HELICONE_API_KEY env var
```

## Key Files

- `src/libs/Helicone/openapi.yaml` — OpenAPI spec (downloaded from Helicone/helicone)
- `src/libs/Helicone/generate.sh` — Downloads spec, fixes equals→eq rename, runs autosdk with `--security-scheme Http:Header:Bearer`, fixes namespace
- `src/libs/Helicone/Generated/` — **Never edit** — auto-generated code (~2800 files)
- `src/tests/IntegrationTests/Tests.cs` — Test helper with bearer auth
- `src/tests/IntegrationTests/Examples/` — Example tests (also generate docs)

## Spec Notes

- `--security-scheme Http:Header:Bearer` overrides the spec's apiKey auth at generation time (no jq auth patching needed)
- Post-generation `sed` fix: replaces `namespace System` with `namespace Helicone` in `JsonSerializerContextTypes` (AutoSDK codegen bug)
- Uses `--exclude-deprecated-operations` flag

## Sub-client Pattern

Helicone API has tagged operations generating sub-clients:
- `client.Request.*` — Request querying and management
- `client.Trace.*` — Trace management
- `client.Session.*` — Session management
- `client.Prompt.*` — Prompt management (legacy)
- `client.Prompt2025.*` — Prompt management (2025 version)
- `client.Prompt2025V2.*` — Prompt management (2025 v2)
- `client.Dataset.*` — Dataset management
- `client.Experiment.*` — Experiment management
- `client.Evaluator.*` — Evaluator management
- `client.Evals.*` — Evaluation management
- `client.Agent.*` — Agent management
- `client.Dashboard.*` — Dashboard management
- `client.Metrics.*` — Metrics and analytics
- `client.Stats.*` — Statistics
- `client.HeliconeSql.*` — SQL query interface
- `client.Playground.*` — Playground for testing prompts
- `client.Customer.*` — Customer management
- `client.Property.*` — Property management
- `client.Comparison.*` — Request comparison
- `client.Providers.*` — Provider configuration
- `client.ModelRegistry.*` — Model registry
- `client.Models.*` — Model management
- `client.Integration.*` — Integration management
- `client.Webhooks.*` — Webhook management
- `client.ApiKey.*` — API key management
- `client.Vault.*` — Secret vault management
- `client.User.*` — User management
- `client.Security.*` — Security settings
- `client.Credits.*` — Credit management
- `client.Stripe.*` — Stripe billing integration
- `client.Pi.*` — Pi analytics
- `client.Wrapped.*` — Year-in-review wrapped data
- `client.Status.*` — System status
- `client.Waitlist.*` — Waitlist management

## MEAI

No MEAI interface implemented — Helicone is an LLM observability/monitoring platform with no matching MEAI interface.
