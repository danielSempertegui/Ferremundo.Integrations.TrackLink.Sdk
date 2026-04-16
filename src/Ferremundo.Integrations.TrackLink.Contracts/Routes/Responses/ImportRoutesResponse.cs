namespace Ferremundo.Integrations.TrackLink.Contracts.Routes.Responses;

public sealed class ImportRoutesResponse
{
    public IReadOnlyCollection<TrackLinkProviderRouteErrorResponse> Errors { get; set; } = Array.Empty<TrackLinkProviderRouteErrorResponse>();

    public IReadOnlyCollection<TrackLinkTemplateResponse> Templates { get; set; } = Array.Empty<TrackLinkTemplateResponse>();

    public IReadOnlyCollection<TrackLinkRouteSummaryResponse> Routes { get; set; } = Array.Empty<TrackLinkRouteSummaryResponse>();

    public bool HasProviderErrors => Errors.Count > 0;
}
