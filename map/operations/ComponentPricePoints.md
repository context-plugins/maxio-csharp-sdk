<!-- Generated file — do not edit; regenerated with the SDK. -->

# ComponentPricePoints — operations

Accessor: `client.ComponentPricePoints` · Source: `Api/ComponentPricePoints.cs` · 12 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### ArchiveComponentPricePoint

- **Auth**: `options.BasicAuth`
- **Signature**: `ArchiveComponentPricePoint(ArchiveComponentPricePointRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ComponentId`, `PricePointId`
- **Returns**: `ComponentPricePointResponse`
- **Error**: `ApiException<ArchiveComponentPricePointError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ArchiveComponentPricePointRequest` | `Requests/ComponentPricePoints/ArchiveComponentPricePointRequest.cs` |
| `ComponentIdModel` | `Models/AnyOf/ComponentIdModel.cs` |
| `PricePointIdModel` | `Models/AnyOf/PricePointIdModel.cs` |
| `ComponentPricePointResponse` | `Models/ComponentPricePointResponse.cs` |
| `ArchiveComponentPricePointError` | `Errors/ArchiveComponentPricePointError.cs` |
| `ErrorListResponse1` | `Models/ErrorListResponse1.cs` |

### BulkCreateComponentPricePoints

- **Auth**: `options.BasicAuth`
- **Signature**: `BulkCreateComponentPricePoints(BulkCreateComponentPricePointsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ComponentId`
- **Returns**: `ComponentPricePointsResponse`
- **Error**: `ApiException<BulkCreateComponentPricePointsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `BulkCreateComponentPricePointsRequest` | `Requests/ComponentPricePoints/BulkCreateComponentPricePointsRequest.cs` |
| `CreateComponentPricePointsRequest` | `Models/CreateComponentPricePointsRequest.cs` |
| `ComponentPricePointsResponse` | `Models/ComponentPricePointsResponse.cs` |
| `BulkCreateComponentPricePointsError` | `Errors/BulkCreateComponentPricePointsError.cs` |
| `ErrorListResponse1` | `Models/ErrorListResponse1.cs` |

### CloneComponentPricePoint

- **Auth**: `options.BasicAuth`
- **Signature**: `CloneComponentPricePoint(CloneComponentPricePointOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ComponentId`, `PricePointId`
- **Returns**: `ComponentPricePointCurrencyOverageResponse`
- **Error**: `ApiException<CloneComponentPricePointError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404] · `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CloneComponentPricePointOperationRequest` | `Requests/ComponentPricePoints/CloneComponentPricePointOperationRequest.cs` |
| `ComponentIdModel` | `Models/AnyOf/ComponentIdModel.cs` |
| `PricePointIdModel` | `Models/AnyOf/PricePointIdModel.cs` |
| `CloneComponentPricePointRequest` | `Models/CloneComponentPricePointRequest.cs` |
| `ComponentPricePointCurrencyOverageResponse` | `Models/ComponentPricePointCurrencyOverageResponse.cs` |
| `CloneComponentPricePointError` | `Errors/CloneComponentPricePointError.cs` |
| `ErrorListResponse1` | `Models/ErrorListResponse1.cs` |

### CreateComponentPricePoint

- **Auth**: `options.BasicAuth`
- **Signature**: `CreateComponentPricePoint(CreateComponentPricePointOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ComponentId`
- **Returns**: `ComponentPricePointResponse`
- **Error**: `ApiException<CreateComponentPricePointError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorArrayMapResponse1(out ErrorArrayMapResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreateComponentPricePointOperationRequest` | `Requests/ComponentPricePoints/CreateComponentPricePointOperationRequest.cs` |
| `CreateComponentPricePointRequest` | `Models/CreateComponentPricePointRequest.cs` |
| `ComponentPricePointResponse` | `Models/ComponentPricePointResponse.cs` |
| `CreateComponentPricePointError` | `Errors/CreateComponentPricePointError.cs` |
| `ErrorArrayMapResponse1` | `Models/ErrorArrayMapResponse1.cs` |

### CreateCurrencyPrices

- **Auth**: `options.BasicAuth`
- **Signature**: `CreateCurrencyPrices(CreateCurrencyPricesOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `PricePointId`
- **Returns**: `ComponentCurrencyPricesResponse`
- **Error**: `ApiException<CreateCurrencyPricesError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorArrayMapResponse1(out ErrorArrayMapResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreateCurrencyPricesOperationRequest` | `Requests/ComponentPricePoints/CreateCurrencyPricesOperationRequest.cs` |
| `CreateCurrencyPricesRequest` | `Models/CreateCurrencyPricesRequest.cs` |
| `ComponentCurrencyPricesResponse` | `Models/ComponentCurrencyPricesResponse.cs` |
| `CreateCurrencyPricesError` | `Errors/CreateCurrencyPricesError.cs` |
| `ErrorArrayMapResponse1` | `Models/ErrorArrayMapResponse1.cs` |

### ListAllComponentPricePoints

- **Auth**: `options.BasicAuth`
- **Signature**: `ListAllComponentPricePoints(ListAllComponentPricePointsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `include` ← `Include`, `page` ← `Page`, `per_page` ← `PerPage`, `direction` ← `Direction`, `filter` ← `Filter`
- **Returns**: `ListComponentsPricePointsResponse`
- **Error**: `ApiException<ListAllComponentPricePointsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ListAllComponentPricePointsRequest` | `Requests/ComponentPricePoints/ListAllComponentPricePointsRequest.cs` |
| `ListComponentsPricePointsInclude` | `Models/Enums/ListComponentsPricePointsInclude.cs` |
| `SortingDirection` | `Models/Enums/SortingDirection.cs` |
| `ListPricePointsFilter` | `Models/ListPricePointsFilter.cs` |
| `ListComponentsPricePointsResponse` | `Models/ListComponentsPricePointsResponse.cs` |
| `ListAllComponentPricePointsError` | `Errors/ListAllComponentPricePointsError.cs` |
| `ErrorListResponse1` | `Models/ErrorListResponse1.cs` |

### ListComponentPricePoints

- **Auth**: `options.BasicAuth`
- **Signature**: `ListComponentPricePoints(ListComponentPricePointsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ComponentId`
- **Query params (wire ← C#)**: `currency_prices` ← `CurrencyPrices`, `page` ← `Page`, `per_page` ← `PerPage`, `filter[type]` ← `FilterType`
- **Returns**: `ComponentPricePointsResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListComponentPricePointsRequest` | `Requests/ComponentPricePoints/ListComponentPricePointsRequest.cs` |
| `PricePointType` | `Models/Enums/PricePointType.cs` |
| `ComponentPricePointsResponse` | `Models/ComponentPricePointsResponse.cs` |

### PromoteComponentPricePointToDefault

- **Auth**: `options.BasicAuth`
- **Signature**: `PromoteComponentPricePointToDefault(PromoteComponentPricePointToDefaultRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ComponentId`, `PricePointId`
- **Returns**: `ComponentResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PromoteComponentPricePointToDefaultRequest` | `Requests/ComponentPricePoints/PromoteComponentPricePointToDefaultRequest.cs` |
| `ComponentResponse` | `Models/ComponentResponse.cs` |

### ReadComponentPricePoint

- **Auth**: `options.BasicAuth`
- **Signature**: `ReadComponentPricePoint(ReadComponentPricePointRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ComponentId`, `PricePointId`
- **Query params (wire ← C#)**: `currency_prices` ← `CurrencyPrices`
- **Returns**: `ComponentPricePointCurrencyOverageResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ReadComponentPricePointRequest` | `Requests/ComponentPricePoints/ReadComponentPricePointRequest.cs` |
| `ComponentIdModel` | `Models/AnyOf/ComponentIdModel.cs` |
| `PricePointIdModel` | `Models/AnyOf/PricePointIdModel.cs` |
| `ComponentPricePointCurrencyOverageResponse` | `Models/ComponentPricePointCurrencyOverageResponse.cs` |

### UnarchiveComponentPricePoint

- **Auth**: `options.BasicAuth`
- **Signature**: `UnarchiveComponentPricePoint(UnarchiveComponentPricePointRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ComponentId`, `PricePointId`
- **Returns**: `ComponentPricePointResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UnarchiveComponentPricePointRequest` | `Requests/ComponentPricePoints/UnarchiveComponentPricePointRequest.cs` |
| `ComponentPricePointResponse` | `Models/ComponentPricePointResponse.cs` |

### UpdateComponentPricePoint

- **Auth**: `options.BasicAuth`
- **Signature**: `UpdateComponentPricePoint(UpdateComponentPricePointOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ComponentId`, `PricePointId`
- **Returns**: `ComponentPricePointResponse`
- **Error**: `ApiException<UpdateComponentPricePointError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorArrayMapResponse1(out ErrorArrayMapResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdateComponentPricePointOperationRequest` | `Requests/ComponentPricePoints/UpdateComponentPricePointOperationRequest.cs` |
| `ComponentIdModel` | `Models/AnyOf/ComponentIdModel.cs` |
| `PricePointIdModel` | `Models/AnyOf/PricePointIdModel.cs` |
| `UpdateComponentPricePointRequest` | `Models/UpdateComponentPricePointRequest.cs` |
| `ComponentPricePointResponse` | `Models/ComponentPricePointResponse.cs` |
| `UpdateComponentPricePointError` | `Errors/UpdateComponentPricePointError.cs` |
| `ErrorArrayMapResponse1` | `Models/ErrorArrayMapResponse1.cs` |

### UpdateCurrencyPrices

- **Auth**: `options.BasicAuth`
- **Signature**: `UpdateCurrencyPrices(UpdateCurrencyPricesOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `PricePointId`
- **Returns**: `ComponentCurrencyPricesResponse`
- **Error**: `ApiException<UpdateCurrencyPricesError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorArrayMapResponse1(out ErrorArrayMapResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdateCurrencyPricesOperationRequest` | `Requests/ComponentPricePoints/UpdateCurrencyPricesOperationRequest.cs` |
| `UpdateCurrencyPricesRequest` | `Models/UpdateCurrencyPricesRequest.cs` |
| `ComponentCurrencyPricesResponse` | `Models/ComponentCurrencyPricesResponse.cs` |
| `UpdateCurrencyPricesError` | `Errors/UpdateCurrencyPricesError.cs` |
| `ErrorArrayMapResponse1` | `Models/ErrorArrayMapResponse1.cs` |

