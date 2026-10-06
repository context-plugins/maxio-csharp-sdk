<!-- Generated file — do not edit; regenerated with the SDK. -->

# ReasonCodes — operations

Accessor: `client.ReasonCodes` · Source: `Api/ReasonCodes.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateReasonCode

- **Auth**: `options.BasicAuth`
- **Signature**: `CreateReasonCode(CreateReasonCodeOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `ReasonCodeResponse`
- **Error**: `ApiException<CreateReasonCodeError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreateReasonCodeOperationRequest` | `Requests/ReasonCodes/CreateReasonCodeOperationRequest.cs` |
| `CreateReasonCodeRequest` | `Models/CreateReasonCodeRequest.cs` |
| `ReasonCodeResponse` | `Models/ReasonCodeResponse.cs` |
| `CreateReasonCodeError` | `Errors/CreateReasonCodeError.cs` |
| `ErrorListResponse1` | `Models/ErrorListResponse1.cs` |

### DeleteReasonCode

- **Auth**: `options.BasicAuth`
- **Signature**: `DeleteReasonCode(DeleteReasonCodeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ReasonCodeId`
- **Returns**: `OkResponse`
- **Error**: `ApiException<DeleteReasonCodeError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteReasonCodeRequest` | `Requests/ReasonCodes/DeleteReasonCodeRequest.cs` |
| `OkResponse` | `Models/OkResponse.cs` |
| `DeleteReasonCodeError` | `Errors/DeleteReasonCodeError.cs` |

### ListReasonCodes

- **Auth**: `options.BasicAuth`
- **Signature**: `ListReasonCodes(ListReasonCodesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page` ← `Page`, `per_page` ← `PerPage`
- **Returns**: `IReadOnlyList<ReasonCodeResponse>`
- **Error**: `ApiException<ListReasonCodesError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ListReasonCodesRequest` | `Requests/ReasonCodes/ListReasonCodesRequest.cs` |
| `ReasonCodeResponse` | `Models/ReasonCodeResponse.cs` |
| `ListReasonCodesError` | `Errors/ListReasonCodesError.cs` |
| `ErrorListResponse1` | `Models/ErrorListResponse1.cs` |

### ReadReasonCode

- **Auth**: `options.BasicAuth`
- **Signature**: `ReadReasonCode(ReadReasonCodeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ReasonCodeId`
- **Returns**: `ReasonCodeResponse`
- **Error**: `ApiException<ReadReasonCodeError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ReadReasonCodeRequest` | `Requests/ReasonCodes/ReadReasonCodeRequest.cs` |
| `ReasonCodeResponse` | `Models/ReasonCodeResponse.cs` |
| `ReadReasonCodeError` | `Errors/ReadReasonCodeError.cs` |

### UpdateReasonCode

- **Auth**: `options.BasicAuth`
- **Signature**: `UpdateReasonCode(UpdateReasonCodeOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ReasonCodeId`
- **Returns**: `ReasonCodeResponse`
- **Error**: `ApiException<UpdateReasonCodeError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404] · `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdateReasonCodeOperationRequest` | `Requests/ReasonCodes/UpdateReasonCodeOperationRequest.cs` |
| `UpdateReasonCodeRequest` | `Models/UpdateReasonCodeRequest.cs` |
| `ReasonCodeResponse` | `Models/ReasonCodeResponse.cs` |
| `UpdateReasonCodeError` | `Errors/UpdateReasonCodeError.cs` |
| `ErrorListResponse1` | `Models/ErrorListResponse1.cs` |

