<!-- Generated file — do not edit; regenerated with the SDK. -->

# ComponentFeatures — operations

Accessor: `client.ComponentFeatures` · Source: `Api/ComponentFeatures.cs` · 6 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateComponentFeature

- **Auth**: `options.BasicAuth`
- **Signature**: `CreateComponentFeature(CreateComponentFeatureRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ComponentId`
- **Returns**: `FeatureCatalogItemResponse`
- **Error**: `ApiException<CreateComponentFeatureError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [403, 422] · `TryGetNoContent(out RawError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreateComponentFeatureRequest` | `Requests/ComponentFeatures/CreateComponentFeatureRequest.cs` |
| `CreateFeatureCatalogItemRequest` | `Models/CreateFeatureCatalogItemRequest.cs` |
| `FeatureCatalogItemResponse` | `Models/FeatureCatalogItemResponse.cs` |
| `CreateComponentFeatureError` | `Errors/CreateComponentFeatureError.cs` |
| `ErrorListResponse1` | `Models/ErrorListResponse1.cs` |

### ListComponentFeatures

- **Auth**: `options.BasicAuth`
- **Signature**: `ListComponentFeatures(ListComponentFeaturesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ComponentId`
- **Returns**: `FeatureCatalogItemsListResponse`
- **Error**: `ApiException<ListComponentFeaturesError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [403] · `TryGetNoContent(out RawError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ListComponentFeaturesRequest` | `Requests/ComponentFeatures/ListComponentFeaturesRequest.cs` |
| `FeatureCatalogItemsListResponse` | `Models/FeatureCatalogItemsListResponse.cs` |
| `ListComponentFeaturesError` | `Errors/ListComponentFeaturesError.cs` |
| `ErrorListResponse1` | `Models/ErrorListResponse1.cs` |

### ReadComponentFeature

- **Auth**: `options.BasicAuth`
- **Signature**: `ReadComponentFeature(ReadComponentFeatureRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ComponentId`, `Id`
- **Returns**: `FeatureCatalogItemResponse`
- **Error**: `ApiException<ReadComponentFeatureError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [403] · `TryGetNoContent(out RawError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ReadComponentFeatureRequest` | `Requests/ComponentFeatures/ReadComponentFeatureRequest.cs` |
| `FeatureCatalogItemResponse` | `Models/FeatureCatalogItemResponse.cs` |
| `ReadComponentFeatureError` | `Errors/ReadComponentFeatureError.cs` |
| `ErrorListResponse1` | `Models/ErrorListResponse1.cs` |

### RemoveComponentFeature

- **Auth**: `options.BasicAuth`
- **Signature**: `RemoveComponentFeature(RemoveComponentFeatureRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ComponentId`, `Id`
- **Query params (wire ← C#)**: `destroy_entitlements` ← `DestroyEntitlements`
- **Returns**: `void` (Task)
- **Error**: `ApiException<RemoveComponentFeatureError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [403] · `TryGetNoContent(out RawError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `RemoveComponentFeatureRequest` | `Requests/ComponentFeatures/RemoveComponentFeatureRequest.cs` |
| `RemoveComponentFeatureError` | `Errors/RemoveComponentFeatureError.cs` |
| `ErrorListResponse1` | `Models/ErrorListResponse1.cs` |

### RestoreComponentFeature

- **Auth**: `options.BasicAuth`
- **Signature**: `RestoreComponentFeature(RestoreComponentFeatureRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ComponentId`, `Id`
- **Returns**: `FeatureCatalogItemResponse`
- **Error**: `ApiException<RestoreComponentFeatureError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [403, 422] · `TryGetNoContent(out RawError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `RestoreComponentFeatureRequest` | `Requests/ComponentFeatures/RestoreComponentFeatureRequest.cs` |
| `FeatureCatalogItemResponse` | `Models/FeatureCatalogItemResponse.cs` |
| `RestoreComponentFeatureError` | `Errors/RestoreComponentFeatureError.cs` |
| `ErrorListResponse1` | `Models/ErrorListResponse1.cs` |

### UpdateComponentFeature

- **Auth**: `options.BasicAuth`
- **Signature**: `UpdateComponentFeature(UpdateComponentFeatureRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ComponentId`, `Id`
- **Returns**: `FeatureCatalogItemResponse`
- **Error**: `ApiException<UpdateComponentFeatureError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [403, 422] · `TryGetNoContent(out RawError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdateComponentFeatureRequest` | `Requests/ComponentFeatures/UpdateComponentFeatureRequest.cs` |
| `UpdateFeatureCatalogItemRequest` | `Models/UpdateFeatureCatalogItemRequest.cs` |
| `FeatureCatalogItemResponse` | `Models/FeatureCatalogItemResponse.cs` |
| `UpdateComponentFeatureError` | `Errors/UpdateComponentFeatureError.cs` |
| `ErrorListResponse1` | `Models/ErrorListResponse1.cs` |

