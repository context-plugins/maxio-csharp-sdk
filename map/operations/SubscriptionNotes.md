<!-- Generated file — do not edit; regenerated with the SDK. -->

# SubscriptionNotes — operations

Accessor: `client.SubscriptionNotes` · Source: `Api/SubscriptionNotes.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateSubscriptionNote

- **Auth**: `options.BasicAuth`
- **Signature**: `CreateSubscriptionNote(CreateSubscriptionNoteRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`
- **Returns**: `SubscriptionNoteResponse`
- **Error**: `ApiException<CreateSubscriptionNoteError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreateSubscriptionNoteRequest` | `Requests/SubscriptionNotes/CreateSubscriptionNoteRequest.cs` |
| `UpdateSubscriptionNoteRequest` | `Models/UpdateSubscriptionNoteRequest.cs` |
| `SubscriptionNoteResponse` | `Models/SubscriptionNoteResponse.cs` |
| `CreateSubscriptionNoteError` | `Errors/CreateSubscriptionNoteError.cs` |
| `ErrorListResponse1` | `Models/ErrorListResponse1.cs` |

### DeleteSubscriptionNote

- **Auth**: `options.BasicAuth`
- **Signature**: `DeleteSubscriptionNote(DeleteSubscriptionNoteRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`, `NoteId`
- **Returns**: `void` (Task)
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DeleteSubscriptionNoteRequest` | `Requests/SubscriptionNotes/DeleteSubscriptionNoteRequest.cs` |

### ListSubscriptionNotes

- **Auth**: `options.BasicAuth`
- **Signature**: `ListSubscriptionNotes(ListSubscriptionNotesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`
- **Query params (wire ← C#)**: `page` ← `Page`, `per_page` ← `PerPage`
- **Returns**: `IReadOnlyList<SubscriptionNoteResponse>`
- **Error**: `ApiException<ListSubscriptionNotesError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ListSubscriptionNotesRequest` | `Requests/SubscriptionNotes/ListSubscriptionNotesRequest.cs` |
| `SubscriptionNoteResponse` | `Models/SubscriptionNoteResponse.cs` |
| `ListSubscriptionNotesError` | `Errors/ListSubscriptionNotesError.cs` |
| `ErrorListResponse1` | `Models/ErrorListResponse1.cs` |

### ReadSubscriptionNote

- **Auth**: `options.BasicAuth`
- **Signature**: `ReadSubscriptionNote(ReadSubscriptionNoteRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`, `NoteId`
- **Returns**: `SubscriptionNoteResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ReadSubscriptionNoteRequest` | `Requests/SubscriptionNotes/ReadSubscriptionNoteRequest.cs` |
| `SubscriptionNoteResponse` | `Models/SubscriptionNoteResponse.cs` |

### UpdateSubscriptionNote

- **Auth**: `options.BasicAuth`
- **Signature**: `UpdateSubscriptionNote(UpdateSubscriptionNoteOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`, `NoteId`
- **Returns**: `SubscriptionNoteResponse`
- **Error**: `ApiException<UpdateSubscriptionNoteError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdateSubscriptionNoteOperationRequest` | `Requests/SubscriptionNotes/UpdateSubscriptionNoteOperationRequest.cs` |
| `UpdateSubscriptionNoteRequest` | `Models/UpdateSubscriptionNoteRequest.cs` |
| `SubscriptionNoteResponse` | `Models/SubscriptionNoteResponse.cs` |
| `UpdateSubscriptionNoteError` | `Errors/UpdateSubscriptionNoteError.cs` |
| `ErrorListResponse1` | `Models/ErrorListResponse1.cs` |

