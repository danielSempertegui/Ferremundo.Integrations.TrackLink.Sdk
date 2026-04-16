using Ferremundo.Integrations.Rest.Authentication;
using Ferremundo.Integrations.TrackLink.Client.Abstractions;

namespace Ferremundo.Integrations.TrackLink.Client.Authentication;

public sealed class TrackLinkClientAuthenticationStrategy : ITrackLinkClientAuthenticationStrategy
{
    private readonly BearerTokenAuthenticationStrategy _innerStrategy;

    public TrackLinkClientAuthenticationStrategy(ITrackLinkAccessTokenProvider accessTokenProvider)
    {
        _innerStrategy = new BearerTokenAuthenticationStrategy(new TrackLinkAccessTokenProviderAdapter(accessTokenProvider));
    }

    public Task ApplyAsync(HttpRequestMessage request, CancellationToken cancellationToken = default)
        => _innerStrategy.ApplyAsync(request, cancellationToken);
}
