namespace Ferremundo.Integrations.TrackLink.Client.Configuration;

public sealed class TrackLinkClientOptions
{
    public const string SectionName = "TrackLinkClient";

    public string BaseUrl { get; set; } = default!;

    public int TimeoutSeconds { get; set; } = 100;

    public int RetryCount { get; set; }

    public int RetryDelayMilliseconds { get; set; } = 250;

    public string CorrelationHeaderName { get; set; } = "X-Correlation-Id";
}
