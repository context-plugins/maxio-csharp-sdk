using Maxio.Core.Authentication;
using Maxio.Core.Authentication.Basic;

namespace Maxio;

internal sealed class AuthSchemes
{
    public IAuthScheme BasicAuth { get; }

    public AuthSchemes(MaxioClientOptions options)
    {
        BasicAuth = BasicAuthScheme.Create(options.BasicAuth);
    }
}
