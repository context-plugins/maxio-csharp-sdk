<!-- Generated file — do not edit; regenerated with the SDK. -->

# ProformaInvoices — operations

Accessor: `client.ProformaInvoices` · Source: `Api/ProformaInvoices.cs` · 10 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateConsolidatedProformaInvoice

- **Auth**: `options.BasicAuth`
- **Signature**: `CreateConsolidatedProformaInvoice(CreateConsolidatedProformaInvoiceRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Uid`
- **Returns**: `void` (Task)
- **Error**: `ApiException<CreateConsolidatedProformaInvoiceError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreateConsolidatedProformaInvoiceRequest` | `Requests/ProformaInvoices/CreateConsolidatedProformaInvoiceRequest.cs` |
| `CreateConsolidatedProformaInvoiceError` | `Errors/CreateConsolidatedProformaInvoiceError.cs` |
| `ErrorListResponse1` | `Models/ErrorListResponse1.cs` |

### CreateProformaInvoice

- **Auth**: `options.BasicAuth`
- **Signature**: `CreateProformaInvoice(CreateProformaInvoiceRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`
- **Returns**: `ProformaInvoice`
- **Error**: `ApiException<CreateProformaInvoiceError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreateProformaInvoiceRequest` | `Requests/ProformaInvoices/CreateProformaInvoiceRequest.cs` |
| `ProformaInvoice` | `Models/ProformaInvoice.cs` |
| `CreateProformaInvoiceError` | `Errors/CreateProformaInvoiceError.cs` |
| `ErrorListResponse1` | `Models/ErrorListResponse1.cs` |

### CreateSignupProformaInvoice

- **Auth**: `options.BasicAuth`
- **Signature**: `CreateSignupProformaInvoice(CreateSignupProformaInvoiceRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `ProformaInvoice`
- **Error**: `ApiException<CreateSignupProformaInvoiceError>` — **Case A (typed)**
- **Error accessors**: `TryGetProformaBadRequestErrorResponse1(out ProformaBadRequestErrorResponse1)` [400] · `TryGetErrorArrayMapResponse1(out ErrorArrayMapResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreateSignupProformaInvoiceRequest` | `Requests/ProformaInvoices/CreateSignupProformaInvoiceRequest.cs` |
| `CreateSubscriptionRequest` | `Models/CreateSubscriptionRequest.cs` |
| `ProformaInvoice` | `Models/ProformaInvoice.cs` |
| `CreateSignupProformaInvoiceError` | `Errors/CreateSignupProformaInvoiceError.cs` |
| `ProformaBadRequestErrorResponse1` | `Models/ProformaBadRequestErrorResponse1.cs` |
| `ErrorArrayMapResponse1` | `Models/ErrorArrayMapResponse1.cs` |

### DeliverProformaInvoice

- **Auth**: `options.BasicAuth`
- **Signature**: `DeliverProformaInvoice(DeliverProformaInvoiceOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProformaInvoiceUid`
- **Returns**: `ProformaInvoice`
- **Error**: `ApiException<DeliverProformaInvoiceError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404] · `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeliverProformaInvoiceOperationRequest` | `Requests/ProformaInvoices/DeliverProformaInvoiceOperationRequest.cs` |
| `DeliverProformaInvoiceRequest` | `Models/DeliverProformaInvoiceRequest.cs` |
| `ProformaInvoice` | `Models/ProformaInvoice.cs` |
| `DeliverProformaInvoiceError` | `Errors/DeliverProformaInvoiceError.cs` |
| `ErrorListResponse1` | `Models/ErrorListResponse1.cs` |

### ListProformaInvoices

- **Auth**: `options.BasicAuth`
- **Signature**: `ListProformaInvoices(ListProformaInvoicesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`
- **Query params (wire ← C#)**: `start_date` ← `StartDate`, `end_date` ← `EndDate`, `status` ← `Status`, `page` ← `Page`, `per_page` ← `PerPage`, `direction` ← `Direction`, `line_items` ← `LineItems`, `discounts` ← `Discounts`, `taxes` ← `Taxes`, `credits` ← `Credits`, `payments` ← `Payments`, `custom_fields` ← `CustomFields`
- **Returns**: `ListProformaInvoicesResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListProformaInvoicesRequest` | `Requests/ProformaInvoices/ListProformaInvoicesRequest.cs` |
| `ProformaInvoiceStatus` | `Models/Enums/ProformaInvoiceStatus.cs` |
| `Direction` | `Models/Enums/Direction.cs` |
| `ListProformaInvoicesResponse` | `Models/ListProformaInvoicesResponse.cs` |

### ListSubscriptionGroupProformaInvoices

- **Auth**: `options.BasicAuth`
- **Signature**: `ListSubscriptionGroupProformaInvoices(ListSubscriptionGroupProformaInvoicesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Uid`
- **Query params (wire ← C#)**: `line_items` ← `LineItems`, `discounts` ← `Discounts`, `taxes` ← `Taxes`, `credits` ← `Credits`, `payments` ← `Payments`, `custom_fields` ← `CustomFields`
- **Returns**: `ListProformaInvoicesResponse`
- **Error**: `ApiException<ListSubscriptionGroupProformaInvoicesError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ListSubscriptionGroupProformaInvoicesRequest` | `Requests/ProformaInvoices/ListSubscriptionGroupProformaInvoicesRequest.cs` |
| `ListProformaInvoicesResponse` | `Models/ListProformaInvoicesResponse.cs` |
| `ListSubscriptionGroupProformaInvoicesError` | `Errors/ListSubscriptionGroupProformaInvoicesError.cs` |

### PreviewProformaInvoice

- **Auth**: `options.BasicAuth`
- **Signature**: `PreviewProformaInvoice(PreviewProformaInvoiceRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`
- **Returns**: `ProformaInvoice`
- **Error**: `ApiException<PreviewProformaInvoiceError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404] · `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PreviewProformaInvoiceRequest` | `Requests/ProformaInvoices/PreviewProformaInvoiceRequest.cs` |
| `ProformaInvoice` | `Models/ProformaInvoice.cs` |
| `PreviewProformaInvoiceError` | `Errors/PreviewProformaInvoiceError.cs` |
| `ErrorListResponse1` | `Models/ErrorListResponse1.cs` |

### PreviewSignupProformaInvoice

- **Auth**: `options.BasicAuth`
- **Signature**: `PreviewSignupProformaInvoice(PreviewSignupProformaInvoiceRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `include` ← `Include`
- **Returns**: `SignupProformaPreviewResponse`
- **Error**: `ApiException<PreviewSignupProformaInvoiceError>` — **Case A (typed)**
- **Error accessors**: `TryGetProformaBadRequestErrorResponse1(out ProformaBadRequestErrorResponse1)` [400] · `TryGetErrorArrayMapResponse1(out ErrorArrayMapResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PreviewSignupProformaInvoiceRequest` | `Requests/ProformaInvoices/PreviewSignupProformaInvoiceRequest.cs` |
| `CreateSignupProformaPreviewInclude` | `Models/Enums/CreateSignupProformaPreviewInclude.cs` |
| `CreateSubscriptionRequest` | `Models/CreateSubscriptionRequest.cs` |
| `SignupProformaPreviewResponse` | `Models/SignupProformaPreviewResponse.cs` |
| `PreviewSignupProformaInvoiceError` | `Errors/PreviewSignupProformaInvoiceError.cs` |
| `ProformaBadRequestErrorResponse1` | `Models/ProformaBadRequestErrorResponse1.cs` |
| `ErrorArrayMapResponse1` | `Models/ErrorArrayMapResponse1.cs` |

### ReadProformaInvoice

- **Auth**: `options.BasicAuth`
- **Signature**: `ReadProformaInvoice(ReadProformaInvoiceRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProformaInvoiceUid`
- **Returns**: `ProformaInvoice`
- **Error**: `ApiException<ReadProformaInvoiceError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ReadProformaInvoiceRequest` | `Requests/ProformaInvoices/ReadProformaInvoiceRequest.cs` |
| `ProformaInvoice` | `Models/ProformaInvoice.cs` |
| `ReadProformaInvoiceError` | `Errors/ReadProformaInvoiceError.cs` |

### VoidProformaInvoice

- **Auth**: `options.BasicAuth`
- **Signature**: `VoidProformaInvoice(VoidProformaInvoiceRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProformaInvoiceUid`
- **Returns**: `ProformaInvoice`
- **Error**: `ApiException<VoidProformaInvoiceError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404] · `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `VoidProformaInvoiceRequest` | `Requests/ProformaInvoices/VoidProformaInvoiceRequest.cs` |
| `VoidInvoiceRequest` | `Models/VoidInvoiceRequest.cs` |
| `ProformaInvoice` | `Models/ProformaInvoice.cs` |
| `VoidProformaInvoiceError` | `Errors/VoidProformaInvoiceError.cs` |
| `ErrorListResponse1` | `Models/ErrorListResponse1.cs` |

