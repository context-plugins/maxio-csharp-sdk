<!-- Generated file — do not edit; regenerated with the SDK. -->

# ProductFeatures — operations

Accessor: `client.ProductFeatures` · Source: `Api/ProductFeatures.cs` · 6 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateProductFeature

- **Auth**: `options.BasicAuth`
- **Signature**: `CreateProductFeature(CreateProductFeatureRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProductId`
- **Returns**: `FeatureCatalogItemResponse`
- **Error**: `ApiException<CreateProductFeatureError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [403, 422] · `TryGetNoContent(out RawError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreateProductFeatureRequest` | `Requests/ProductFeatures/CreateProductFeatureRequest.cs` |
| `CreateFeatureCatalogItemRequest` | `Models/CreateFeatureCatalogItemRequest.cs` |
| `FeatureCatalogItemResponse` | `Models/FeatureCatalogItemResponse.cs` |
| `CreateProductFeatureError` | `Errors/CreateProductFeatureError.cs` |
| `ErrorListResponse1` | `Models/ErrorListResponse1.cs` |

### ListProductFeatures

- **Auth**: `options.BasicAuth`
- **Signature**: `ListProductFeatures(ListProductFeaturesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProductId`
- **Returns**: `FeatureCatalogItemsListResponse`
- **Error**: `ApiException<ListProductFeaturesError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [403] · `TryGetNoContent(out RawError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ListProductFeaturesRequest` | `Requests/ProductFeatures/ListProductFeaturesRequest.cs` |
| `FeatureCatalogItemsListResponse` | `Models/FeatureCatalogItemsListResponse.cs` |
| `ListProductFeaturesError` | `Errors/ListProductFeaturesError.cs` |
| `ErrorListResponse1` | `Models/ErrorListResponse1.cs` |

### ReadProductFeature

- **Auth**: `options.BasicAuth`
- **Signature**: `ReadProductFeature(ReadProductFeatureRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProductId`, `Id`
- **Returns**: `FeatureCatalogItemResponse`
- **Error**: `ApiException<ReadProductFeatureError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [403] · `TryGetNoContent(out RawError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ReadProductFeatureRequest` | `Requests/ProductFeatures/ReadProductFeatureRequest.cs` |
| `FeatureCatalogItemResponse` | `Models/FeatureCatalogItemResponse.cs` |
| `ReadProductFeatureError` | `Errors/ReadProductFeatureError.cs` |
| `ErrorListResponse1` | `Models/ErrorListResponse1.cs` |

### RemoveProductFeature

- **Auth**: `options.BasicAuth`
- **Signature**: `RemoveProductFeature(RemoveProductFeatureRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProductId`, `Id`
- **Query params (wire ← C#)**: `destroy_entitlements` ← `DestroyEntitlements`
- **Returns**: `void` (Task)
- **Error**: `ApiException<RemoveProductFeatureError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [403] · `TryGetNoContent(out RawError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `RemoveProductFeatureRequest` | `Requests/ProductFeatures/RemoveProductFeatureRequest.cs` |
| `RemoveProductFeatureError` | `Errors/RemoveProductFeatureError.cs` |
| `ErrorListResponse1` | `Models/ErrorListResponse1.cs` |

### RestoreProductFeature

- **Auth**: `options.BasicAuth`
- **Signature**: `RestoreProductFeature(RestoreProductFeatureRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProductId`, `Id`
- **Returns**: `FeatureCatalogItemResponse`
- **Error**: `ApiException<RestoreProductFeatureError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [403, 422] · `TryGetNoContent(out RawError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `RestoreProductFeatureRequest` | `Requests/ProductFeatures/RestoreProductFeatureRequest.cs` |
| `FeatureCatalogItemResponse` | `Models/FeatureCatalogItemResponse.cs` |
| `RestoreProductFeatureError` | `Errors/RestoreProductFeatureError.cs` |
| `ErrorListResponse1` | `Models/ErrorListResponse1.cs` |

### UpdateProductFeature

- **Auth**: `options.BasicAuth`
- **Signature**: `UpdateProductFeature(UpdateProductFeatureRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProductId`, `Id`
- **Returns**: `FeatureCatalogItemResponse`
- **Error**: `ApiException<UpdateProductFeatureError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [403, 422] · `TryGetNoContent(out RawError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdateProductFeatureRequest` | `Requests/ProductFeatures/UpdateProductFeatureRequest.cs` |
| `UpdateFeatureCatalogItemRequest` | `Models/UpdateFeatureCatalogItemRequest.cs` |
| `FeatureCatalogItemResponse` | `Models/FeatureCatalogItemResponse.cs` |
| `UpdateProductFeatureError` | `Errors/UpdateProductFeatureError.cs` |
| `ErrorListResponse1` | `Models/ErrorListResponse1.cs` |

