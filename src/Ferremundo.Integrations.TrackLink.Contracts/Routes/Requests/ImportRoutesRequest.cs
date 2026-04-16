using System.ComponentModel.DataAnnotations;

namespace Ferremundo.Integrations.TrackLink.Contracts.Routes.Requests;

public sealed class ImportRoutesRequest
{
    [Required]
    [StringLength(150)]
    public string RouteName { get; set; } = default!;

    public DateTimeOffset? EarliestDeliveryDate { get; set; }

    public DateTimeOffset? LatestDeliveryDate { get; set; }

    [StringLength(150)]
    public string? DriverName { get; set; }

    [StringLength(30)]
    public string? DriverDocument { get; set; }

    [StringLength(50)]
    public string? VehiclePlate { get; set; }

    [Required]
    [MinLength(1)]
    public IReadOnlyCollection<ImportRouteDetailRequest> Details { get; set; } = Array.Empty<ImportRouteDetailRequest>();
}
