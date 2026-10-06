<!-- Generated file — do not edit; regenerated with the SDK. -->

# Coupons — operations

Accessor: `client.Coupons` · Source: `Api/Coupons.cs` · 14 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### ArchiveCoupon

- **Auth**: `options.BasicAuth`
- **Signature**: `ArchiveCoupon(ArchiveCouponRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProductFamilyId`, `CouponId`
- **Returns**: `CouponResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ArchiveCouponRequest` | `Requests/Coupons/ArchiveCouponRequest.cs` |
| `CouponResponse` | `Models/CouponResponse.cs` |

### CreateCoupon

- **Auth**: `options.BasicAuth`
- **Signature**: `CreateCoupon(CreateCouponRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProductFamilyId`
- **Returns**: `CouponResponse`
- **Error**: `ApiException<CreateCouponError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreateCouponRequest` | `Requests/Coupons/CreateCouponRequest.cs` |
| `CouponRequest` | `Models/CouponRequest.cs` |
| `CouponResponse` | `Models/CouponResponse.cs` |
| `CreateCouponError` | `Errors/CreateCouponError.cs` |
| `ErrorListResponse1` | `Models/ErrorListResponse1.cs` |

### CreateCouponSubcodes

- **Auth**: `options.BasicAuth`
- **Signature**: `CreateCouponSubcodes(CreateCouponSubcodesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CouponId`
- **Returns**: `CouponSubcodesResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateCouponSubcodesRequest` | `Requests/Coupons/CreateCouponSubcodesRequest.cs` |
| `CouponSubcodes` | `Models/CouponSubcodes.cs` |
| `CouponSubcodesResponse` | `Models/CouponSubcodesResponse.cs` |

### CreateOrUpdateCouponCurrencyPrices

- **Auth**: `options.BasicAuth`
- **Signature**: `CreateOrUpdateCouponCurrencyPrices(CreateOrUpdateCouponCurrencyPricesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CouponId`
- **Returns**: `CouponCurrencyResponse`
- **Error**: `ApiException<CreateOrUpdateCouponCurrencyPricesError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorStringMapResponse1(out ErrorStringMapResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreateOrUpdateCouponCurrencyPricesRequest` | `Requests/Coupons/CreateOrUpdateCouponCurrencyPricesRequest.cs` |
| `CouponCurrencyRequest` | `Models/CouponCurrencyRequest.cs` |
| `CouponCurrencyResponse` | `Models/CouponCurrencyResponse.cs` |
| `CreateOrUpdateCouponCurrencyPricesError` | `Errors/CreateOrUpdateCouponCurrencyPricesError.cs` |
| `ErrorStringMapResponse1` | `Models/ErrorStringMapResponse1.cs` |

### DeleteCouponSubcode

- **Auth**: `options.BasicAuth`
- **Signature**: `DeleteCouponSubcode(DeleteCouponSubcodeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CouponId`, `Subcode`
- **Returns**: `void` (Task)
- **Error**: `ApiException<DeleteCouponSubcodeError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteCouponSubcodeRequest` | `Requests/Coupons/DeleteCouponSubcodeRequest.cs` |
| `DeleteCouponSubcodeError` | `Errors/DeleteCouponSubcodeError.cs` |

### FindCoupon

- **Auth**: `options.BasicAuth`
- **Signature**: `FindCoupon(FindCouponRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `product_family_id` ← `ProductFamilyId`, `code` ← `Code`, `currency_prices` ← `CurrencyPrices`
- **Returns**: `CouponResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `FindCouponRequest` | `Requests/Coupons/FindCouponRequest.cs` |
| `CouponResponse` | `Models/CouponResponse.cs` |

### ListCouponSubcodes

- **Auth**: `options.BasicAuth`
- **Signature**: `ListCouponSubcodes(ListCouponSubcodesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CouponId`
- **Query params (wire ← C#)**: `page` ← `Page`, `per_page` ← `PerPage`
- **Returns**: `CouponSubcodes`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListCouponSubcodesRequest` | `Requests/Coupons/ListCouponSubcodesRequest.cs` |
| `CouponSubcodes` | `Models/CouponSubcodes.cs` |

### ListCoupons

- **Auth**: `options.BasicAuth`
- **Signature**: `ListCoupons(ListCouponsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page` ← `Page`, `per_page` ← `PerPage`, `filter` ← `Filter`, `currency_prices` ← `CurrencyPrices`
- **Returns**: `IReadOnlyList<CouponResponse>`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListCouponsRequest` | `Requests/Coupons/ListCouponsRequest.cs` |
| `ListCouponsFilter` | `Models/ListCouponsFilter.cs` |
| `CouponResponse` | `Models/CouponResponse.cs` |

### ListCouponsForProductFamily

- **Auth**: `options.BasicAuth`
- **Signature**: `ListCouponsForProductFamily(ListCouponsForProductFamilyRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProductFamilyId`
- **Query params (wire ← C#)**: `page` ← `Page`, `per_page` ← `PerPage`, `filter` ← `Filter`, `currency_prices` ← `CurrencyPrices`
- **Returns**: `IReadOnlyList<CouponResponse>`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListCouponsForProductFamilyRequest` | `Requests/Coupons/ListCouponsForProductFamilyRequest.cs` |
| `ListCouponsFilter` | `Models/ListCouponsFilter.cs` |
| `CouponResponse` | `Models/CouponResponse.cs` |

### ReadCoupon

- **Auth**: `options.BasicAuth`
- **Signature**: `ReadCoupon(ReadCouponRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProductFamilyId`, `CouponId`
- **Query params (wire ← C#)**: `currency_prices` ← `CurrencyPrices`
- **Returns**: `CouponResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ReadCouponRequest` | `Requests/Coupons/ReadCouponRequest.cs` |
| `CouponResponse` | `Models/CouponResponse.cs` |

### ReadCouponUsage

- **Auth**: `options.BasicAuth`
- **Signature**: `ReadCouponUsage(ReadCouponUsageRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProductFamilyId`, `CouponId`
- **Returns**: `IReadOnlyList<CouponUsage>`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ReadCouponUsageRequest` | `Requests/Coupons/ReadCouponUsageRequest.cs` |
| `CouponUsage` | `Models/CouponUsage.cs` |

### UpdateCoupon

- **Auth**: `options.BasicAuth`
- **Signature**: `UpdateCoupon(UpdateCouponRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProductFamilyId`, `CouponId`
- **Returns**: `CouponResponse`
- **Error**: `ApiException<UpdateCouponError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdateCouponRequest` | `Requests/Coupons/UpdateCouponRequest.cs` |
| `CouponRequest` | `Models/CouponRequest.cs` |
| `CouponResponse` | `Models/CouponResponse.cs` |
| `UpdateCouponError` | `Errors/UpdateCouponError.cs` |
| `ErrorListResponse1` | `Models/ErrorListResponse1.cs` |

### UpdateCouponSubcodes

- **Auth**: `options.BasicAuth`
- **Signature**: `UpdateCouponSubcodes(UpdateCouponSubcodesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CouponId`
- **Returns**: `CouponSubcodesResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpdateCouponSubcodesRequest` | `Requests/Coupons/UpdateCouponSubcodesRequest.cs` |
| `CouponSubcodes` | `Models/CouponSubcodes.cs` |
| `CouponSubcodesResponse` | `Models/CouponSubcodesResponse.cs` |

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
| `ValidateCouponRequest` | `Requests/Coupons/ValidateCouponRequest.cs` |
| `CouponResponse` | `Models/CouponResponse.cs` |
| `ValidateCouponError` | `Errors/ValidateCouponError.cs` |
| `SingleStringErrorResponse1` | `Models/SingleStringErrorResponse1.cs` |

