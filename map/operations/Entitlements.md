<!-- Generated file — do not edit; regenerated with the SDK. -->

# Entitlements — operations

Accessor: `client.Entitlements` · Source: `src/Maxio/Api/Entitlements.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### ReadSubscriptionEntitlements

- **Auth**: `options.BasicAuth`
- **Signature**: `ReadSubscriptionEntitlements(ReadSubscriptionEntitlementsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`
- **Returns**: `AggregatedEntitlementsResponse`
- **Error**: `ApiException<ReadSubscriptionEntitlementsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [403] · `TryGetNoContent(out RawError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ReadSubscriptionEntitlementsRequest` | `src/Maxio/Requests/Entitlements/ReadSubscriptionEntitlementsRequest.cs` |
| `AggregatedEntitlementsResponse` | `src/Maxio/Models/AggregatedEntitlementsResponse.cs` |
| `ReadSubscriptionEntitlementsError` | `src/Maxio/Errors/ReadSubscriptionEntitlementsError.cs` |
| `ErrorListResponse1` | `src/Maxio/Models/ErrorListResponse1.cs` |

