<!-- Generated file — do not edit; regenerated with the SDK. -->

# WebhooksApi — operations

Accessor: `client.WebhooksApi` · Source: `src/Maxio/Api/WebhooksApi.cs` · 6 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateEndpoint

- **Auth**: `options.BasicAuth`
- **Signature**: `CreateEndpoint(CreateEndpointRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `EndpointResponse`
- **Error**: `ApiException<CreateEndpointError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreateEndpointRequest` | `src/Maxio/Requests/WebhooksApi/CreateEndpointRequest.cs` |
| `CreateOrUpdateEndpointRequest` | `src/Maxio/Models/CreateOrUpdateEndpointRequest.cs` |
| `EndpointResponse` | `src/Maxio/Models/EndpointResponse.cs` |
| `CreateEndpointError` | `src/Maxio/Errors/CreateEndpointError.cs` |
| `ErrorListResponse1` | `src/Maxio/Models/ErrorListResponse1.cs` |

### EnableWebhooks

- **Auth**: `options.BasicAuth`
- **Signature**: `EnableWebhooks(EnableWebhooksOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `EnableWebhooksResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `EnableWebhooksOperationRequest` | `src/Maxio/Requests/WebhooksApi/EnableWebhooksOperationRequest.cs` |
| `EnableWebhooksRequest` | `src/Maxio/Models/EnableWebhooksRequest.cs` |
| `EnableWebhooksResponse` | `src/Maxio/Models/EnableWebhooksResponse.cs` |

### ListEndpoints

- **Auth**: `options.BasicAuth`
- **Signature**: `ListEndpoints(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `IReadOnlyList<Endpoint>`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Endpoint` | `src/Maxio/Models/Endpoint.cs` |

### ListWebhooks

- **Auth**: `options.BasicAuth`
- **Signature**: `ListWebhooks(ListWebhooksRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `status` ← `Status`, `since_date` ← `SinceDate`, `until_date` ← `UntilDate`, `page` ← `Page`, `per_page` ← `PerPage`, `order` ← `Order`, `subscription` ← `Subscription`
- **Returns**: `IReadOnlyList<WebhookResponse>`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListWebhooksRequest` | `src/Maxio/Requests/WebhooksApi/ListWebhooksRequest.cs` |
| `WebhookStatus` | `src/Maxio/Models/Enums/WebhookStatus.cs` |
| `WebhookOrder` | `src/Maxio/Models/Enums/WebhookOrder.cs` |
| `WebhookResponse` | `src/Maxio/Models/WebhookResponse.cs` |

### ReplayWebhooks

- **Auth**: `options.BasicAuth`
- **Signature**: `ReplayWebhooks(ReplayWebhooksOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `ReplayWebhooksResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ReplayWebhooksOperationRequest` | `src/Maxio/Requests/WebhooksApi/ReplayWebhooksOperationRequest.cs` |
| `ReplayWebhooksRequest` | `src/Maxio/Models/ReplayWebhooksRequest.cs` |
| `ReplayWebhooksResponse` | `src/Maxio/Models/ReplayWebhooksResponse.cs` |

### UpdateEndpoint

- **Auth**: `options.BasicAuth`
- **Signature**: `UpdateEndpoint(UpdateEndpointRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `EndpointId`
- **Returns**: `EndpointResponse`
- **Error**: `ApiException<UpdateEndpointError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404] · `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdateEndpointRequest` | `src/Maxio/Requests/WebhooksApi/UpdateEndpointRequest.cs` |
| `CreateOrUpdateEndpointRequest` | `src/Maxio/Models/CreateOrUpdateEndpointRequest.cs` |
| `EndpointResponse` | `src/Maxio/Models/EndpointResponse.cs` |
| `UpdateEndpointError` | `src/Maxio/Errors/UpdateEndpointError.cs` |
| `ErrorListResponse1` | `src/Maxio/Models/ErrorListResponse1.cs` |

