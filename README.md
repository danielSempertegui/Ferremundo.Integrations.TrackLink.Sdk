# Ferremundo.Integrations.TrackLink.Sdk

Reusable SDK for `Ferremundo.Integrations.TrackLink`.

## Structure

- `Contracts`: shared requests, responses, `ResponseBase<T>`, and response codes.
- `Client`: typed HTTP client for the Ferremundo TrackLink integration API.

## Notes

- The SDK does not expose the provider login endpoint.
- The SDK forwards the incoming Ferremundo JWT through its replaceable token-provider pattern.
- The API itself is responsible for authenticating against the TrackLink provider.

## Restore

```powershell
dotnet restore .\src\Ferremundo.Integrations.TrackLink.Client\Ferremundo.Integrations.TrackLink.Client.csproj
```
