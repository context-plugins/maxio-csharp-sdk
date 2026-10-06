<!-- Generated file — do not edit; regenerated with the SDK. -->

# ProductPricePoints — operations

Accessor: `client.ProductPricePoints` · Source: `Api/ProductPricePoints.cs` · 11 operations

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
| `ArchiveProductPricePointRequest` | `Requests/ProductPricePoints/ArchiveProductPricePointRequest.cs` |
| `ProductIdModel` | `Models/AnyOf/ProductIdModel.cs` |
| `PricePointIdModel` | `Models/AnyOf/PricePointIdModel.cs` |
| `ProductPricePointResponse` | `Models/ProductPricePointResponse.cs` |
| `ArchiveProductPricePointError` | `Errors/ArchiveProductPricePointError.cs` |
| `ErrorListResponse1` | `Models/ErrorListResponse1.cs` |

### BulkCreateProductPricePoints

- **Auth**: `options.BasicAuth`
- **Signature**: `BulkCreateProductPricePoints(BulkCreateProductPricePointsOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProductId`
- **Returns**: `BulkCreateProductPricePointsResponse`
- **Error**: `ApiException<BulkCreateProductPricePointsError>` — **Case A (typed)**
- **Error accessors**: `TryGetMapOfJsonElement(out IReadOnlyDictionary<string, JsonElement>)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `BulkCreateProductPricePointsOperationRequest` | `Requests/ProductPricePoints/BulkCreateProductPricePointsOperationRequest.cs` |
| `BulkCreateProductPricePointsRequest` | `Models/BulkCreateProductPricePointsRequest.cs` |
| `BulkCreateProductPricePointsResponse` | `Models/BulkCreateProductPricePointsResponse.cs` |
| `BulkCreateProductPricePointsError` | `Errors/BulkCreateProductPricePointsError.cs` |

### CreateProductCurrencyPrices

- **Auth**: `options.BasicAuth`
- **Signature**: `CreateProductCurrencyPrices(CreateProductCurrencyPricesOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProductPricePointId`
- **Returns**: `CurrencyPricesResponse`
- **Error**: `ApiException<CreateProductCurrencyPricesError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorArrayMapResponse1(out ErrorArrayMapResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreateProductCurrencyPricesOperationRequest` | `Requests/ProductPricePoints/CreateProductCurrencyPricesOperationRequest.cs` |
| `CreateProductCurrencyPricesRequest` | `Models/CreateProductCurrencyPricesRequest.cs` |
| `CurrencyPricesResponse` | `Models/CurrencyPricesResponse.cs` |
| `CreateProductCurrencyPricesError` | `Errors/CreateProductCurrencyPricesError.cs` |
| `ErrorArrayMapResponse1` | `Models/ErrorArrayMapResponse1.cs` |

### CreateProductPricePoint

- **Auth**: `options.BasicAuth`
- **Signature**: `CreateProductPricePoint(CreateProductPricePointOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProductId`
- **Returns**: `ProductPricePointResponse`
- **Error**: `ApiException<CreateProductPricePointError>` — **Case A (typed)**
- **Error accessors**: `TryGetProductPricePointErrorResponse1(out ProductPricePointErrorResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreateProductPricePointOperationRequest` | `Requests/ProductPricePoints/CreateProductPricePointOperationRequest.cs` |
| `ProductIdModel` | `Models/AnyOf/ProductIdModel.cs` |
| `CreateProductPricePointRequest` | `Models/CreateProductPricePointRequest.cs` |
| `ProductPricePointResponse` | `Models/ProductPricePointResponse.cs` |
| `CreateProductPricePointError` | `Errors/CreateProductPricePointError.cs` |
| `ProductPricePointErrorResponse1` | `Models/ProductPricePointErrorResponse1.cs` |

### ListAllProductPricePoints

- **Auth**: `options.BasicAuth`
- **Signature**: `ListAllProductPricePoints(ListAllProductPricePointsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `direction` ← `Direction`, `filter` ← `Filter`, `include` ← `Include`, `page` ← `Page`, `per_page` ← `PerPage`
- **Returns**: `ListProductPricePointsResponse`
- **Error**: `ApiException<ListAllProductPricePointsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ListAllProductPricePointsRequest` | `Requests/ProductPricePoints/ListAllProductPricePointsRequest.cs` |
| `SortingDirection` | `Models/Enums/SortingDirection.cs` |
| `ListPricePointsFilter` | `Models/ListPricePointsFilter.cs` |
| `ListProductsPricePointsInclude` | `Models/Enums/ListProductsPricePointsInclude.cs` |
| `ListProductPricePointsResponse` | `Models/ListProductPricePointsResponse.cs` |
| `ListAllProductPricePointsError` | `Errors/ListAllProductPricePointsError.cs` |
| `ErrorListResponse1` | `Models/ErrorListResponse1.cs` |

### ListProductPricePoints

- **Auth**: `options.BasicAuth`
- **Signature**: `ListProductPricePoints(ListProductPricePointsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProductId`
- **Query params (wire ← C#)**: `page` ← `Page`, `per_page` ← `PerPage`, `currency_prices` ← `CurrencyPrices`, `filter[type]` ← `FilterType`, `archived` ← `Archived`
- **Returns**: `ListProductPricePointsResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListProductPricePointsRequest` | `Requests/ProductPricePoints/ListProductPricePointsRequest.cs` |
| `ProductIdModel` | `Models/AnyOf/ProductIdModel.cs` |
| `PricePointType` | `Models/Enums/PricePointType.cs` |
| `ListProductPricePointsResponse` | `Models/ListProductPricePointsResponse.cs` |

### PromoteProductPricePointToDefault

- **Auth**: `options.BasicAuth`
- **Signature**: `PromoteProductPricePointToDefault(PromoteProductPricePointToDefaultRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProductId`, `PricePointId`
- **Returns**: `ProductResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PromoteProductPricePointToDefaultRequest` | `Requests/ProductPricePoints/PromoteProductPricePointToDefaultRequest.cs` |
| `ProductResponse` | `Models/ProductResponse.cs` |

### ReadProductPricePoint

- **Auth**: `options.BasicAuth`
- **Signature**: `ReadProductPricePoint(ReadProductPricePointRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProductId`, `PricePointId`
- **Query params (wire ← C#)**: `currency_prices` ← `CurrencyPrices`
- **Returns**: `ProductPricePointResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ReadProductPricePointRequest` | `Requests/ProductPricePoints/ReadProductPricePointRequest.cs` |
| `ProductIdModel` | `Models/AnyOf/ProductIdModel.cs` |
| `PricePointIdModel` | `Models/AnyOf/PricePointIdModel.cs` |
| `ProductPricePointResponse` | `Models/ProductPricePointResponse.cs` |

### UnarchiveProductPricePoint

- **Auth**: `options.BasicAuth`
- **Signature**: `UnarchiveProductPricePoint(UnarchiveProductPricePointRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProductId`, `PricePointId`
- **Returns**: `ProductPricePointResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UnarchiveProductPricePointRequest` | `Requests/ProductPricePoints/UnarchiveProductPricePointRequest.cs` |
| `ProductPricePointResponse` | `Models/ProductPricePointResponse.cs` |

### UpdateProductCurrencyPrices

- **Auth**: `options.BasicAuth`
- **Signature**: `UpdateProductCurrencyPrices(UpdateProductCurrencyPricesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProductPricePointId`
- **Returns**: `CurrencyPricesResponse`
- **Error**: `ApiException<UpdateProductCurrencyPricesError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorArrayMapResponse1(out ErrorArrayMapResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdateProductCurrencyPricesRequest` | `Requests/ProductPricePoints/UpdateProductCurrencyPricesRequest.cs` |
| `UpdateCurrencyPricesRequest` | `Models/UpdateCurrencyPricesRequest.cs` |
| `CurrencyPricesResponse` | `Models/CurrencyPricesResponse.cs` |
| `UpdateProductCurrencyPricesError` | `Errors/UpdateProductCurrencyPricesError.cs` |
| `ErrorArrayMapResponse1` | `Models/ErrorArrayMapResponse1.cs` |

### UpdateProductPricePoint

- **Auth**: `options.BasicAuth`
- **Signature**: `UpdateProductPricePoint(UpdateProductPricePointOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProductId`, `PricePointId`
- **Returns**: `ProductPricePointResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpdateProductPricePointOperationRequest` | `Requests/ProductPricePoints/UpdateProductPricePointOperationRequest.cs` |
| `ProductIdModel` | `Models/AnyOf/ProductIdModel.cs` |
| `PricePointIdModel` | `Models/AnyOf/PricePointIdModel.cs` |
| `UpdateProductPricePointRequest` | `Models/UpdateProductPricePointRequest.cs` |
| `ProductPricePointResponse` | `Models/ProductPricePointResponse.cs` |

