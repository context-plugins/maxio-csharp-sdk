<!-- Generated file — do not edit; regenerated with the SDK. -->

# SubscriptionProducts — operations

Accessor: `client.SubscriptionProducts` · Source: `src/Maxio/Api/SubscriptionProducts.cs` · 2 operations

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
| `MigrateSubscriptionProductRequest` | `src/Maxio/Requests/SubscriptionProducts/MigrateSubscriptionProductRequest.cs` |
| `SubscriptionProductMigrationRequest` | `src/Maxio/Models/SubscriptionProductMigrationRequest.cs` |
| `SubscriptionResponse` | `src/Maxio/Models/SubscriptionResponse.cs` |
| `MigrateSubscriptionProductError` | `src/Maxio/Errors/MigrateSubscriptionProductError.cs` |
| `ErrorListResponse1` | `src/Maxio/Models/ErrorListResponse1.cs` |

### PreviewSubscriptionProductMigration

- **Auth**: `options.BasicAuth`
- **Signature**: `PreviewSubscriptionProductMigration(PreviewSubscriptionProductMigrationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`
- **Returns**: `SubscriptionMigrationPreviewResponse`
- **Error**: `ApiException<PreviewSubscriptionProductMigrationError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PreviewSubscriptionProductMigrationRequest` | `src/Maxio/Requests/SubscriptionProducts/PreviewSubscriptionProductMigrationRequest.cs` |
| `SubscriptionMigrationPreviewRequest` | `src/Maxio/Models/SubscriptionMigrationPreviewRequest.cs` |
| `SubscriptionMigrationPreviewResponse` | `src/Maxio/Models/SubscriptionMigrationPreviewResponse.cs` |
| `PreviewSubscriptionProductMigrationError` | `src/Maxio/Errors/PreviewSubscriptionProductMigrationError.cs` |
| `ErrorListResponse1` | `src/Maxio/Models/ErrorListResponse1.cs` |

