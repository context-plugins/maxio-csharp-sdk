<!-- Generated file — do not edit; regenerated with the SDK. -->

# Subscriptions — operations

Accessor: `client.Subscriptions` · Source: `Api/Subscriptions.cs` · 12 operations

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
| `ActivateSubscriptionOperationRequest` | `Requests/Subscriptions/ActivateSubscriptionOperationRequest.cs` |
| `ActivateSubscriptionRequest` | `Models/ActivateSubscriptionRequest.cs` |
| `SubscriptionResponse` | `Models/SubscriptionResponse.cs` |
| `ActivateSubscriptionError` | `Errors/ActivateSubscriptionError.cs` |
| `ErrorArrayMapResponse1` | `Models/ErrorArrayMapResponse1.cs` |

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
| `ApplyCouponsToSubscriptionRequest` | `Requests/Subscriptions/ApplyCouponsToSubscriptionRequest.cs` |
| `AddCouponsRequest` | `Models/AddCouponsRequest.cs` |
| `SubscriptionResponse` | `Models/SubscriptionResponse.cs` |
| `ApplyCouponsToSubscriptionError` | `Errors/ApplyCouponsToSubscriptionError.cs` |
| `SubscriptionAddCouponError1` | `Models/SubscriptionAddCouponError1.cs` |

### CreateSubscription

- **Auth**: `options.BasicAuth`
- **Signature**: `CreateSubscription(CreateSubscriptionOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `SubscriptionResponse`
- **Error**: `ApiException<CreateSubscriptionError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreateSubscriptionOperationRequest` | `Requests/Subscriptions/CreateSubscriptionOperationRequest.cs` |
| `CreateSubscriptionRequest` | `Models/CreateSubscriptionRequest.cs` |
| `SubscriptionResponse` | `Models/SubscriptionResponse.cs` |
| `CreateSubscriptionError` | `Errors/CreateSubscriptionError.cs` |
| `ErrorListResponse1` | `Models/ErrorListResponse1.cs` |

### FindSubscription

- **Auth**: `options.BasicAuth`
- **Signature**: `FindSubscription(FindSubscriptionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `reference` ← `Reference`
- **Returns**: `SubscriptionResponse`
- **Error**: `ApiException<FindSubscriptionError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `FindSubscriptionRequest` | `Requests/Subscriptions/FindSubscriptionRequest.cs` |
| `SubscriptionResponse` | `Models/SubscriptionResponse.cs` |
| `FindSubscriptionError` | `Errors/FindSubscriptionError.cs` |

### ListSubscriptions

- **Auth**: `options.BasicAuth`
- **Signature**: `ListSubscriptions(ListSubscriptionsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page` ← `Page`, `per_page` ← `PerPage`, `sort` ← `Sort`, `direction` ← `Direction`, `state` ← `State`, `product` ← `Product`, `q` ← `Q`, `q_scope` ← `QScope`, `customer_id` ← `CustomerId`, `product_price_point_id` ← `ProductPricePointId`, `coupon` ← `Coupon`, `coupon_code` ← `CouponCode`, `collection_method` ← `CollectionMethod`, `branding_theme_id` ← `BrandingThemeId`, `date_field` ← `DateField`, `start_date` ← `StartDate`, `end_date` ← `EndDate`, `start_datetime` ← `StartDatetime`, `end_datetime` ← `EndDatetime`, `metadata` ← `Metadata`, `group_status` ← `GroupStatus`, `dunning_exemption` ← `DunningExemption`, `payment_gateways` ← `PaymentGateways`, `currencies` ← `Currencies`, `include` ← `Include`
- **Returns**: `IReadOnlyList<SubscriptionResponse>`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListSubscriptionsRequest` | `Requests/Subscriptions/ListSubscriptionsRequest.cs` |
| `SubscriptionSort` | `Models/Enums/SubscriptionSort.cs` |
| `SortingDirection` | `Models/Enums/SortingDirection.cs` |
| `SubscriptionStateFilter` | `Models/Enums/SubscriptionStateFilter.cs` |
| `Product1` | `Models/AnyOf/Product1.cs` |
| `QScope` | `Models/Enums/QScope.cs` |
| `CollectionMethod1` | `Models/Enums/CollectionMethod1.cs` |
| `SubscriptionDateField` | `Models/Enums/SubscriptionDateField.cs` |
| `GroupStatus` | `Models/Enums/GroupStatus.cs` |
| `SubscriptionListInclude` | `Models/Enums/SubscriptionListInclude.cs` |
| `SubscriptionResponse` | `Models/SubscriptionResponse.cs` |

### OverrideSubscription

- **Auth**: `options.BasicAuth`
- **Signature**: `OverrideSubscription(OverrideSubscriptionOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`
- **Returns**: `void` (Task)
- **Error**: `ApiException<OverrideSubscriptionError>` — **Case A (typed)**
- **Error accessors**: `TryGetSingleErrorResponse1(out SingleErrorResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `OverrideSubscriptionOperationRequest` | `Requests/Subscriptions/OverrideSubscriptionOperationRequest.cs` |
| `OverrideSubscriptionRequest` | `Models/OverrideSubscriptionRequest.cs` |
| `OverrideSubscriptionError` | `Errors/OverrideSubscriptionError.cs` |
| `SingleErrorResponse1` | `Models/SingleErrorResponse1.cs` |

### PreviewSubscription

- **Auth**: `options.BasicAuth`
- **Signature**: `PreviewSubscription(PreviewSubscriptionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `SubscriptionPreviewResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PreviewSubscriptionRequest` | `Requests/Subscriptions/PreviewSubscriptionRequest.cs` |
| `CreateSubscriptionRequest` | `Models/CreateSubscriptionRequest.cs` |
| `SubscriptionPreviewResponse` | `Models/SubscriptionPreviewResponse.cs` |

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
| `PurgeSubscriptionRequest` | `Requests/Subscriptions/PurgeSubscriptionRequest.cs` |
| `SubscriptionPurgeType` | `Models/Enums/SubscriptionPurgeType.cs` |
| `SubscriptionResponse` | `Models/SubscriptionResponse.cs` |
| `PurgeSubscriptionError` | `Errors/PurgeSubscriptionError.cs` |

### ReadSubscription

- **Auth**: `options.BasicAuth`
- **Signature**: `ReadSubscription(ReadSubscriptionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`
- **Query params (wire ← C#)**: `include` ← `Include`
- **Returns**: `SubscriptionResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ReadSubscriptionRequest` | `Requests/Subscriptions/ReadSubscriptionRequest.cs` |
| `SubscriptionInclude` | `Models/Enums/SubscriptionInclude.cs` |
| `SubscriptionResponse` | `Models/SubscriptionResponse.cs` |

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
| `RemoveCouponFromSubscriptionRequest` | `Requests/Subscriptions/RemoveCouponFromSubscriptionRequest.cs` |
| `RemoveCouponFromSubscriptionError` | `Errors/RemoveCouponFromSubscriptionError.cs` |
| `SubscriptionRemoveCouponErrors1` | `Models/SubscriptionRemoveCouponErrors1.cs` |

### UpdatePrepaidSubscriptionConfiguration

- **Auth**: `options.BasicAuth`
- **Signature**: `UpdatePrepaidSubscriptionConfiguration(UpdatePrepaidSubscriptionConfigurationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`
- **Returns**: `PrepaidConfigurationResponse`
- **Error**: `ApiException<UpdatePrepaidSubscriptionConfigurationError>` — **Case A (typed)**
- **Error accessors**: `TryGetPrepaidConfigurationErrorResponse(out PrepaidConfigurationErrorResponse)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdatePrepaidSubscriptionConfigurationRequest` | `Requests/Subscriptions/UpdatePrepaidSubscriptionConfigurationRequest.cs` |
| `UpsertPrepaidConfigurationRequest` | `Models/UpsertPrepaidConfigurationRequest.cs` |
| `PrepaidConfigurationResponse` | `Models/PrepaidConfigurationResponse.cs` |
| `UpdatePrepaidSubscriptionConfigurationError` | `Errors/UpdatePrepaidSubscriptionConfigurationError.cs` |
| `PrepaidConfigurationErrorResponse` | `Models/AnyOf/PrepaidConfigurationErrorResponse.cs` |

### UpdateSubscription

- **Auth**: `options.BasicAuth`
- **Signature**: `UpdateSubscription(UpdateSubscriptionOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`
- **Returns**: `SubscriptionResponse`
- **Error**: `ApiException<UpdateSubscriptionError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdateSubscriptionOperationRequest` | `Requests/Subscriptions/UpdateSubscriptionOperationRequest.cs` |
| `UpdateSubscriptionRequest` | `Models/UpdateSubscriptionRequest.cs` |
| `SubscriptionResponse` | `Models/SubscriptionResponse.cs` |
| `UpdateSubscriptionError` | `Errors/UpdateSubscriptionError.cs` |
| `ErrorListResponse1` | `Models/ErrorListResponse1.cs` |

