using System.Threading.Tasks;
using Maxio.Core.ErrorResponse;
using Maxio.Core.Models;

namespace Maxio.Errors;

public sealed class ReadProformaInvoiceError : ApiError
{
    private readonly Optional<RawError> _noContentValue;

    private ReadProformaInvoiceError(Optional<RawError> noContentValue, Optional<RawError> fallback) : base(fallback)
    {
        _noContentValue = noContentValue;
    }

    private static ReadProformaInvoiceError AsNoContent(RawError value) => new(Optional<RawError>.Some(value), default);

    private static ReadProformaInvoiceError AsFallback(RawError value) => new(default, Optional<RawError>.Some(value));

    public bool TryGetNoContent(out RawError value) => _noContentValue.TryGetValue(out value);

    private static Task<ReadProformaInvoiceError> Create(FailedResponse response) =>
        response.StatusCode switch
        {
            404 => response.RawBody().As(AsNoContent),
            _ => response.RawBody().As(AsFallback)
        };

    internal static ApiErrorResponse<ReadProformaInvoiceError> Response { get; } = new(Create);
}
