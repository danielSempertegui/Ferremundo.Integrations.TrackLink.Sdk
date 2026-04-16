namespace Ferremundo.Integrations.TrackLink.Contracts.Routes.Responses;

public sealed class TrackLinkTemplateResponse
{
    public string Id { get; set; } = string.Empty;

    public string Name { get; set; } = string.Empty;

    public string CompanyId { get; set; } = string.Empty;

    public bool BackToStart { get; set; }
}
