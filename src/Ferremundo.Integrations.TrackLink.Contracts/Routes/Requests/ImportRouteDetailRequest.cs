using System.ComponentModel.DataAnnotations;

namespace Ferremundo.Integrations.TrackLink.Contracts.Routes.Requests;

public sealed class ImportRouteDetailRequest
{
    [Required]
    public double? DeliveryLatitude { get; set; }

    [Required]
    public double? DeliveryLongitude { get; set; }

    [StringLength(150)]
    public string? CustomerContactName { get; set; }

    [StringLength(150)]
    public string? DeliveryName { get; set; }

    [StringLength(150)]
    public string? DeliveryAddress { get; set; }

    [StringLength(100)]
    public string? DestinationDistributionCenter { get; set; }

    [StringLength(30)]
    public string? CustomerContactPhone { get; set; }

    [EmailAddress]
    [StringLength(150)]
    public string? CustomerContactEmail { get; set; }

    [StringLength(20)]
    public string? TimeFrom { get; set; }

    [StringLength(20)]
    public string? TimeTo { get; set; }

    [StringLength(50)]
    public string? OrderId { get; set; }

    [StringLength(50)]
    public string? ShippingGuideNumber { get; set; }

    [StringLength(50)]
    public string? LoadNumber { get; set; }

    [StringLength(50)]
    public string? ShippingType { get; set; }

    public int? PackagesNumber { get; set; }

    [StringLength(100)]
    public string? Warehouse { get; set; }

    [StringLength(500)]
    public string? Comments { get; set; }

    [StringLength(250)]
    public string? ReferralGuides { get; set; }

    public bool? SavedInDirectory { get; set; }
}
