using System.Threading.Tasks;
using Maxio.Core.ErrorResponse;
using Maxio.Core.Models;

namespace Maxio.Errors;

public sealed class ReadAdvanceInvoiceError : ApiError
{
    private readonly Optional<RawError> _noContentValue;

    private ReadAdvanceInvoiceError(Optional<RawError> noContentValue, Optional<RawError> fallback) : base(fallback)
    {
        _noContentValue = noContentValue;
    }

    private static ReadAdvanceInvoiceError AsNoContent(RawError value) => new(Optional<RawError>.Some(value), default);

    private static ReadAdvanceInvoiceError AsFallback(RawError value) => new(default, Optional<RawError>.Some(value));

    public bool TryGetNoContent(out RawError value) => _noContentValue.TryGetValue(out value);

    private static Task<ReadAdvanceInvoiceError> Create(FailedResponse response) =>
        response.StatusCode switch
        {
            404 => response.RawBody().As(AsNoContent),
            _ => response.RawBody().As(AsFallback)
        };

    internal static ApiErrorResponse<ReadAdvanceInvoiceError> Response { get; } = new(Create);
}
