<!-- Generated file — do not edit; regenerated with the SDK. -->

# ProductFamilies — operations

Accessor: `client.ProductFamilies` · Source: `Api/ProductFamilies.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateProductFamily

- **Auth**: `options.BasicAuth`
- **Signature**: `CreateProductFamily(CreateProductFamilyOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `ProductFamilyResponse`
- **Error**: `ApiException<CreateProductFamilyError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreateProductFamilyOperationRequest` | `Requests/ProductFamilies/CreateProductFamilyOperationRequest.cs` |
| `CreateProductFamilyRequest` | `Models/CreateProductFamilyRequest.cs` |
| `ProductFamilyResponse` | `Models/ProductFamilyResponse.cs` |
| `CreateProductFamilyError` | `Errors/CreateProductFamilyError.cs` |
| `ErrorListResponse1` | `Models/ErrorListResponse1.cs` |

### ListProductFamilies

- **Auth**: `options.BasicAuth`
- **Signature**: `ListProductFamilies(ListProductFamiliesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `date_field` ← `DateField`, `start_date` ← `StartDate`, `end_date` ← `EndDate`, `start_datetime` ← `StartDatetime`, `end_datetime` ← `EndDatetime`
- **Returns**: `IReadOnlyList<ProductFamilyResponse>`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListProductFamiliesRequest` | `Requests/ProductFamilies/ListProductFamiliesRequest.cs` |
| `BasicDateField` | `Models/Enums/BasicDateField.cs` |
| `ProductFamilyResponse` | `Models/ProductFamilyResponse.cs` |

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
| `ListProductsForProductFamilyRequest` | `Requests/ProductFamilies/ListProductsForProductFamilyRequest.cs` |
| `BasicDateField` | `Models/Enums/BasicDateField.cs` |
| `ListProductsFilter` | `Models/ListProductsFilter.cs` |
| `ListProductsInclude` | `Models/Enums/ListProductsInclude.cs` |
| `ProductResponse` | `Models/ProductResponse.cs` |
| `ListProductsForProductFamilyError` | `Errors/ListProductsForProductFamilyError.cs` |

### ReadProductFamily

- **Auth**: `options.BasicAuth`
- **Signature**: `ReadProductFamily(ReadProductFamilyRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `ProductFamilyResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ReadProductFamilyRequest` | `Requests/ProductFamilies/ReadProductFamilyRequest.cs` |
| `ProductFamilyResponse` | `Models/ProductFamilyResponse.cs` |

