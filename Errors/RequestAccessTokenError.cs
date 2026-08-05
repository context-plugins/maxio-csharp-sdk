using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using MaxioAdvancedBilling.Core.ErrorResponse;
using MaxioAdvancedBilling.Core.Models;
using MaxioAdvancedBilling.Models;

namespace MaxioAdvancedBilling.Errors;

public sealed class RequestAccessTokenError : ApiError
{
    private readonly Optional<MaxioGatewayOauthError> _maxioGatewayOauthErrorValue;

    private RequestAccessTokenError(Optional<MaxioGatewayOauthError> maxioGatewayOauthErrorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _maxioGatewayOauthErrorValue = maxioGatewayOauthErrorValue;
    }

    private static RequestAccessTokenError AsMaxioGatewayOauthError(MaxioGatewayOauthError value) =>
        new(Optional<MaxioGatewayOauthError>.Some(value), default);

    private static RequestAccessTokenError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetMaxioGatewayOauthError(out MaxioGatewayOauthError value) =>
        _maxioGatewayOauthErrorValue.TryGetValue(out value);

    internal static Task<RequestAccessTokenError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<MaxioGatewayOauthError>(response, ct).As(AsMaxioGatewayOauthError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class RequestAccessTokenErrorResponse : IErrorResponse<RequestAccessTokenError>
{
    public static RequestAccessTokenErrorResponse Instance { get; } = new();

    private RequestAccessTokenErrorResponse()
    {
    }

    public Task<RequestAccessTokenError> Map(HttpResponseMessage response, CancellationToken ct) =>
        RequestAccessTokenError.Create(response, ct);
}
