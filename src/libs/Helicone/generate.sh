dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl -o openapi.yaml https://raw.githubusercontent.com/Helicone/helicone/main/docs/swagger.json

# Fix auth: convert apiKey type to http/bearer and add top-level security array
jq '
  .components.securitySchemes.api_key = {
    "type": "http",
    "scheme": "bearer",
    "description": "Bearer token authentication"
  } |
  .security = [{"api_key": []}]
' openapi.yaml > openapi_fixed.yaml
mv openapi_fixed.yaml openapi.yaml

autosdk generate openapi.yaml \
  --namespace Helicone \
  --clientClassName HeliconeClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations

# Fix: JsonSerializerContextTypes is generated in namespace System instead of Helicone
if [ -f "Generated/Helicone.JsonSerializerContextTypes.g.cs" ]; then
  sed -i '' 's/^namespace System$/namespace Helicone/' Generated/Helicone.JsonSerializerContextTypes.g.cs
fi
