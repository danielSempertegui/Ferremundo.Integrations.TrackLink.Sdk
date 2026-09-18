namespace Ferremundo.Integrations.TrackLink.Contracts.Routes;

public static class TrackLinkRoutesResponseMessages
{
    public const string RoutesImported = "Routes were imported into TrackLink successfully.";
    public const string RoutesImportedWithErrors = "Routes were sent to TrackLink, but the provider reported item-level errors.";
    public const string EmptyProviderResponse = "TrackLink returned an empty response for route import.";
    public const string ProviderAuthenticationFailed = "TrackLink authentication failed while sending the route import request.";
    public const string ProviderAuthorizationFailed = "TrackLink rejected the authentication context used for the route import request.";
    public const string ProviderTimedOut = "TrackLink did not respond in time while importing routes.";
    public const string ProviderUnavailable = "TrackLink is currently unavailable.";
    public const string InvalidProviderResponse = "TrackLink returned a response that could not be processed.";
    public const string ProviderRejectedRequest = "TrackLink rejected the route import request.";

    public static string ProviderRejectedRequestWithDetail(string detail)
        => $"TrackLink rejected the route import request: {detail}.";
}
