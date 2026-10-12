<!-- Generated file — do not edit; regenerated with the SDK. -->

# Subscriptions — operations

Accessor: `client.Subscriptions` · Source: `src/Maxio/Api/Subscriptions.cs` · 12 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### ActivateSubscription

- **Auth**: `options.BasicAuth`
- **Signature**: `ActivateSubscription(ActivateSubscriptionOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`
- **Returns**: `SubscriptionResponse`
- **Error**: `ApiException<ActivateSubscriptionError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorArrayMapResponse1(out ErrorArrayMapResponse1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ActivateSubscriptionOperationRequest` | `src/Maxio/Requests/Subscriptions/ActivateSubscriptionOperationRequest.cs` |
| `ActivateSubscriptionRequest` | `src/Maxio/Models/ActivateSubscriptionRequest.cs` |
| `SubscriptionResponse` | `src/Maxio/Models/SubscriptionResponse.cs` |
| `ActivateSubscriptionError` | `src/Maxio/Errors/ActivateSubscriptionError.cs` |
| `ErrorArrayMapResponse1` | `src/Maxio/Models/ErrorArrayMapResponse1.cs` |

### ApplyCouponsToSubscription

- **Auth**: `options.BasicAuth`
- **Signature**: `ApplyCouponsToSubscription(ApplyCouponsToSubscriptionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`
- **Query params (wire ← C#)**: `code` ← `Code`
- **Returns**: `SubscriptionResponse`
- **Error**: `ApiException<ApplyCouponsToSubscriptionError>` — **Case A (typed)**
- **Error accessors**: `TryGetSubscriptionAddCouponError1(out SubscriptionAddCouponError1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ApplyCouponsToSubscriptionRequest` | `src/Maxio/Requests/Subscriptions/ApplyCouponsToSubscriptionRequest.cs` |
| `AddCouponsRequest` | `src/Maxio/Models/AddCouponsRequest.cs` |
| `SubscriptionResponse` | `src/Maxio/Models/SubscriptionResponse.cs` |
| `ApplyCouponsToSubscriptionError` | `src/Maxio/Errors/ApplyCouponsToSubscriptionError.cs` |
| `SubscriptionAddCouponError1` | `src/Maxio/Models/SubscriptionAddCouponError1.cs` |

### CreateSubscription

- **Auth**: `options.BasicAuth`
- **Signature**: `CreateSubscription(CreateSubscriptionOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `SubscriptionResponse`
- **Error**: `ApiException<CreateSubscriptionError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreateSubscriptionOperationRequest` | `src/Maxio/Requests/Subscriptions/CreateSubscriptionOperationRequest.cs` |
| `CreateSubscriptionRequest` | `src/Maxio/Models/CreateSubscriptionRequest.cs` |
| `SubscriptionResponse` | `src/Maxio/Models/SubscriptionResponse.cs` |
| `CreateSubscriptionError` | `src/Maxio/Errors/CreateSubscriptionError.cs` |
| `ErrorListResponse1` | `src/Maxio/Models/ErrorListResponse1.cs` |

### FindSubscription

- **Auth**: `options.BasicAuth`
- **Signature**: `FindSubscription(FindSubscriptionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `reference` ← `Reference`
- **Returns**: `SubscriptionResponse`
- **Error**: `ApiException<FindSubscriptionError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `FindSubscriptionRequest` | `src/Maxio/Requests/Subscriptions/FindSubscriptionRequest.cs` |
| `SubscriptionResponse` | `src/Maxio/Models/SubscriptionResponse.cs` |
| `FindSubscriptionError` | `src/Maxio/Errors/FindSubscriptionError.cs` |

### ListSubscriptions

- **Auth**: `options.BasicAuth`
- **Signature**: `ListSubscriptions(ListSubscriptionsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page` ← `Page`, `per_page` ← `PerPage`, `sort` ← `Sort`, `direction` ← `Direction`, `state` ← `State`, `product` ← `Product`, `q` ← `Q`, `q_scope` ← `QScope`, `customer_id` ← `CustomerId`, `product_price_point_id` ← `ProductPricePointId`, `coupon` ← `Coupon`, `coupon_code` ← `CouponCode`, `collection_method` ← `CollectionMethod`, `branding_theme_id` ← `BrandingThemeId`, `date_field` ← `DateField`, `start_date` ← `StartDate`, `end_date` ← `EndDate`, `start_datetime` ← `StartDatetime`, `end_datetime` ← `EndDatetime`, `metadata` ← `Metadata`, `group_status` ← `GroupStatus`, `dunning_exemption` ← `DunningExemption`, `payment_gateways` ← `PaymentGateways`, `currencies` ← `Currencies`, `include` ← `Include`
- **Returns**: `IReadOnlyList<SubscriptionResponse>`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListSubscriptionsRequest` | `src/Maxio/Requests/Subscriptions/ListSubscriptionsRequest.cs` |
| `SubscriptionSort` | `src/Maxio/Models/Enums/SubscriptionSort.cs` |
| `SortingDirection` | `src/Maxio/Models/Enums/SortingDirection.cs` |
| `SubscriptionStateFilter` | `src/Maxio/Models/Enums/SubscriptionStateFilter.cs` |
| `Product1` | `src/Maxio/Models/AnyOf/Product1.cs` |
| `QScope` | `src/Maxio/Models/Enums/QScope.cs` |
| `CollectionMethod1` | `src/Maxio/Models/Enums/CollectionMethod1.cs` |
| `SubscriptionDateField` | `src/Maxio/Models/Enums/SubscriptionDateField.cs` |
| `GroupStatus` | `src/Maxio/Models/Enums/GroupStatus.cs` |
| `SubscriptionListInclude` | `src/Maxio/Models/Enums/SubscriptionListInclude.cs` |
| `SubscriptionResponse` | `src/Maxio/Models/SubscriptionResponse.cs` |

### OverrideSubscription

- **Auth**: `options.BasicAuth`
- **Signature**: `OverrideSubscription(OverrideSubscriptionOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`
- **Returns**: `void` (Task)
- **Error**: `ApiException<OverrideSubscriptionError>` — **Case A (typed)**
- **Error accessors**: `TryGetSingleErrorResponse1(out SingleErrorResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `OverrideSubscriptionOperationRequest` | `src/Maxio/Requests/Subscriptions/OverrideSubscriptionOperationRequest.cs` |
| `OverrideSubscriptionRequest` | `src/Maxio/Models/OverrideSubscriptionRequest.cs` |
| `OverrideSubscriptionError` | `src/Maxio/Errors/OverrideSubscriptionError.cs` |
| `SingleErrorResponse1` | `src/Maxio/Models/SingleErrorResponse1.cs` |

### PreviewSubscription

- **Auth**: `options.BasicAuth`
- **Signature**: `PreviewSubscription(PreviewSubscriptionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `SubscriptionPreviewResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PreviewSubscriptionRequest` | `src/Maxio/Requests/Subscriptions/PreviewSubscriptionRequest.cs` |
| `CreateSubscriptionRequest` | `src/Maxio/Models/CreateSubscriptionRequest.cs` |
| `SubscriptionPreviewResponse` | `src/Maxio/Models/SubscriptionPreviewResponse.cs` |

### PurgeSubscription

- **Auth**: `options.BasicAuth`
- **Signature**: `PurgeSubscription(PurgeSubscriptionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`, `Ack`
- **Query params (wire ← C#)**: `ack` ← `Ack`, `cascade` ← `Cascade`
- **Returns**: `SubscriptionResponse`
- **Error**: `ApiException<PurgeSubscriptionError>` — **Case A (typed)**
- **Error accessors**: `TryGetSubscriptionResponse(out SubscriptionResponse)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PurgeSubscriptionRequest` | `src/Maxio/Requests/Subscriptions/PurgeSubscriptionRequest.cs` |
| `SubscriptionPurgeType` | `src/Maxio/Models/Enums/SubscriptionPurgeType.cs` |
| `SubscriptionResponse` | `src/Maxio/Models/SubscriptionResponse.cs` |
| `PurgeSubscriptionError` | `src/Maxio/Errors/PurgeSubscriptionError.cs` |

### ReadSubscription

- **Auth**: `options.BasicAuth`
- **Signature**: `ReadSubscription(ReadSubscriptionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`
- **Query params (wire ← C#)**: `include` ← `Include`
- **Returns**: `SubscriptionResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ReadSubscriptionRequest` | `src/Maxio/Requests/Subscriptions/ReadSubscriptionRequest.cs` |
| `SubscriptionInclude` | `src/Maxio/Models/Enums/SubscriptionInclude.cs` |
| `SubscriptionResponse` | `src/Maxio/Models/SubscriptionResponse.cs` |

### RemoveCouponFromSubscription

- **Auth**: `options.BasicAuth`
- **Signature**: `RemoveCouponFromSubscription(RemoveCouponFromSubscriptionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`
- **Query params (wire ← C#)**: `coupon_code` ← `CouponCode`
- **Returns**: `string`
- **Error**: `ApiException<RemoveCouponFromSubscriptionError>` — **Case A (typed)**
- **Error accessors**: `TryGetSubscriptionRemoveCouponErrors1(out SubscriptionRemoveCouponErrors1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `RemoveCouponFromSubscriptionRequest` | `src/Maxio/Requests/Subscriptions/RemoveCouponFromSubscriptionRequest.cs` |
| `RemoveCouponFromSubscriptionError` | `src/Maxio/Errors/RemoveCouponFromSubscriptionError.cs` |
| `SubscriptionRemoveCouponErrors1` | `src/Maxio/Models/SubscriptionRemoveCouponErrors1.cs` |

### UpdatePrepaidSubscriptionConfiguration

- **Auth**: `options.BasicAuth`
- **Signature**: `UpdatePrepaidSubscriptionConfiguration(UpdatePrepaidSubscriptionConfigurationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`
- **Returns**: `PrepaidConfigurationResponse`
- **Error**: `ApiException<UpdatePrepaidSubscriptionConfigurationError>` — **Case A (typed)**
- **Error accessors**: `TryGetPrepaidConfigurationErrorResponse(out PrepaidConfigurationErrorResponse)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdatePrepaidSubscriptionConfigurationRequest` | `src/Maxio/Requests/Subscriptions/UpdatePrepaidSubscriptionConfigurationRequest.cs` |
| `UpsertPrepaidConfigurationRequest` | `src/Maxio/Models/UpsertPrepaidConfigurationRequest.cs` |
| `PrepaidConfigurationResponse` | `src/Maxio/Models/PrepaidConfigurationResponse.cs` |
| `UpdatePrepaidSubscriptionConfigurationError` | `src/Maxio/Errors/UpdatePrepaidSubscriptionConfigurationError.cs` |
| `PrepaidConfigurationErrorResponse` | `src/Maxio/Models/AnyOf/PrepaidConfigurationErrorResponse.cs` |

### UpdateSubscription

- **Auth**: `options.BasicAuth`
- **Signature**: `UpdateSubscription(UpdateSubscriptionOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`
- **Returns**: `SubscriptionResponse`
- **Error**: `ApiException<UpdateSubscriptionError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdateSubscriptionOperationRequest` | `src/Maxio/Requests/Subscriptions/UpdateSubscriptionOperationRequest.cs` |
| `UpdateSubscriptionRequest` | `src/Maxio/Models/UpdateSubscriptionRequest.cs` |
| `SubscriptionResponse` | `src/Maxio/Models/SubscriptionResponse.cs` |
| `UpdateSubscriptionError` | `src/Maxio/Errors/UpdateSubscriptionError.cs` |
| `ErrorListResponse1` | `src/Maxio/Models/ErrorListResponse1.cs` |

