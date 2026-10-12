using System.Threading.Tasks;
using Maxio.Core.ErrorResponse;
using Maxio.Core.Models;
using Maxio.Models.AnyOf;

namespace Maxio.Errors;

public sealed class DeductServiceCreditError : ApiError
{
    private readonly Optional<DeductServiceCreditErrorResponse> _deductServiceCreditErrorResponseValue;

    private DeductServiceCreditError(Optional<DeductServiceCreditErrorResponse> deductServiceCreditErrorResponseValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _deductServiceCreditErrorResponseValue = deductServiceCreditErrorResponseValue;
    }

    private static DeductServiceCreditError AsDeductServiceCreditErrorResponse(DeductServiceCreditErrorResponse value) =>
        new(Optional<DeductServiceCreditErrorResponse>.Some(value), default);

    private static DeductServiceCreditError AsFallback(RawError value) => new(default, Optional<RawError>.Some(value));

    public bool TryGetDeductServiceCreditErrorResponse(out DeductServiceCreditErrorResponse value) =>
        _deductServiceCreditErrorResponseValue.TryGetValue(out value);

    private static Task<DeductServiceCreditError> Create(FailedResponse response) =>
        response.StatusCode switch
        {
            422 => response.Json<DeductServiceCreditErrorResponse>().As(AsDeductServiceCreditErrorResponse),
            _ => response.RawBody().As(AsFallback)
        };

    internal static ApiErrorResponse<DeductServiceCreditError> Response { get; } = new(Create);
}
