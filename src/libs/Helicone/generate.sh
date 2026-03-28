dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl -o openapi.yaml https://raw.githubusercontent.com/Helicone/helicone/main/docs/swagger.json

# Fix auth: convert apiKey type to http/bearer and add top-level security array
# Fix CS0108: rename "equals" property to "eq" in operator schemas to avoid shadowing object.Equals()
jq '
  .components.securitySchemes.api_key = {
    "type": "http",
    "scheme": "bearer",
    "description": "Bearer token authentication"
  } |
  .security = [{"api_key": []}] |

  # Rename "equals" → "eq" in any schema properties object (including nested)
  # and update "required" arrays accordingly
  walk(
    if type == "object" and has("properties") and (.properties | has("equals")) then
      .properties.eq = .properties.equals |
      del(.properties.equals) |
      if has("required") then
        .required = [.required[] | if . == "equals" then "eq" else . end]
      else . end
    else . end
  )
' openapi.yaml > openapi_fixed.yaml
mv openapi_fixed.yaml openapi.yaml

autosdk generate openapi.yaml \
  --namespace Helicone \
  --clientClassName HeliconeClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations

# Fix: JsonSerializerContextTypes is generated in namespace System instead of Helicone
for f in Generated/*JsonSerializerContextTypes*; do
  [ -f "$f" ] && sed -i '' 's/^namespace System$/namespace Helicone/' "$f"
done
