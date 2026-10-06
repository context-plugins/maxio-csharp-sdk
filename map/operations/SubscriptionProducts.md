<!-- Generated file — do not edit; regenerated with the SDK. -->

# SubscriptionProducts — operations

Accessor: `client.SubscriptionProducts` · Source: `Api/SubscriptionProducts.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### MigrateSubscriptionProduct

- **Auth**: `options.BasicAuth`
- **Signature**: `MigrateSubscriptionProduct(MigrateSubscriptionProductRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`
- **Returns**: `SubscriptionResponse`
- **Error**: `ApiException<MigrateSubscriptionProductError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `MigrateSubscriptionProductRequest` | `Requests/SubscriptionProducts/MigrateSubscriptionProductRequest.cs` |
| `SubscriptionProductMigrationRequest` | `Models/SubscriptionProductMigrationRequest.cs` |
| `SubscriptionResponse` | `Models/SubscriptionResponse.cs` |
| `MigrateSubscriptionProductError` | `Errors/MigrateSubscriptionProductError.cs` |
| `ErrorListResponse1` | `Models/ErrorListResponse1.cs` |

### PreviewSubscriptionProductMigration

- **Auth**: `options.BasicAuth`
- **Signature**: `PreviewSubscriptionProductMigration(PreviewSubscriptionProductMigrationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`
- **Returns**: `SubscriptionMigrationPreviewResponse`
- **Error**: `ApiException<PreviewSubscriptionProductMigrationError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PreviewSubscriptionProductMigrationRequest` | `Requests/SubscriptionProducts/PreviewSubscriptionProductMigrationRequest.cs` |
| `SubscriptionMigrationPreviewRequest` | `Models/SubscriptionMigrationPreviewRequest.cs` |
| `SubscriptionMigrationPreviewResponse` | `Models/SubscriptionMigrationPreviewResponse.cs` |
| `PreviewSubscriptionProductMigrationError` | `Errors/PreviewSubscriptionProductMigrationError.cs` |
| `ErrorListResponse1` | `Models/ErrorListResponse1.cs` |

