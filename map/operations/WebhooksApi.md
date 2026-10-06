<!-- Generated file — do not edit; regenerated with the SDK. -->

# WebhooksApi — operations

Accessor: `client.WebhooksApi` · Source: `Api/WebhooksApi.cs` · 6 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateEndpoint

- **Auth**: `options.BasicAuth`
- **Signature**: `CreateEndpoint(CreateEndpointRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `EndpointResponse`
- **Error**: `ApiException<CreateEndpointError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreateEndpointRequest` | `Requests/WebhooksApi/CreateEndpointRequest.cs` |
| `CreateOrUpdateEndpointRequest` | `Models/CreateOrUpdateEndpointRequest.cs` |
| `EndpointResponse` | `Models/EndpointResponse.cs` |
| `CreateEndpointError` | `Errors/CreateEndpointError.cs` |
| `ErrorListResponse1` | `Models/ErrorListResponse1.cs` |

### EnableWebhooks

- **Auth**: `options.BasicAuth`
- **Signature**: `EnableWebhooks(EnableWebhooksOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `EnableWebhooksResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `EnableWebhooksOperationRequest` | `Requests/WebhooksApi/EnableWebhooksOperationRequest.cs` |
| `EnableWebhooksRequest` | `Models/EnableWebhooksRequest.cs` |
| `EnableWebhooksResponse` | `Models/EnableWebhooksResponse.cs` |

### ListEndpoints

- **Auth**: `options.BasicAuth`
- **Signature**: `ListEndpoints(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `IReadOnlyList<Endpoint>`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Endpoint` | `Models/Endpoint.cs` |

### ListWebhooks

- **Auth**: `options.BasicAuth`
- **Signature**: `ListWebhooks(ListWebhooksRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `status` ← `Status`, `since_date` ← `SinceDate`, `until_date` ← `UntilDate`, `page` ← `Page`, `per_page` ← `PerPage`, `order` ← `Order`, `subscription` ← `Subscription`
- **Returns**: `IReadOnlyList<WebhookResponse>`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListWebhooksRequest` | `Requests/WebhooksApi/ListWebhooksRequest.cs` |
| `WebhookStatus` | `Models/Enums/WebhookStatus.cs` |
| `WebhookOrder` | `Models/Enums/WebhookOrder.cs` |
| `WebhookResponse` | `Models/WebhookResponse.cs` |

### ReplayWebhooks

- **Auth**: `options.BasicAuth`
- **Signature**: `ReplayWebhooks(ReplayWebhooksOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `ReplayWebhooksResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ReplayWebhooksOperationRequest` | `Requests/WebhooksApi/ReplayWebhooksOperationRequest.cs` |
| `ReplayWebhooksRequest` | `Models/ReplayWebhooksRequest.cs` |
| `ReplayWebhooksResponse` | `Models/ReplayWebhooksResponse.cs` |

### UpdateEndpoint

- **Auth**: `options.BasicAuth`
- **Signature**: `UpdateEndpoint(UpdateEndpointRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `EndpointId`
- **Returns**: `EndpointResponse`
- **Error**: `ApiException<UpdateEndpointError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404] · `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdateEndpointRequest` | `Requests/WebhooksApi/UpdateEndpointRequest.cs` |
| `CreateOrUpdateEndpointRequest` | `Models/CreateOrUpdateEndpointRequest.cs` |
| `EndpointResponse` | `Models/EndpointResponse.cs` |
| `UpdateEndpointError` | `Errors/UpdateEndpointError.cs` |
| `ErrorListResponse1` | `Models/ErrorListResponse1.cs` |

