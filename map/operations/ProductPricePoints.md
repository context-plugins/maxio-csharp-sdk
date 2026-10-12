<!-- Generated file — do not edit; regenerated with the SDK. -->

# ProductPricePoints — operations

Accessor: `client.ProductPricePoints` · Source: `src/Maxio/Api/ProductPricePoints.cs` · 11 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### ArchiveProductPricePoint

- **Auth**: `options.BasicAuth`
- **Signature**: `ArchiveProductPricePoint(ArchiveProductPricePointRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProductId`, `PricePointId`
- **Returns**: `ProductPricePointResponse`
- **Error**: `ApiException<ArchiveProductPricePointError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ArchiveProductPricePointRequest` | `src/Maxio/Requests/ProductPricePoints/ArchiveProductPricePointRequest.cs` |
| `ProductIdModel` | `src/Maxio/Models/AnyOf/ProductIdModel.cs` |
| `PricePointIdModel` | `src/Maxio/Models/AnyOf/PricePointIdModel.cs` |
| `ProductPricePointResponse` | `src/Maxio/Models/ProductPricePointResponse.cs` |
| `ArchiveProductPricePointError` | `src/Maxio/Errors/ArchiveProductPricePointError.cs` |
| `ErrorListResponse1` | `src/Maxio/Models/ErrorListResponse1.cs` |

### BulkCreateProductPricePoints

- **Auth**: `options.BasicAuth`
- **Signature**: `BulkCreateProductPricePoints(BulkCreateProductPricePointsOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProductId`
- **Returns**: `BulkCreateProductPricePointsResponse`
- **Error**: `ApiException<BulkCreateProductPricePointsError>` — **Case A (typed)**
- **Error accessors**: `TryGetMapOfJsonElement(out IReadOnlyDictionary<string, JsonElement>)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `BulkCreateProductPricePointsOperationRequest` | `src/Maxio/Requests/ProductPricePoints/BulkCreateProductPricePointsOperationRequest.cs` |
| `BulkCreateProductPricePointsRequest` | `src/Maxio/Models/BulkCreateProductPricePointsRequest.cs` |
| `BulkCreateProductPricePointsResponse` | `src/Maxio/Models/BulkCreateProductPricePointsResponse.cs` |
| `BulkCreateProductPricePointsError` | `src/Maxio/Errors/BulkCreateProductPricePointsError.cs` |

### CreateProductCurrencyPrices

- **Auth**: `options.BasicAuth`
- **Signature**: `CreateProductCurrencyPrices(CreateProductCurrencyPricesOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProductPricePointId`
- **Returns**: `CurrencyPricesResponse`
- **Error**: `ApiException<CreateProductCurrencyPricesError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorArrayMapResponse1(out ErrorArrayMapResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreateProductCurrencyPricesOperationRequest` | `src/Maxio/Requests/ProductPricePoints/CreateProductCurrencyPricesOperationRequest.cs` |
| `CreateProductCurrencyPricesRequest` | `src/Maxio/Models/CreateProductCurrencyPricesRequest.cs` |
| `CurrencyPricesResponse` | `src/Maxio/Models/CurrencyPricesResponse.cs` |
| `CreateProductCurrencyPricesError` | `src/Maxio/Errors/CreateProductCurrencyPricesError.cs` |
| `ErrorArrayMapResponse1` | `src/Maxio/Models/ErrorArrayMapResponse1.cs` |

### CreateProductPricePoint

- **Auth**: `options.BasicAuth`
- **Signature**: `CreateProductPricePoint(CreateProductPricePointOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProductId`
- **Returns**: `ProductPricePointResponse`
- **Error**: `ApiException<CreateProductPricePointError>` — **Case A (typed)**
- **Error accessors**: `TryGetProductPricePointErrorResponse1(out ProductPricePointErrorResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreateProductPricePointOperationRequest` | `src/Maxio/Requests/ProductPricePoints/CreateProductPricePointOperationRequest.cs` |
| `ProductIdModel` | `src/Maxio/Models/AnyOf/ProductIdModel.cs` |
| `CreateProductPricePointRequest` | `src/Maxio/Models/CreateProductPricePointRequest.cs` |
| `ProductPricePointResponse` | `src/Maxio/Models/ProductPricePointResponse.cs` |
| `CreateProductPricePointError` | `src/Maxio/Errors/CreateProductPricePointError.cs` |
| `ProductPricePointErrorResponse1` | `src/Maxio/Models/ProductPricePointErrorResponse1.cs` |

### ListAllProductPricePoints

- **Auth**: `options.BasicAuth`
- **Signature**: `ListAllProductPricePoints(ListAllProductPricePointsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `direction` ← `Direction`, `filter` ← `Filter`, `include` ← `Include`, `page` ← `Page`, `per_page` ← `PerPage`
- **Returns**: `ListProductPricePointsResponse`
- **Error**: `ApiException<ListAllProductPricePointsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ListAllProductPricePointsRequest` | `src/Maxio/Requests/ProductPricePoints/ListAllProductPricePointsRequest.cs` |
| `SortingDirection` | `src/Maxio/Models/Enums/SortingDirection.cs` |
| `ListPricePointsFilter` | `src/Maxio/Models/ListPricePointsFilter.cs` |
| `ListProductsPricePointsInclude` | `src/Maxio/Models/Enums/ListProductsPricePointsInclude.cs` |
| `ListProductPricePointsResponse` | `src/Maxio/Models/ListProductPricePointsResponse.cs` |
| `ListAllProductPricePointsError` | `src/Maxio/Errors/ListAllProductPricePointsError.cs` |
| `ErrorListResponse1` | `src/Maxio/Models/ErrorListResponse1.cs` |

### ListProductPricePoints

- **Auth**: `options.BasicAuth`
- **Signature**: `ListProductPricePoints(ListProductPricePointsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProductId`
- **Query params (wire ← C#)**: `page` ← `Page`, `per_page` ← `PerPage`, `currency_prices` ← `CurrencyPrices`, `filter[type]` ← `FilterType`, `archived` ← `Archived`
- **Returns**: `ListProductPricePointsResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListProductPricePointsRequest` | `src/Maxio/Requests/ProductPricePoints/ListProductPricePointsRequest.cs` |
| `ProductIdModel` | `src/Maxio/Models/AnyOf/ProductIdModel.cs` |
| `PricePointType` | `src/Maxio/Models/Enums/PricePointType.cs` |
| `ListProductPricePointsResponse` | `src/Maxio/Models/ListProductPricePointsResponse.cs` |

### PromoteProductPricePointToDefault

- **Auth**: `options.BasicAuth`
- **Signature**: `PromoteProductPricePointToDefault(PromoteProductPricePointToDefaultRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProductId`, `PricePointId`
- **Returns**: `ProductResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PromoteProductPricePointToDefaultRequest` | `src/Maxio/Requests/ProductPricePoints/PromoteProductPricePointToDefaultRequest.cs` |
| `ProductResponse` | `src/Maxio/Models/ProductResponse.cs` |

### ReadProductPricePoint

- **Auth**: `options.BasicAuth`
- **Signature**: `ReadProductPricePoint(ReadProductPricePointRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProductId`, `PricePointId`
- **Query params (wire ← C#)**: `currency_prices` ← `CurrencyPrices`
- **Returns**: `ProductPricePointResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ReadProductPricePointRequest` | `src/Maxio/Requests/ProductPricePoints/ReadProductPricePointRequest.cs` |
| `ProductIdModel` | `src/Maxio/Models/AnyOf/ProductIdModel.cs` |
| `PricePointIdModel` | `src/Maxio/Models/AnyOf/PricePointIdModel.cs` |
| `ProductPricePointResponse` | `src/Maxio/Models/ProductPricePointResponse.cs` |

### UnarchiveProductPricePoint

- **Auth**: `options.BasicAuth`
- **Signature**: `UnarchiveProductPricePoint(UnarchiveProductPricePointRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProductId`, `PricePointId`
- **Returns**: `ProductPricePointResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UnarchiveProductPricePointRequest` | `src/Maxio/Requests/ProductPricePoints/UnarchiveProductPricePointRequest.cs` |
| `ProductPricePointResponse` | `src/Maxio/Models/ProductPricePointResponse.cs` |

### UpdateProductCurrencyPrices

- **Auth**: `options.BasicAuth`
- **Signature**: `UpdateProductCurrencyPrices(UpdateProductCurrencyPricesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProductPricePointId`
- **Returns**: `CurrencyPricesResponse`
- **Error**: `ApiException<UpdateProductCurrencyPricesError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorArrayMapResponse1(out ErrorArrayMapResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdateProductCurrencyPricesRequest` | `src/Maxio/Requests/ProductPricePoints/UpdateProductCurrencyPricesRequest.cs` |
| `UpdateCurrencyPricesRequest` | `src/Maxio/Models/UpdateCurrencyPricesRequest.cs` |
| `CurrencyPricesResponse` | `src/Maxio/Models/CurrencyPricesResponse.cs` |
| `UpdateProductCurrencyPricesError` | `src/Maxio/Errors/UpdateProductCurrencyPricesError.cs` |
| `ErrorArrayMapResponse1` | `src/Maxio/Models/ErrorArrayMapResponse1.cs` |

### UpdateProductPricePoint

- **Auth**: `options.BasicAuth`
- **Signature**: `UpdateProductPricePoint(UpdateProductPricePointOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProductId`, `PricePointId`
- **Returns**: `ProductPricePointResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpdateProductPricePointOperationRequest` | `src/Maxio/Requests/ProductPricePoints/UpdateProductPricePointOperationRequest.cs` |
| `ProductIdModel` | `src/Maxio/Models/AnyOf/ProductIdModel.cs` |
| `PricePointIdModel` | `src/Maxio/Models/AnyOf/PricePointIdModel.cs` |
| `UpdateProductPricePointRequest` | `src/Maxio/Models/UpdateProductPricePointRequest.cs` |
| `ProductPricePointResponse` | `src/Maxio/Models/ProductPricePointResponse.cs` |

