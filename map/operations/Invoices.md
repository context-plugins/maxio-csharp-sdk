<!-- Generated file — do not edit; regenerated with the SDK. -->

# Invoices — operations

Accessor: `client.Invoices` · Source: `src/Maxio/Api/Invoices.cs` · 19 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateInvoice

- **Auth**: `options.BasicAuth`
- **Signature**: `CreateInvoice(CreateInvoiceOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`
- **Returns**: `InvoiceResponse`
- **Error**: `ApiException<CreateInvoiceError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorArrayMapResponse1(out ErrorArrayMapResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreateInvoiceOperationRequest` | `src/Maxio/Requests/Invoices/CreateInvoiceOperationRequest.cs` |
| `CreateInvoiceRequest` | `src/Maxio/Models/CreateInvoiceRequest.cs` |
| `InvoiceResponse` | `src/Maxio/Models/InvoiceResponse.cs` |
| `CreateInvoiceError` | `src/Maxio/Errors/CreateInvoiceError.cs` |
| `ErrorArrayMapResponse1` | `src/Maxio/Models/ErrorArrayMapResponse1.cs` |

### DeleteInvoice

- **Auth**: `options.BasicAuth`
- **Signature**: `DeleteInvoice(DeleteInvoiceRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`, `Uid`
- **Returns**: `void` (Task)
- **Error**: `ApiException<DeleteInvoiceError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [404, 422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteInvoiceRequest` | `src/Maxio/Requests/Invoices/DeleteInvoiceRequest.cs` |
| `DeleteInvoiceError` | `src/Maxio/Errors/DeleteInvoiceError.cs` |
| `ErrorListResponse1` | `src/Maxio/Models/ErrorListResponse1.cs` |

### IssueInvoice

- **Auth**: `options.BasicAuth`
- **Signature**: `IssueInvoice(IssueInvoiceOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Uid`
- **Returns**: `Invoice`
- **Error**: `ApiException<IssueInvoiceError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404] · `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `IssueInvoiceOperationRequest` | `src/Maxio/Requests/Invoices/IssueInvoiceOperationRequest.cs` |
| `IssueInvoiceRequest` | `src/Maxio/Models/IssueInvoiceRequest.cs` |
| `Invoice` | `src/Maxio/Models/Invoice.cs` |
| `IssueInvoiceError` | `src/Maxio/Errors/IssueInvoiceError.cs` |
| `ErrorListResponse1` | `src/Maxio/Models/ErrorListResponse1.cs` |

### ListConsolidatedInvoiceSegments

- **Auth**: `options.BasicAuth`
- **Signature**: `ListConsolidatedInvoiceSegments(ListConsolidatedInvoiceSegmentsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `InvoiceUid`
- **Query params (wire ← C#)**: `page` ← `Page`, `per_page` ← `PerPage`, `direction` ← `Direction`
- **Returns**: `ConsolidatedInvoice`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListConsolidatedInvoiceSegmentsRequest` | `src/Maxio/Requests/Invoices/ListConsolidatedInvoiceSegmentsRequest.cs` |
| `Direction` | `src/Maxio/Models/Enums/Direction.cs` |
| `ConsolidatedInvoice` | `src/Maxio/Models/ConsolidatedInvoice.cs` |

### ListCreditNotes

- **Auth**: `options.BasicAuth`
- **Signature**: `ListCreditNotes(ListCreditNotesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `subscription_id` ← `SubscriptionId`, `date_field` ← `DateField`, `start_date` ← `StartDate`, `end_date` ← `EndDate`, `start_datetime` ← `StartDatetime`, `end_datetime` ← `EndDatetime`, `page` ← `Page`, `per_page` ← `PerPage`, `direction` ← `Direction`, `line_items` ← `LineItems`, `discounts` ← `Discounts`, `taxes` ← `Taxes`, `refunds` ← `Refunds`, `applications` ← `Applications`
- **Returns**: `ListCreditNotesResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListCreditNotesRequest` | `src/Maxio/Requests/Invoices/ListCreditNotesRequest.cs` |
| `CreditNoteDateField` | `src/Maxio/Models/Enums/CreditNoteDateField.cs` |
| `Direction` | `src/Maxio/Models/Enums/Direction.cs` |
| `ListCreditNotesResponse` | `src/Maxio/Models/ListCreditNotesResponse.cs` |

### ListInvoiceEvents

- **Auth**: `options.BasicAuth`
- **Signature**: `ListInvoiceEvents(ListInvoiceEventsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `since_date` ← `SinceDate`, `since_id` ← `SinceId`, `page` ← `Page`, `per_page` ← `PerPage`, `invoice_uid` ← `InvoiceUid`, `with_change_invoice_status` ← `WithChangeInvoiceStatus`, `event_types` ← `EventTypes`
- **Returns**: `ListInvoiceEventsResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListInvoiceEventsRequest` | `src/Maxio/Requests/Invoices/ListInvoiceEventsRequest.cs` |
| `InvoiceEventType` | `src/Maxio/Models/Enums/InvoiceEventType.cs` |
| `ListInvoiceEventsResponse` | `src/Maxio/Models/ListInvoiceEventsResponse.cs` |

### ListInvoices

- **Auth**: `options.BasicAuth`
- **Signature**: `ListInvoices(ListInvoicesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `start_date` ← `StartDate`, `end_date` ← `EndDate`, `status` ← `Status`, `subscription_id` ← `SubscriptionId`, `subscription_group_uid` ← `SubscriptionGroupUid`, `consolidation_level` ← `ConsolidationLevel`, `page` ← `Page`, `per_page` ← `PerPage`, `direction` ← `Direction`, `line_items` ← `LineItems`, `discounts` ← `Discounts`, `taxes` ← `Taxes`, `credits` ← `Credits`, `payments` ← `Payments`, `custom_fields` ← `CustomFields`, `refunds` ← `Refunds`, `date_field` ← `DateField`, `start_datetime` ← `StartDatetime`, `end_datetime` ← `EndDatetime`, `customer_ids` ← `CustomerIds`, `number` ← `Number`, `product_ids` ← `ProductIds`, `sort` ← `Sort`
- **Returns**: `ListInvoicesResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListInvoicesRequest` | `src/Maxio/Requests/Invoices/ListInvoicesRequest.cs` |
| `InvoiceStatus` | `src/Maxio/Models/Enums/InvoiceStatus.cs` |
| `Direction` | `src/Maxio/Models/Enums/Direction.cs` |
| `InvoiceDateField` | `src/Maxio/Models/Enums/InvoiceDateField.cs` |
| `InvoiceSortField` | `src/Maxio/Models/Enums/InvoiceSortField.cs` |
| `ListInvoicesResponse` | `src/Maxio/Models/ListInvoicesResponse.cs` |

### PreviewCustomerInformationChanges

- **Auth**: `options.BasicAuth`
- **Signature**: `PreviewCustomerInformationChanges(PreviewCustomerInformationChangesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Uid`
- **Returns**: `CustomerChangesPreviewResponse`
- **Error**: `ApiException<PreviewCustomerInformationChangesError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [404, 422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PreviewCustomerInformationChangesRequest` | `src/Maxio/Requests/Invoices/PreviewCustomerInformationChangesRequest.cs` |
| `CustomerChangesPreviewResponse` | `src/Maxio/Models/CustomerChangesPreviewResponse.cs` |
| `PreviewCustomerInformationChangesError` | `src/Maxio/Errors/PreviewCustomerInformationChangesError.cs` |
| `ErrorListResponse1` | `src/Maxio/Models/ErrorListResponse1.cs` |

### ReadCreditNote

- **Auth**: `options.BasicAuth`
- **Signature**: `ReadCreditNote(ReadCreditNoteRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Uid`
- **Returns**: `CreditNote`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ReadCreditNoteRequest` | `src/Maxio/Requests/Invoices/ReadCreditNoteRequest.cs` |
| `CreditNote` | `src/Maxio/Models/CreditNote.cs` |

### ReadInvoice

- **Auth**: `options.BasicAuth`
- **Signature**: `ReadInvoice(ReadInvoiceRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Uid`
- **Returns**: `Invoice`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ReadInvoiceRequest` | `src/Maxio/Requests/Invoices/ReadInvoiceRequest.cs` |
| `Invoice` | `src/Maxio/Models/Invoice.cs` |

### RecordPaymentForInvoice

- **Auth**: `options.BasicAuth`
- **Signature**: `RecordPaymentForInvoice(RecordPaymentForInvoiceRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Uid`
- **Returns**: `Invoice`
- **Error**: `ApiException<RecordPaymentForInvoiceError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `RecordPaymentForInvoiceRequest` | `src/Maxio/Requests/Invoices/RecordPaymentForInvoiceRequest.cs` |
| `CreateInvoicePaymentRequest` | `src/Maxio/Models/CreateInvoicePaymentRequest.cs` |
| `Invoice` | `src/Maxio/Models/Invoice.cs` |
| `RecordPaymentForInvoiceError` | `src/Maxio/Errors/RecordPaymentForInvoiceError.cs` |
| `ErrorListResponse1` | `src/Maxio/Models/ErrorListResponse1.cs` |

### RecordPaymentForMultipleInvoices

- **Auth**: `options.BasicAuth`
- **Signature**: `RecordPaymentForMultipleInvoices(RecordPaymentForMultipleInvoicesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `MultiInvoicePaymentResponse`
- **Error**: `ApiException<RecordPaymentForMultipleInvoicesError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `RecordPaymentForMultipleInvoicesRequest` | `src/Maxio/Requests/Invoices/RecordPaymentForMultipleInvoicesRequest.cs` |
| `CreateMultiInvoicePaymentRequest` | `src/Maxio/Models/CreateMultiInvoicePaymentRequest.cs` |
| `MultiInvoicePaymentResponse` | `src/Maxio/Models/MultiInvoicePaymentResponse.cs` |
| `RecordPaymentForMultipleInvoicesError` | `src/Maxio/Errors/RecordPaymentForMultipleInvoicesError.cs` |
| `ErrorListResponse1` | `src/Maxio/Models/ErrorListResponse1.cs` |

### RecordPaymentForSubscription

- **Auth**: `options.BasicAuth`
- **Signature**: `RecordPaymentForSubscription(RecordPaymentForSubscriptionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`
- **Returns**: `RecordPaymentResponse`
- **Error**: `ApiException<RecordPaymentForSubscriptionError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `RecordPaymentForSubscriptionRequest` | `src/Maxio/Requests/Invoices/RecordPaymentForSubscriptionRequest.cs` |
| `RecordPaymentRequest` | `src/Maxio/Models/RecordPaymentRequest.cs` |
| `RecordPaymentResponse` | `src/Maxio/Models/RecordPaymentResponse.cs` |
| `RecordPaymentForSubscriptionError` | `src/Maxio/Errors/RecordPaymentForSubscriptionError.cs` |
| `ErrorListResponse1` | `src/Maxio/Models/ErrorListResponse1.cs` |

### RefundInvoice

- **Auth**: `options.BasicAuth`
- **Signature**: `RefundInvoice(RefundInvoiceOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Uid`
- **Returns**: `Invoice`
- **Error**: `ApiException<RefundInvoiceError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `RefundInvoiceOperationRequest` | `src/Maxio/Requests/Invoices/RefundInvoiceOperationRequest.cs` |
| `RefundInvoiceRequest` | `src/Maxio/Models/RefundInvoiceRequest.cs` |
| `Invoice` | `src/Maxio/Models/Invoice.cs` |
| `RefundInvoiceError` | `src/Maxio/Errors/RefundInvoiceError.cs` |
| `ErrorListResponse1` | `src/Maxio/Models/ErrorListResponse1.cs` |

### ReopenInvoice

- **Auth**: `options.BasicAuth`
- **Signature**: `ReopenInvoice(ReopenInvoiceRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Uid`
- **Returns**: `Invoice`
- **Error**: `ApiException<ReopenInvoiceError>` — **Case A (typed)**
- **Error accessors**: `TryGetObject(out object?)` [404] · `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ReopenInvoiceRequest` | `src/Maxio/Requests/Invoices/ReopenInvoiceRequest.cs` |
| `Invoice` | `src/Maxio/Models/Invoice.cs` |
| `ReopenInvoiceError` | `src/Maxio/Errors/ReopenInvoiceError.cs` |
| `ErrorListResponse1` | `src/Maxio/Models/ErrorListResponse1.cs` |

### SendInvoice

- **Auth**: `options.BasicAuth`
- **Signature**: `SendInvoice(SendInvoiceOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Uid`
- **Returns**: `void` (Task)
- **Error**: `ApiException<SendInvoiceError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SendInvoiceOperationRequest` | `src/Maxio/Requests/Invoices/SendInvoiceOperationRequest.cs` |
| `SendInvoiceRequest` | `src/Maxio/Models/SendInvoiceRequest.cs` |
| `SendInvoiceError` | `src/Maxio/Errors/SendInvoiceError.cs` |
| `ErrorListResponse1` | `src/Maxio/Models/ErrorListResponse1.cs` |

### UpdateCustomerInformation

- **Auth**: `options.BasicAuth`
- **Signature**: `UpdateCustomerInformation(UpdateCustomerInformationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Uid`
- **Returns**: `Invoice`
- **Error**: `ApiException<UpdateCustomerInformationError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [404, 422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdateCustomerInformationRequest` | `src/Maxio/Requests/Invoices/UpdateCustomerInformationRequest.cs` |
| `Invoice` | `src/Maxio/Models/Invoice.cs` |
| `UpdateCustomerInformationError` | `src/Maxio/Errors/UpdateCustomerInformationError.cs` |
| `ErrorListResponse1` | `src/Maxio/Models/ErrorListResponse1.cs` |

### UpdateInvoice

- **Auth**: `options.BasicAuth`
- **Signature**: `UpdateInvoice(UpdateInvoiceOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`, `Uid`
- **Returns**: `InvoiceResponse`
- **Error**: `ApiException<UpdateInvoiceError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [404] · `TryGetErrorArrayMapResponse1(out ErrorArrayMapResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdateInvoiceOperationRequest` | `src/Maxio/Requests/Invoices/UpdateInvoiceOperationRequest.cs` |
| `UpdateInvoiceRequest` | `src/Maxio/Models/UpdateInvoiceRequest.cs` |
| `InvoiceResponse` | `src/Maxio/Models/InvoiceResponse.cs` |
| `UpdateInvoiceError` | `src/Maxio/Errors/UpdateInvoiceError.cs` |
| `ErrorListResponse1` | `src/Maxio/Models/ErrorListResponse1.cs` |
| `ErrorArrayMapResponse1` | `src/Maxio/Models/ErrorArrayMapResponse1.cs` |

### VoidInvoice

- **Auth**: `options.BasicAuth`
- **Signature**: `VoidInvoice(VoidInvoiceOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Uid`
- **Returns**: `Invoice`
- **Error**: `ApiException<VoidInvoiceError>` — **Case A (typed)**
- **Error accessors**: `TryGetObject(out object?)` [404] · `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `VoidInvoiceOperationRequest` | `src/Maxio/Requests/Invoices/VoidInvoiceOperationRequest.cs` |
| `VoidInvoiceRequest` | `src/Maxio/Models/VoidInvoiceRequest.cs` |
| `Invoice` | `src/Maxio/Models/Invoice.cs` |
| `VoidInvoiceError` | `src/Maxio/Errors/VoidInvoiceError.cs` |
| `ErrorListResponse1` | `src/Maxio/Models/ErrorListResponse1.cs` |

