using System.Threading.Tasks;
using Maxio.Core.ErrorResponse;
using Maxio.Core.Models;

namespace Maxio.Errors;

public sealed class ReadPaymentProfileError : ApiError
{
    private readonly Optional<RawError> _noContentValue;

    private ReadPaymentProfileError(Optional<RawError> noContentValue, Optional<RawError> fallback) : base(fallback)
    {
        _noContentValue = noContentValue;
    }

    private static ReadPaymentProfileError AsNoContent(RawError value) => new(Optional<RawError>.Some(value), default);

    private static ReadPaymentProfileError AsFallback(RawError value) => new(default, Optional<RawError>.Some(value));

    public bool TryGetNoContent(out RawError value) => _noContentValue.TryGetValue(out value);

    private static Task<ReadPaymentProfileError> Create(FailedResponse response) =>
        response.StatusCode switch
        {
            404 => response.RawBody().As(AsNoContent),
            _ => response.RawBody().As(AsFallback)
        };

    internal static ApiErrorResponse<ReadPaymentProfileError> Response { get; } = new(Create);
}
