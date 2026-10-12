<!-- Generated file — do not edit; regenerated with the SDK. -->

# Products — operations

Accessor: `client.Products` · Source: `src/Maxio/Api/Products.cs` · 6 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### ArchiveProduct

- **Auth**: `options.BasicAuth`
- **Signature**: `ArchiveProduct(ArchiveProductRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProductId`
- **Returns**: `ProductResponse`
- **Error**: `ApiException<ArchiveProductError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ArchiveProductRequest` | `src/Maxio/Requests/Products/ArchiveProductRequest.cs` |
| `ProductResponse` | `src/Maxio/Models/ProductResponse.cs` |
| `ArchiveProductError` | `src/Maxio/Errors/ArchiveProductError.cs` |
| `ErrorListResponse1` | `src/Maxio/Models/ErrorListResponse1.cs` |

### CreateProduct

- **Auth**: `options.BasicAuth`
- **Signature**: `CreateProduct(CreateProductRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProductFamilyId`
- **Returns**: `ProductResponse`
- **Error**: `ApiException<CreateProductError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreateProductRequest` | `src/Maxio/Requests/Products/CreateProductRequest.cs` |
| `CreateOrUpdateProductRequest` | `src/Maxio/Models/CreateOrUpdateProductRequest.cs` |
| `ProductResponse` | `src/Maxio/Models/ProductResponse.cs` |
| `CreateProductError` | `src/Maxio/Errors/CreateProductError.cs` |
| `ErrorListResponse1` | `src/Maxio/Models/ErrorListResponse1.cs` |

### ListProducts

- **Auth**: `options.BasicAuth`
- **Signature**: `ListProducts(ListProductsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `date_field` ← `DateField`, `filter` ← `Filter`, `end_date` ← `EndDate`, `end_datetime` ← `EndDatetime`, `start_date` ← `StartDate`, `start_datetime` ← `StartDatetime`, `page` ← `Page`, `per_page` ← `PerPage`, `include_archived` ← `IncludeArchived`, `include` ← `Include`, `include_features` ← `IncludeFeatures`
- **Returns**: `IReadOnlyList<ProductResponse>`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListProductsRequest` | `src/Maxio/Requests/Products/ListProductsRequest.cs` |
| `BasicDateField` | `src/Maxio/Models/Enums/BasicDateField.cs` |
| `ListProductsFilter` | `src/Maxio/Models/ListProductsFilter.cs` |
| `ListProductsInclude` | `src/Maxio/Models/Enums/ListProductsInclude.cs` |
| `ProductResponse` | `src/Maxio/Models/ProductResponse.cs` |

### ReadProduct

- **Auth**: `options.BasicAuth`
- **Signature**: `ReadProduct(ReadProductRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProductId`
- **Query params (wire ← C#)**: `include_features` ← `IncludeFeatures`
- **Returns**: `ProductResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ReadProductRequest` | `src/Maxio/Requests/Products/ReadProductRequest.cs` |
| `ProductResponse` | `src/Maxio/Models/ProductResponse.cs` |

### ReadProductByHandle

- **Auth**: `options.BasicAuth`
- **Signature**: `ReadProductByHandle(ReadProductByHandleRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ApiHandle`
- **Returns**: `ProductResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ReadProductByHandleRequest` | `src/Maxio/Requests/Products/ReadProductByHandleRequest.cs` |
| `ProductResponse` | `src/Maxio/Models/ProductResponse.cs` |

### UpdateProduct

- **Auth**: `options.BasicAuth`
- **Signature**: `UpdateProduct(UpdateProductRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProductId`
- **Returns**: `ProductResponse`
- **Error**: `ApiException<UpdateProductError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdateProductRequest` | `src/Maxio/Requests/Products/UpdateProductRequest.cs` |
| `CreateOrUpdateProductRequest` | `src/Maxio/Models/CreateOrUpdateProductRequest.cs` |
| `ProductResponse` | `src/Maxio/Models/ProductResponse.cs` |
| `UpdateProductError` | `src/Maxio/Errors/UpdateProductError.cs` |
| `ErrorListResponse1` | `src/Maxio/Models/ErrorListResponse1.cs` |

