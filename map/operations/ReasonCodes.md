<!-- Generated file — do not edit; regenerated with the SDK. -->

# ReasonCodes — operations

Accessor: `client.ReasonCodes` · Source: `src/Maxio/Api/ReasonCodes.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateReasonCode

- **Auth**: `options.BasicAuth`
- **Signature**: `CreateReasonCode(CreateReasonCodeOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `ReasonCodeResponse`
- **Error**: `ApiException<CreateReasonCodeError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreateReasonCodeOperationRequest` | `src/Maxio/Requests/ReasonCodes/CreateReasonCodeOperationRequest.cs` |
| `CreateReasonCodeRequest` | `src/Maxio/Models/CreateReasonCodeRequest.cs` |
| `ReasonCodeResponse` | `src/Maxio/Models/ReasonCodeResponse.cs` |
| `CreateReasonCodeError` | `src/Maxio/Errors/CreateReasonCodeError.cs` |
| `ErrorListResponse1` | `src/Maxio/Models/ErrorListResponse1.cs` |

### DeleteReasonCode

- **Auth**: `options.BasicAuth`
- **Signature**: `DeleteReasonCode(DeleteReasonCodeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ReasonCodeId`
- **Returns**: `OkResponse`
- **Error**: `ApiException<DeleteReasonCodeError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteReasonCodeRequest` | `src/Maxio/Requests/ReasonCodes/DeleteReasonCodeRequest.cs` |
| `OkResponse` | `src/Maxio/Models/OkResponse.cs` |
| `DeleteReasonCodeError` | `src/Maxio/Errors/DeleteReasonCodeError.cs` |

### ListReasonCodes

- **Auth**: `options.BasicAuth`
- **Signature**: `ListReasonCodes(ListReasonCodesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page` ← `Page`, `per_page` ← `PerPage`
- **Returns**: `IReadOnlyList<ReasonCodeResponse>`
- **Error**: `ApiException<ListReasonCodesError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ListReasonCodesRequest` | `src/Maxio/Requests/ReasonCodes/ListReasonCodesRequest.cs` |
| `ReasonCodeResponse` | `src/Maxio/Models/ReasonCodeResponse.cs` |
| `ListReasonCodesError` | `src/Maxio/Errors/ListReasonCodesError.cs` |
| `ErrorListResponse1` | `src/Maxio/Models/ErrorListResponse1.cs` |

### ReadReasonCode

- **Auth**: `options.BasicAuth`
- **Signature**: `ReadReasonCode(ReadReasonCodeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ReasonCodeId`
- **Returns**: `ReasonCodeResponse`
- **Error**: `ApiException<ReadReasonCodeError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ReadReasonCodeRequest` | `src/Maxio/Requests/ReasonCodes/ReadReasonCodeRequest.cs` |
| `ReasonCodeResponse` | `src/Maxio/Models/ReasonCodeResponse.cs` |
| `ReadReasonCodeError` | `src/Maxio/Errors/ReadReasonCodeError.cs` |

### UpdateReasonCode

- **Auth**: `options.BasicAuth`
- **Signature**: `UpdateReasonCode(UpdateReasonCodeOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ReasonCodeId`
- **Returns**: `ReasonCodeResponse`
- **Error**: `ApiException<UpdateReasonCodeError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404] · `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdateReasonCodeOperationRequest` | `src/Maxio/Requests/ReasonCodes/UpdateReasonCodeOperationRequest.cs` |
| `UpdateReasonCodeRequest` | `src/Maxio/Models/UpdateReasonCodeRequest.cs` |
| `ReasonCodeResponse` | `src/Maxio/Models/ReasonCodeResponse.cs` |
| `UpdateReasonCodeError` | `src/Maxio/Errors/UpdateReasonCodeError.cs` |
| `ErrorListResponse1` | `src/Maxio/Models/ErrorListResponse1.cs` |

