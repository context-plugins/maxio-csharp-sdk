using Microsoft.Extensions.Logging;

namespace MaxioAdvancedBilling.Core;

public sealed record RequestOptions
{
    public LogLevel? LogLevel { get; init; }
}
