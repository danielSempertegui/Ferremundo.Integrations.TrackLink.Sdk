namespace Ferremundo.Integrations.TrackLink.Client.Abstractions;

public interface ITrackLinkAccessTokenProvider
{
    ValueTask<string?> GetAccessTokenAsync(CancellationToken cancellationToken = default);
}
