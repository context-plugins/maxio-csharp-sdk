using System;
using System.Collections.Generic;
using Maxio.Core.Authentication.Basic;
using Maxio.Core.Configuration;
using Maxio.Core.Hooks;
using Maxio.Servers;

namespace Maxio;

public class MaxioClientOptions
{
    public ServerEnvironment Environment { get; set; } = ServerEnvironment.Default();
    public RetryOptions Retry { get; set; } = RetryOptions.Default();
    public LoggingOptions Logging { get; set; } = new();
    public TimeProvider TimeProvider { get; set; } = TimeProvider.System;
    public ServerOptions Server { get; set; } = new();
    /// <summary>
    /// Maximum time to wait for the next frame of a streaming (SSE) response before the stream is
    /// torn down with a timeout. Bounds only the wait for the server between frames, never the
    /// caller's own processing time. Set to null to wait indefinitely.
    /// </summary>
    public TimeSpan? StreamReadTimeout { get; set; } = TimeSpan.FromSeconds(60);
    public IReadOnlyList<SdkHook> Hooks { get; set; } = [];
    /// <summary>
    /// The <c>username</c> is a Maxio Chargify API key. The <c>password</c> is <c>x</c>.
    /// </summary>
    public BasicAuthCredentials? BasicAuth { get; set; }
}
