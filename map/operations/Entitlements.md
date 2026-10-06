<!-- Generated file — do not edit; regenerated with the SDK. -->

# Entitlements — operations

Accessor: `client.Entitlements` · Source: `Api/Entitlements.cs` · 1 operation

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
| `ReadSubscriptionEntitlementsRequest` | `Requests/Entitlements/ReadSubscriptionEntitlementsRequest.cs` |
| `AggregatedEntitlementsResponse` | `Models/AggregatedEntitlementsResponse.cs` |
| `ReadSubscriptionEntitlementsError` | `Errors/ReadSubscriptionEntitlementsError.cs` |
| `ErrorListResponse1` | `Models/ErrorListResponse1.cs` |

