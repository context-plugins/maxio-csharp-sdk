<!-- Generated file — do not edit; regenerated with the SDK. -->

# ComponentPricePoints — operations

Accessor: `client.ComponentPricePoints` · Source: `src/Maxio/Api/ComponentPricePoints.cs` · 12 operations

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
| `ArchiveComponentPricePointRequest` | `src/Maxio/Requests/ComponentPricePoints/ArchiveComponentPricePointRequest.cs` |
| `ComponentIdModel` | `src/Maxio/Models/AnyOf/ComponentIdModel.cs` |
| `PricePointIdModel` | `src/Maxio/Models/AnyOf/PricePointIdModel.cs` |
| `ComponentPricePointResponse` | `src/Maxio/Models/ComponentPricePointResponse.cs` |
| `ArchiveComponentPricePointError` | `src/Maxio/Errors/ArchiveComponentPricePointError.cs` |
| `ErrorListResponse1` | `src/Maxio/Models/ErrorListResponse1.cs` |

### BulkCreateComponentPricePoints

- **Auth**: `options.BasicAuth`
- **Signature**: `BulkCreateComponentPricePoints(BulkCreateComponentPricePointsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ComponentId`
- **Returns**: `ComponentPricePointsResponse`
- **Error**: `ApiException<BulkCreateComponentPricePointsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `BulkCreateComponentPricePointsRequest` | `src/Maxio/Requests/ComponentPricePoints/BulkCreateComponentPricePointsRequest.cs` |
| `CreateComponentPricePointsRequest` | `src/Maxio/Models/CreateComponentPricePointsRequest.cs` |
| `ComponentPricePointsResponse` | `src/Maxio/Models/ComponentPricePointsResponse.cs` |
| `BulkCreateComponentPricePointsError` | `src/Maxio/Errors/BulkCreateComponentPricePointsError.cs` |
| `ErrorListResponse1` | `src/Maxio/Models/ErrorListResponse1.cs` |

### CloneComponentPricePoint

- **Auth**: `options.BasicAuth`
- **Signature**: `CloneComponentPricePoint(CloneComponentPricePointOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ComponentId`, `PricePointId`
- **Returns**: `ComponentPricePointCurrencyOverageResponse`
- **Error**: `ApiException<CloneComponentPricePointError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404] · `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CloneComponentPricePointOperationRequest` | `src/Maxio/Requests/ComponentPricePoints/CloneComponentPricePointOperationRequest.cs` |
| `ComponentIdModel` | `src/Maxio/Models/AnyOf/ComponentIdModel.cs` |
| `PricePointIdModel` | `src/Maxio/Models/AnyOf/PricePointIdModel.cs` |
| `CloneComponentPricePointRequest` | `src/Maxio/Models/CloneComponentPricePointRequest.cs` |
| `ComponentPricePointCurrencyOverageResponse` | `src/Maxio/Models/ComponentPricePointCurrencyOverageResponse.cs` |
| `CloneComponentPricePointError` | `src/Maxio/Errors/CloneComponentPricePointError.cs` |
| `ErrorListResponse1` | `src/Maxio/Models/ErrorListResponse1.cs` |

### CreateComponentPricePoint

- **Auth**: `options.BasicAuth`
- **Signature**: `CreateComponentPricePoint(CreateComponentPricePointOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ComponentId`
- **Returns**: `ComponentPricePointResponse`
- **Error**: `ApiException<CreateComponentPricePointError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorArrayMapResponse1(out ErrorArrayMapResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreateComponentPricePointOperationRequest` | `src/Maxio/Requests/ComponentPricePoints/CreateComponentPricePointOperationRequest.cs` |
| `CreateComponentPricePointRequest` | `src/Maxio/Models/CreateComponentPricePointRequest.cs` |
| `ComponentPricePointResponse` | `src/Maxio/Models/ComponentPricePointResponse.cs` |
| `CreateComponentPricePointError` | `src/Maxio/Errors/CreateComponentPricePointError.cs` |
| `ErrorArrayMapResponse1` | `src/Maxio/Models/ErrorArrayMapResponse1.cs` |

### CreateCurrencyPrices

- **Auth**: `options.BasicAuth`
- **Signature**: `CreateCurrencyPrices(CreateCurrencyPricesOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `PricePointId`
- **Returns**: `ComponentCurrencyPricesResponse`
- **Error**: `ApiException<CreateCurrencyPricesError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorArrayMapResponse1(out ErrorArrayMapResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreateCurrencyPricesOperationRequest` | `src/Maxio/Requests/ComponentPricePoints/CreateCurrencyPricesOperationRequest.cs` |
| `CreateCurrencyPricesRequest` | `src/Maxio/Models/CreateCurrencyPricesRequest.cs` |
| `ComponentCurrencyPricesResponse` | `src/Maxio/Models/ComponentCurrencyPricesResponse.cs` |
| `CreateCurrencyPricesError` | `src/Maxio/Errors/CreateCurrencyPricesError.cs` |
| `ErrorArrayMapResponse1` | `src/Maxio/Models/ErrorArrayMapResponse1.cs` |

### ListAllComponentPricePoints

- **Auth**: `options.BasicAuth`
- **Signature**: `ListAllComponentPricePoints(ListAllComponentPricePointsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `include` ← `Include`, `page` ← `Page`, `per_page` ← `PerPage`, `direction` ← `Direction`, `filter` ← `Filter`
- **Returns**: `ListComponentsPricePointsResponse`
- **Error**: `ApiException<ListAllComponentPricePointsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ListAllComponentPricePointsRequest` | `src/Maxio/Requests/ComponentPricePoints/ListAllComponentPricePointsRequest.cs` |
| `ListComponentsPricePointsInclude` | `src/Maxio/Models/Enums/ListComponentsPricePointsInclude.cs` |
| `SortingDirection` | `src/Maxio/Models/Enums/SortingDirection.cs` |
| `ListPricePointsFilter` | `src/Maxio/Models/ListPricePointsFilter.cs` |
| `ListComponentsPricePointsResponse` | `src/Maxio/Models/ListComponentsPricePointsResponse.cs` |
| `ListAllComponentPricePointsError` | `src/Maxio/Errors/ListAllComponentPricePointsError.cs` |
| `ErrorListResponse1` | `src/Maxio/Models/ErrorListResponse1.cs` |

### ListComponentPricePoints

- **Auth**: `options.BasicAuth`
- **Signature**: `ListComponentPricePoints(ListComponentPricePointsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ComponentId`
- **Query params (wire ← C#)**: `currency_prices` ← `CurrencyPrices`, `page` ← `Page`, `per_page` ← `PerPage`, `filter[type]` ← `FilterType`
- **Returns**: `ComponentPricePointsResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListComponentPricePointsRequest` | `src/Maxio/Requests/ComponentPricePoints/ListComponentPricePointsRequest.cs` |
| `PricePointType` | `src/Maxio/Models/Enums/PricePointType.cs` |
| `ComponentPricePointsResponse` | `src/Maxio/Models/ComponentPricePointsResponse.cs` |

### PromoteComponentPricePointToDefault

- **Auth**: `options.BasicAuth`
- **Signature**: `PromoteComponentPricePointToDefault(PromoteComponentPricePointToDefaultRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ComponentId`, `PricePointId`
- **Returns**: `ComponentResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PromoteComponentPricePointToDefaultRequest` | `src/Maxio/Requests/ComponentPricePoints/PromoteComponentPricePointToDefaultRequest.cs` |
| `ComponentResponse` | `src/Maxio/Models/ComponentResponse.cs` |

### ReadComponentPricePoint

- **Auth**: `options.BasicAuth`
- **Signature**: `ReadComponentPricePoint(ReadComponentPricePointRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ComponentId`, `PricePointId`
- **Query params (wire ← C#)**: `currency_prices` ← `CurrencyPrices`
- **Returns**: `ComponentPricePointCurrencyOverageResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ReadComponentPricePointRequest` | `src/Maxio/Requests/ComponentPricePoints/ReadComponentPricePointRequest.cs` |
| `ComponentIdModel` | `src/Maxio/Models/AnyOf/ComponentIdModel.cs` |
| `PricePointIdModel` | `src/Maxio/Models/AnyOf/PricePointIdModel.cs` |
| `ComponentPricePointCurrencyOverageResponse` | `src/Maxio/Models/ComponentPricePointCurrencyOverageResponse.cs` |

### UnarchiveComponentPricePoint

- **Auth**: `options.BasicAuth`
- **Signature**: `UnarchiveComponentPricePoint(UnarchiveComponentPricePointRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ComponentId`, `PricePointId`
- **Returns**: `ComponentPricePointResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UnarchiveComponentPricePointRequest` | `src/Maxio/Requests/ComponentPricePoints/UnarchiveComponentPricePointRequest.cs` |
| `ComponentPricePointResponse` | `src/Maxio/Models/ComponentPricePointResponse.cs` |

### UpdateComponentPricePoint

- **Auth**: `options.BasicAuth`
- **Signature**: `UpdateComponentPricePoint(UpdateComponentPricePointOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ComponentId`, `PricePointId`
- **Returns**: `ComponentPricePointResponse`
- **Error**: `ApiException<UpdateComponentPricePointError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorArrayMapResponse1(out ErrorArrayMapResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdateComponentPricePointOperationRequest` | `src/Maxio/Requests/ComponentPricePoints/UpdateComponentPricePointOperationRequest.cs` |
| `ComponentIdModel` | `src/Maxio/Models/AnyOf/ComponentIdModel.cs` |
| `PricePointIdModel` | `src/Maxio/Models/AnyOf/PricePointIdModel.cs` |
| `UpdateComponentPricePointRequest` | `src/Maxio/Models/UpdateComponentPricePointRequest.cs` |
| `ComponentPricePointResponse` | `src/Maxio/Models/ComponentPricePointResponse.cs` |
| `UpdateComponentPricePointError` | `src/Maxio/Errors/UpdateComponentPricePointError.cs` |
| `ErrorArrayMapResponse1` | `src/Maxio/Models/ErrorArrayMapResponse1.cs` |

### UpdateCurrencyPrices

- **Auth**: `options.BasicAuth`
- **Signature**: `UpdateCurrencyPrices(UpdateCurrencyPricesOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `PricePointId`
- **Returns**: `ComponentCurrencyPricesResponse`
- **Error**: `ApiException<UpdateCurrencyPricesError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorArrayMapResponse1(out ErrorArrayMapResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdateCurrencyPricesOperationRequest` | `src/Maxio/Requests/ComponentPricePoints/UpdateCurrencyPricesOperationRequest.cs` |
| `UpdateCurrencyPricesRequest` | `src/Maxio/Models/UpdateCurrencyPricesRequest.cs` |
| `ComponentCurrencyPricesResponse` | `src/Maxio/Models/ComponentCurrencyPricesResponse.cs` |
| `UpdateCurrencyPricesError` | `src/Maxio/Errors/UpdateCurrencyPricesError.cs` |
| `ErrorArrayMapResponse1` | `src/Maxio/Models/ErrorArrayMapResponse1.cs` |

