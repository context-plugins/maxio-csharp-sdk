<!-- Generated file — do not edit; regenerated with the SDK. -->

# Coupons — operations

Accessor: `client.Coupons` · Source: `src/Maxio/Api/Coupons.cs` · 14 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### ArchiveCoupon

- **Auth**: `options.BasicAuth`
- **Signature**: `ArchiveCoupon(ArchiveCouponRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProductFamilyId`, `CouponId`
- **Returns**: `CouponResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ArchiveCouponRequest` | `src/Maxio/Requests/Coupons/ArchiveCouponRequest.cs` |
| `CouponResponse` | `src/Maxio/Models/CouponResponse.cs` |

### CreateCoupon

- **Auth**: `options.BasicAuth`
- **Signature**: `CreateCoupon(CreateCouponRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProductFamilyId`
- **Returns**: `CouponResponse`
- **Error**: `ApiException<CreateCouponError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreateCouponRequest` | `src/Maxio/Requests/Coupons/CreateCouponRequest.cs` |
| `CouponRequest` | `src/Maxio/Models/CouponRequest.cs` |
| `CouponResponse` | `src/Maxio/Models/CouponResponse.cs` |
| `CreateCouponError` | `src/Maxio/Errors/CreateCouponError.cs` |
| `ErrorListResponse1` | `src/Maxio/Models/ErrorListResponse1.cs` |

### CreateCouponSubcodes

- **Auth**: `options.BasicAuth`
- **Signature**: `CreateCouponSubcodes(CreateCouponSubcodesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CouponId`
- **Returns**: `CouponSubcodesResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateCouponSubcodesRequest` | `src/Maxio/Requests/Coupons/CreateCouponSubcodesRequest.cs` |
| `CouponSubcodes` | `src/Maxio/Models/CouponSubcodes.cs` |
| `CouponSubcodesResponse` | `src/Maxio/Models/CouponSubcodesResponse.cs` |

### CreateOrUpdateCouponCurrencyPrices

- **Auth**: `options.BasicAuth`
- **Signature**: `CreateOrUpdateCouponCurrencyPrices(CreateOrUpdateCouponCurrencyPricesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CouponId`
- **Returns**: `CouponCurrencyResponse`
- **Error**: `ApiException<CreateOrUpdateCouponCurrencyPricesError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorStringMapResponse1(out ErrorStringMapResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreateOrUpdateCouponCurrencyPricesRequest` | `src/Maxio/Requests/Coupons/CreateOrUpdateCouponCurrencyPricesRequest.cs` |
| `CouponCurrencyRequest` | `src/Maxio/Models/CouponCurrencyRequest.cs` |
| `CouponCurrencyResponse` | `src/Maxio/Models/CouponCurrencyResponse.cs` |
| `CreateOrUpdateCouponCurrencyPricesError` | `src/Maxio/Errors/CreateOrUpdateCouponCurrencyPricesError.cs` |
| `ErrorStringMapResponse1` | `src/Maxio/Models/ErrorStringMapResponse1.cs` |

### DeleteCouponSubcode

- **Auth**: `options.BasicAuth`
- **Signature**: `DeleteCouponSubcode(DeleteCouponSubcodeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CouponId`, `Subcode`
- **Returns**: `void` (Task)
- **Error**: `ApiException<DeleteCouponSubcodeError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteCouponSubcodeRequest` | `src/Maxio/Requests/Coupons/DeleteCouponSubcodeRequest.cs` |
| `DeleteCouponSubcodeError` | `src/Maxio/Errors/DeleteCouponSubcodeError.cs` |

### FindCoupon

- **Auth**: `options.BasicAuth`
- **Signature**: `FindCoupon(FindCouponRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `product_family_id` ← `ProductFamilyId`, `code` ← `Code`, `currency_prices` ← `CurrencyPrices`
- **Returns**: `CouponResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `FindCouponRequest` | `src/Maxio/Requests/Coupons/FindCouponRequest.cs` |
| `CouponResponse` | `src/Maxio/Models/CouponResponse.cs` |

### ListCouponSubcodes

- **Auth**: `options.BasicAuth`
- **Signature**: `ListCouponSubcodes(ListCouponSubcodesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CouponId`
- **Query params (wire ← C#)**: `page` ← `Page`, `per_page` ← `PerPage`
- **Returns**: `CouponSubcodes`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListCouponSubcodesRequest` | `src/Maxio/Requests/Coupons/ListCouponSubcodesRequest.cs` |
| `CouponSubcodes` | `src/Maxio/Models/CouponSubcodes.cs` |

### ListCoupons

- **Auth**: `options.BasicAuth`
- **Signature**: `ListCoupons(ListCouponsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page` ← `Page`, `per_page` ← `PerPage`, `filter` ← `Filter`, `currency_prices` ← `CurrencyPrices`
- **Returns**: `IReadOnlyList<CouponResponse>`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListCouponsRequest` | `src/Maxio/Requests/Coupons/ListCouponsRequest.cs` |
| `ListCouponsFilter` | `src/Maxio/Models/ListCouponsFilter.cs` |
| `CouponResponse` | `src/Maxio/Models/CouponResponse.cs` |

### ListCouponsForProductFamily

- **Auth**: `options.BasicAuth`
- **Signature**: `ListCouponsForProductFamily(ListCouponsForProductFamilyRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProductFamilyId`
- **Query params (wire ← C#)**: `page` ← `Page`, `per_page` ← `PerPage`, `filter` ← `Filter`, `currency_prices` ← `CurrencyPrices`
- **Returns**: `IReadOnlyList<CouponResponse>`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListCouponsForProductFamilyRequest` | `src/Maxio/Requests/Coupons/ListCouponsForProductFamilyRequest.cs` |
| `ListCouponsFilter` | `src/Maxio/Models/ListCouponsFilter.cs` |
| `CouponResponse` | `src/Maxio/Models/CouponResponse.cs` |

### ReadCoupon

- **Auth**: `options.BasicAuth`
- **Signature**: `ReadCoupon(ReadCouponRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProductFamilyId`, `CouponId`
- **Query params (wire ← C#)**: `currency_prices` ← `CurrencyPrices`
- **Returns**: `CouponResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ReadCouponRequest` | `src/Maxio/Requests/Coupons/ReadCouponRequest.cs` |
| `CouponResponse` | `src/Maxio/Models/CouponResponse.cs` |

### ReadCouponUsage

- **Auth**: `options.BasicAuth`
- **Signature**: `ReadCouponUsage(ReadCouponUsageRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProductFamilyId`, `CouponId`
- **Returns**: `IReadOnlyList<CouponUsage>`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ReadCouponUsageRequest` | `src/Maxio/Requests/Coupons/ReadCouponUsageRequest.cs` |
| `CouponUsage` | `src/Maxio/Models/CouponUsage.cs` |

### UpdateCoupon

- **Auth**: `options.BasicAuth`
- **Signature**: `UpdateCoupon(UpdateCouponRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProductFamilyId`, `CouponId`
- **Returns**: `CouponResponse`
- **Error**: `ApiException<UpdateCouponError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdateCouponRequest` | `src/Maxio/Requests/Coupons/UpdateCouponRequest.cs` |
| `CouponRequest` | `src/Maxio/Models/CouponRequest.cs` |
| `CouponResponse` | `src/Maxio/Models/CouponResponse.cs` |
| `UpdateCouponError` | `src/Maxio/Errors/UpdateCouponError.cs` |
| `ErrorListResponse1` | `src/Maxio/Models/ErrorListResponse1.cs` |

### UpdateCouponSubcodes

- **Auth**: `options.BasicAuth`
- **Signature**: `UpdateCouponSubcodes(UpdateCouponSubcodesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CouponId`
- **Returns**: `CouponSubcodesResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpdateCouponSubcodesRequest` | `src/Maxio/Requests/Coupons/UpdateCouponSubcodesRequest.cs` |
| `CouponSubcodes` | `src/Maxio/Models/CouponSubcodes.cs` |
| `CouponSubcodesResponse` | `src/Maxio/Models/CouponSubcodesResponse.cs` |

### ValidateCoupon

- **Auth**: `options.BasicAuth`
- **Signature**: `ValidateCoupon(ValidateCouponRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Code`
- **Query params (wire ← C#)**: `code` ← `Code`, `product_family_id` ← `ProductFamilyId`
- **Returns**: `CouponResponse`
- **Error**: `ApiException<ValidateCouponError>` — **Case A (typed)**
- **Error accessors**: `TryGetSingleStringErrorResponse1(out SingleStringErrorResponse1)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ValidateCouponRequest` | `src/Maxio/Requests/Coupons/ValidateCouponRequest.cs` |
| `CouponResponse` | `src/Maxio/Models/CouponResponse.cs` |
| `ValidateCouponError` | `src/Maxio/Errors/ValidateCouponError.cs` |
| `SingleStringErrorResponse1` | `src/Maxio/Models/SingleStringErrorResponse1.cs` |

