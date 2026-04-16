namespace Ferremundo.Integrations.TrackLink.Contracts.Routes.Responses;

public sealed class TrackLinkProviderRouteErrorResponse
{
    public string Route { get; set; } = string.Empty;

    public string Field { get; set; } = string.Empty;

    public string Type { get; set; } = string.Empty;

    public string Error { get; set; } = string.Empty;
}
