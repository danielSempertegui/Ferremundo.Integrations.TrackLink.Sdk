using System.ComponentModel.DataAnnotations;

namespace Ferremundo.Integrations.TrackLink.Contracts.Routes.Requests;

public sealed class ImportRoutesRequest
{
    [Required]
    [MinLength(1)]
    public IReadOnlyCollection<ImportRouteRequest> Routes { get; set; } = Array.Empty<ImportRouteRequest>();
}
