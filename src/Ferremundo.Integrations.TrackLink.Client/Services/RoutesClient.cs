using Ferremundo.Integrations.Rest;
using Ferremundo.Integrations.Rest.Abstractions.Correlation;
using Ferremundo.Integrations.Rest.Configuration;
using Ferremundo.Integrations.TrackLink.Client.Authentication;
using Ferremundo.Integrations.TrackLink.Client.Configuration;
using Ferremundo.Integrations.TrackLink.Contracts.Common;
using Ferremundo.Integrations.TrackLink.Contracts.Routes.Requests;
using Ferremundo.Integrations.TrackLink.Contracts.Routes.Responses;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Ferremundo.Integrations.TrackLink.Client.Services;

public sealed class RoutesClient : ExternalRestClientBase, IRoutesClient
{
    private const string RoutesEndpoint = "/api/v1/routes";

    public RoutesClient(
        HttpClient httpClient,
        IOptions<TrackLinkClientOptions> options,
        ITrackLinkClientAuthenticationStrategy authenticationStrategy,
        IExternalCorrelationProvider correlationProvider,
        ILogger<RoutesClient> logger)
        : base(
            httpClient,
            BuildExternalRestClientOptions(options.Value),
            authenticationStrategy,
            correlationProvider,
            logger)
    {
    }

    public async Task<ResponseBase<ImportRoutesResponse>> CreateAsync(ImportRoutesRequest request, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(request);

        return await PostAsync<ImportRoutesRequest, ResponseBase<ImportRoutesResponse>>(RoutesEndpoint, request, cancellationToken)
            ?? throw CreateEmptyResponseException();
    }

    private static ExternalRestClientOptions BuildExternalRestClientOptions(TrackLinkClientOptions options)
    {
        ArgumentNullException.ThrowIfNull(options);

        return new ExternalRestClientOptions
        {
            ServiceName = "Ferremundo.Integrations.TrackLink",
            BaseUrl = options.BaseUrl,
            TimeoutSeconds = options.TimeoutSeconds,
            RetryCount = options.RetryCount,
            RetryDelayMilliseconds = options.RetryDelayMilliseconds,
            CorrelationHeaderName = options.CorrelationHeaderName
        };
    }

    private static InvalidOperationException CreateEmptyResponseException()
        => new("The API response could not be deserialized to ResponseBase<ImportRoutesResponse>.");
}
