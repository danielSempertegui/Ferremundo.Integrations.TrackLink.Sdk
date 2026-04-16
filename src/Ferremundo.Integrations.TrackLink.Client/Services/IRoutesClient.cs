using Ferremundo.Integrations.TrackLink.Contracts.Common;
using Ferremundo.Integrations.TrackLink.Contracts.Routes.Requests;
using Ferremundo.Integrations.TrackLink.Contracts.Routes.Responses;

namespace Ferremundo.Integrations.TrackLink.Client.Services;

public interface IRoutesClient
{
    Task<ResponseBase<ImportRoutesResponse>> CreateAsync(ImportRoutesRequest request, CancellationToken cancellationToken = default);
}
