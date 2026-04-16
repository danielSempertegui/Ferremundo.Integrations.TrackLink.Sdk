using Ferremundo.Integrations.Rest.Abstractions.Authentication;
using Ferremundo.Integrations.TrackLink.Client.Abstractions;

namespace Ferremundo.Integrations.TrackLink.Client.Authentication;

public sealed class TrackLinkAccessTokenProviderAdapter : IAccessTokenProvider
{
    private readonly ITrackLinkAccessTokenProvider _innerProvider;

    public TrackLinkAccessTokenProviderAdapter(ITrackLinkAccessTokenProvider innerProvider)
    {
        _innerProvider = innerProvider;
    }

    public async Task<string?> GetAccessTokenAsync(CancellationToken cancellationToken = default)
        => await _innerProvider.GetAccessTokenAsync(cancellationToken);
}
