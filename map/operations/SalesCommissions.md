<!-- Generated file — do not edit; regenerated with the SDK. -->

# SalesCommissions — operations

Accessor: `client.SalesCommissions` · Source: `Api/SalesCommissions.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### ListSalesCommissionSettings

- **Auth**: `options.BasicAuth`
- **Signature**: `ListSalesCommissionSettings(ListSalesCommissionSettingsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SellerId`
- **Query params (wire ← C#)**: `live_mode` ← `LiveMode`, `page` ← `Page`, `per_page` ← `PerPage`
- **Returns**: `IReadOnlyList<SaleRepSettings>`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListSalesCommissionSettingsRequest` | `Requests/SalesCommissions/ListSalesCommissionSettingsRequest.cs` |
| `SaleRepSettings` | `Models/SaleRepSettings.cs` |

### ListSalesReps

- **Auth**: `options.BasicAuth`
- **Signature**: `ListSalesReps(ListSalesRepsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SellerId`
- **Query params (wire ← C#)**: `live_mode` ← `LiveMode`, `page` ← `Page`, `per_page` ← `PerPage`
- **Returns**: `IReadOnlyList<ListSaleRepItem>`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListSalesRepsRequest` | `Requests/SalesCommissions/ListSalesRepsRequest.cs` |
| `ListSaleRepItem` | `Models/ListSaleRepItem.cs` |

### ReadSalesRep

- **Auth**: `options.BasicAuth`
- **Signature**: `ReadSalesRep(ReadSalesRepRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SellerId`, `SalesRepId`
- **Query params (wire ← C#)**: `live_mode` ← `LiveMode`, `page` ← `Page`, `per_page` ← `PerPage`
- **Returns**: `SaleRep`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ReadSalesRepRequest` | `Requests/SalesCommissions/ReadSalesRepRequest.cs` |
| `SaleRep` | `Models/SaleRep.cs` |

