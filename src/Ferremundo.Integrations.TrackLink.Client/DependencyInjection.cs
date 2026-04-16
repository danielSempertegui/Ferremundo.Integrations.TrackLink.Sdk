using Ferremundo.Integrations.Rest;
using Ferremundo.Integrations.TrackLink.Client.Abstractions;
using Ferremundo.Integrations.TrackLink.Client.Authentication;
using Ferremundo.Integrations.TrackLink.Client.Configuration;
using Ferremundo.Integrations.TrackLink.Client.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Options;

namespace Ferremundo.Integrations.TrackLink.Client;

public static class DependencyInjection
{
    public static IServiceCollection AddTrackLinkClient(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddExternalRestSupport();
        services.AddHttpContextAccessor();

        services.TryAddScoped<ITrackLinkAccessTokenProvider, CurrentRequestAccessTokenProvider>();
        services.TryAddScoped<ITrackLinkClientAuthenticationStrategy, TrackLinkClientAuthenticationStrategy>();

        services
            .AddOptions<TrackLinkClientOptions>()
            .Bind(configuration.GetSection(TrackLinkClientOptions.SectionName))
            .Validate(options => !string.IsNullOrWhiteSpace(options.BaseUrl), "TrackLinkClient:BaseUrl is required.")
            .ValidateOnStart();

        services.AddHttpClient<IRoutesClient, RoutesClient>((serviceProvider, httpClient) =>
        {
            var options = serviceProvider.GetRequiredService<IOptions<TrackLinkClientOptions>>().Value;
            httpClient.BaseAddress = new Uri(options.BaseUrl);
        });

        return services;
    }
}
