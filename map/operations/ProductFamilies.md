<!-- Generated file — do not edit; regenerated with the SDK. -->

# ProductFamilies — operations

Accessor: `client.ProductFamilies` · Source: `src/Maxio/Api/ProductFamilies.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateProductFamily

- **Auth**: `options.BasicAuth`
- **Signature**: `CreateProductFamily(CreateProductFamilyOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `ProductFamilyResponse`
- **Error**: `ApiException<CreateProductFamilyError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreateProductFamilyOperationRequest` | `src/Maxio/Requests/ProductFamilies/CreateProductFamilyOperationRequest.cs` |
| `CreateProductFamilyRequest` | `src/Maxio/Models/CreateProductFamilyRequest.cs` |
| `ProductFamilyResponse` | `src/Maxio/Models/ProductFamilyResponse.cs` |
| `CreateProductFamilyError` | `src/Maxio/Errors/CreateProductFamilyError.cs` |
| `ErrorListResponse1` | `src/Maxio/Models/ErrorListResponse1.cs` |

### ListProductFamilies

- **Auth**: `options.BasicAuth`
- **Signature**: `ListProductFamilies(ListProductFamiliesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `date_field` ← `DateField`, `start_date` ← `StartDate`, `end_date` ← `EndDate`, `start_datetime` ← `StartDatetime`, `end_datetime` ← `EndDatetime`
- **Returns**: `IReadOnlyList<ProductFamilyResponse>`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListProductFamiliesRequest` | `src/Maxio/Requests/ProductFamilies/ListProductFamiliesRequest.cs` |
| `BasicDateField` | `src/Maxio/Models/Enums/BasicDateField.cs` |
| `ProductFamilyResponse` | `src/Maxio/Models/ProductFamilyResponse.cs` |

### ListProductsForProductFamily

- **Auth**: `options.BasicAuth`
- **Signature**: `ListProductsForProductFamily(ListProductsForProductFamilyRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProductFamilyId`
- **Query params (wire ← C#)**: `page` ← `Page`, `per_page` ← `PerPage`, `date_field` ← `DateField`, `filter` ← `Filter`, `start_date` ← `StartDate`, `end_date` ← `EndDate`, `start_datetime` ← `StartDatetime`, `end_datetime` ← `EndDatetime`, `include_archived` ← `IncludeArchived`, `include` ← `Include`
- **Returns**: `IReadOnlyList<ProductResponse>`
- **Error**: `ApiException<ListProductsForProductFamilyError>` — **Case A (typed)**
- **Error accessors**: `TryGetString(out string)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ListProductsForProductFamilyRequest` | `src/Maxio/Requests/ProductFamilies/ListProductsForProductFamilyRequest.cs` |
| `BasicDateField` | `src/Maxio/Models/Enums/BasicDateField.cs` |
| `ListProductsFilter` | `src/Maxio/Models/ListProductsFilter.cs` |
| `ListProductsInclude` | `src/Maxio/Models/Enums/ListProductsInclude.cs` |
| `ProductResponse` | `src/Maxio/Models/ProductResponse.cs` |
| `ListProductsForProductFamilyError` | `src/Maxio/Errors/ListProductsForProductFamilyError.cs` |

### ReadProductFamily

- **Auth**: `options.BasicAuth`
- **Signature**: `ReadProductFamily(ReadProductFamilyRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `ProductFamilyResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ReadProductFamilyRequest` | `src/Maxio/Requests/ProductFamilies/ReadProductFamilyRequest.cs` |
| `ProductFamilyResponse` | `src/Maxio/Models/ProductFamilyResponse.cs` |

