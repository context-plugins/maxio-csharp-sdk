using System.Threading;
using System.Threading.Tasks;
using Maxio.Core.Models;

namespace Maxio.Core.ErrorResponse;

internal interface IErrorResponse<TError>
{
    Task<TError> Map(ResponseContext context, CancellationToken cancellationToken);
}