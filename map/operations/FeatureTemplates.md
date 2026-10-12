<!-- Generated file — do not edit; regenerated with the SDK. -->

# FeatureTemplates — operations

Accessor: `client.FeatureTemplates` · Source: `src/Maxio/Api/FeatureTemplates.cs` · 6 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### ArchiveFeatureTemplate

- **Auth**: `options.BasicAuth`
- **Signature**: `ArchiveFeatureTemplate(ArchiveFeatureTemplateRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `remove_from_catalog` ← `RemoveFromCatalog`
- **Returns**: `void` (Task)
- **Error**: `ApiException<ArchiveFeatureTemplateError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [403] · `TryGetNoContent(out RawError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ArchiveFeatureTemplateRequest` | `src/Maxio/Requests/FeatureTemplates/ArchiveFeatureTemplateRequest.cs` |
| `ArchiveFeatureTemplateError` | `src/Maxio/Errors/ArchiveFeatureTemplateError.cs` |
| `ErrorListResponse1` | `src/Maxio/Models/ErrorListResponse1.cs` |

### CreateFeatureTemplate

- **Auth**: `options.BasicAuth`
- **Signature**: `CreateFeatureTemplate(CreateFeatureTemplateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `FeatureTemplateResponse`
- **Error**: `ApiException<CreateFeatureTemplateError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [403, 422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreateFeatureTemplateOperationRequest` | `src/Maxio/Requests/FeatureTemplates/CreateFeatureTemplateOperationRequest.cs` |
| `CreateFeatureTemplateRequest` | `src/Maxio/Models/CreateFeatureTemplateRequest.cs` |
| `FeatureTemplateResponse` | `src/Maxio/Models/FeatureTemplateResponse.cs` |
| `CreateFeatureTemplateError` | `src/Maxio/Errors/CreateFeatureTemplateError.cs` |
| `ErrorListResponse1` | `src/Maxio/Models/ErrorListResponse1.cs` |

### ListFeatureTemplates

- **Auth**: `options.BasicAuth`
- **Signature**: `ListFeatureTemplates(ListFeatureTemplatesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page` ← `Page`, `per_page` ← `PerPage`, `status` ← `Status`, `q` ← `Q`, `kind` ← `Kind`, `updated_from` ← `UpdatedFrom`, `updated_to` ← `UpdatedTo`, `sort_by` ← `SortBy`, `sort_direction` ← `SortDirection`
- **Returns**: `FeatureTemplatesListResponse`
- **Error**: `ApiException<ListFeatureTemplatesError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [403] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ListFeatureTemplatesRequest` | `src/Maxio/Requests/FeatureTemplates/ListFeatureTemplatesRequest.cs` |
| `Status1` | `src/Maxio/Models/Enums/Status1.cs` |
| `Kind` | `src/Maxio/Models/Enums/Kind.cs` |
| `SortBy` | `src/Maxio/Models/Enums/SortBy.cs` |
| `SortDirection` | `src/Maxio/Models/Enums/SortDirection.cs` |
| `FeatureTemplatesListResponse` | `src/Maxio/Models/FeatureTemplatesListResponse.cs` |
| `ListFeatureTemplatesError` | `src/Maxio/Errors/ListFeatureTemplatesError.cs` |
| `ErrorListResponse1` | `src/Maxio/Models/ErrorListResponse1.cs` |

### ReadFeatureTemplate

- **Auth**: `options.BasicAuth`
- **Signature**: `ReadFeatureTemplate(ReadFeatureTemplateRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `FeatureTemplateResponse`
- **Error**: `ApiException<ReadFeatureTemplateError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [403] · `TryGetNoContent(out RawError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ReadFeatureTemplateRequest` | `src/Maxio/Requests/FeatureTemplates/ReadFeatureTemplateRequest.cs` |
| `FeatureTemplateResponse` | `src/Maxio/Models/FeatureTemplateResponse.cs` |
| `ReadFeatureTemplateError` | `src/Maxio/Errors/ReadFeatureTemplateError.cs` |
| `ErrorListResponse1` | `src/Maxio/Models/ErrorListResponse1.cs` |

### RestoreFeatureTemplate

- **Auth**: `options.BasicAuth`
- **Signature**: `RestoreFeatureTemplate(RestoreFeatureTemplateRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `FeatureTemplateResponse`
- **Error**: `ApiException<RestoreFeatureTemplateError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [403, 422] · `TryGetNoContent(out RawError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `RestoreFeatureTemplateRequest` | `src/Maxio/Requests/FeatureTemplates/RestoreFeatureTemplateRequest.cs` |
| `FeatureTemplateResponse` | `src/Maxio/Models/FeatureTemplateResponse.cs` |
| `RestoreFeatureTemplateError` | `src/Maxio/Errors/RestoreFeatureTemplateError.cs` |
| `ErrorListResponse1` | `src/Maxio/Models/ErrorListResponse1.cs` |

### UpdateFeatureTemplate

- **Auth**: `options.BasicAuth`
- **Signature**: `UpdateFeatureTemplate(UpdateFeatureTemplateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `FeatureTemplateResponse`
- **Error**: `ApiException<UpdateFeatureTemplateError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [403, 422] · `TryGetNoContent(out RawError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdateFeatureTemplateOperationRequest` | `src/Maxio/Requests/FeatureTemplates/UpdateFeatureTemplateOperationRequest.cs` |
| `UpdateFeatureTemplateRequest` | `src/Maxio/Models/UpdateFeatureTemplateRequest.cs` |
| `FeatureTemplateResponse` | `src/Maxio/Models/FeatureTemplateResponse.cs` |
| `UpdateFeatureTemplateError` | `src/Maxio/Errors/UpdateFeatureTemplateError.cs` |
| `ErrorListResponse1` | `src/Maxio/Models/ErrorListResponse1.cs` |

