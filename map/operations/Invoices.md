<!-- Generated file — do not edit; regenerated with the SDK. -->

# Invoices — operations

Accessor: `client.Invoices` · Source: `Api/Invoices.cs` · 19 operations

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
| `CreateInvoiceOperationRequest` | `Requests/Invoices/CreateInvoiceOperationRequest.cs` |
| `CreateInvoiceRequest` | `Models/CreateInvoiceRequest.cs` |
| `InvoiceResponse` | `Models/InvoiceResponse.cs` |
| `CreateInvoiceError` | `Errors/CreateInvoiceError.cs` |
| `ErrorArrayMapResponse1` | `Models/ErrorArrayMapResponse1.cs` |

### DeleteInvoice

- **Auth**: `options.BasicAuth`
- **Signature**: `DeleteInvoice(DeleteInvoiceRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`, `Uid`
- **Returns**: `void` (Task)
- **Error**: `ApiException<DeleteInvoiceError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [404, 422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteInvoiceRequest` | `Requests/Invoices/DeleteInvoiceRequest.cs` |
| `DeleteInvoiceError` | `Errors/DeleteInvoiceError.cs` |
| `ErrorListResponse1` | `Models/ErrorListResponse1.cs` |

### IssueInvoice

- **Auth**: `options.BasicAuth`
- **Signature**: `IssueInvoice(IssueInvoiceOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Uid`
- **Returns**: `Invoice`
- **Error**: `ApiException<IssueInvoiceError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404] · `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `IssueInvoiceOperationRequest` | `Requests/Invoices/IssueInvoiceOperationRequest.cs` |
| `IssueInvoiceRequest` | `Models/IssueInvoiceRequest.cs` |
| `Invoice` | `Models/Invoice.cs` |
| `IssueInvoiceError` | `Errors/IssueInvoiceError.cs` |
| `ErrorListResponse1` | `Models/ErrorListResponse1.cs` |

### ListConsolidatedInvoiceSegments

- **Auth**: `options.BasicAuth`
- **Signature**: `ListConsolidatedInvoiceSegments(ListConsolidatedInvoiceSegmentsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `InvoiceUid`
- **Query params (wire ← C#)**: `page` ← `Page`, `per_page` ← `PerPage`, `direction` ← `Direction`
- **Returns**: `ConsolidatedInvoice`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListConsolidatedInvoiceSegmentsRequest` | `Requests/Invoices/ListConsolidatedInvoiceSegmentsRequest.cs` |
| `Direction` | `Models/Enums/Direction.cs` |
| `ConsolidatedInvoice` | `Models/ConsolidatedInvoice.cs` |

### ListCreditNotes

- **Auth**: `options.BasicAuth`
- **Signature**: `ListCreditNotes(ListCreditNotesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `subscription_id` ← `SubscriptionId`, `date_field` ← `DateField`, `start_date` ← `StartDate`, `end_date` ← `EndDate`, `start_datetime` ← `StartDatetime`, `end_datetime` ← `EndDatetime`, `page` ← `Page`, `per_page` ← `PerPage`, `direction` ← `Direction`, `line_items` ← `LineItems`, `discounts` ← `Discounts`, `taxes` ← `Taxes`, `refunds` ← `Refunds`, `applications` ← `Applications`
- **Returns**: `ListCreditNotesResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListCreditNotesRequest` | `Requests/Invoices/ListCreditNotesRequest.cs` |
| `CreditNoteDateField` | `Models/Enums/CreditNoteDateField.cs` |
| `Direction` | `Models/Enums/Direction.cs` |
| `ListCreditNotesResponse` | `Models/ListCreditNotesResponse.cs` |

### ListInvoiceEvents

- **Auth**: `options.BasicAuth`
- **Signature**: `ListInvoiceEvents(ListInvoiceEventsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `since_date` ← `SinceDate`, `since_id` ← `SinceId`, `page` ← `Page`, `per_page` ← `PerPage`, `invoice_uid` ← `InvoiceUid`, `with_change_invoice_status` ← `WithChangeInvoiceStatus`, `event_types` ← `EventTypes`
- **Returns**: `ListInvoiceEventsResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListInvoiceEventsRequest` | `Requests/Invoices/ListInvoiceEventsRequest.cs` |
| `InvoiceEventType` | `Models/Enums/InvoiceEventType.cs` |
| `ListInvoiceEventsResponse` | `Models/ListInvoiceEventsResponse.cs` |

### ListInvoices

- **Auth**: `options.BasicAuth`
- **Signature**: `ListInvoices(ListInvoicesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `start_date` ← `StartDate`, `end_date` ← `EndDate`, `status` ← `Status`, `subscription_id` ← `SubscriptionId`, `subscription_group_uid` ← `SubscriptionGroupUid`, `consolidation_level` ← `ConsolidationLevel`, `page` ← `Page`, `per_page` ← `PerPage`, `direction` ← `Direction`, `line_items` ← `LineItems`, `discounts` ← `Discounts`, `taxes` ← `Taxes`, `credits` ← `Credits`, `payments` ← `Payments`, `custom_fields` ← `CustomFields`, `refunds` ← `Refunds`, `date_field` ← `DateField`, `start_datetime` ← `StartDatetime`, `end_datetime` ← `EndDatetime`, `customer_ids` ← `CustomerIds`, `number` ← `Number`, `product_ids` ← `ProductIds`, `sort` ← `Sort`
- **Returns**: `ListInvoicesResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListInvoicesRequest` | `Requests/Invoices/ListInvoicesRequest.cs` |
| `InvoiceStatus` | `Models/Enums/InvoiceStatus.cs` |
| `Direction` | `Models/Enums/Direction.cs` |
| `InvoiceDateField` | `Models/Enums/InvoiceDateField.cs` |
| `InvoiceSortField` | `Models/Enums/InvoiceSortField.cs` |
| `ListInvoicesResponse` | `Models/ListInvoicesResponse.cs` |

### PreviewCustomerInformationChanges

- **Auth**: `options.BasicAuth`
- **Signature**: `PreviewCustomerInformationChanges(PreviewCustomerInformationChangesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Uid`
- **Returns**: `CustomerChangesPreviewResponse`
- **Error**: `ApiException<PreviewCustomerInformationChangesError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [404, 422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PreviewCustomerInformationChangesRequest` | `Requests/Invoices/PreviewCustomerInformationChangesRequest.cs` |
| `CustomerChangesPreviewResponse` | `Models/CustomerChangesPreviewResponse.cs` |
| `PreviewCustomerInformationChangesError` | `Errors/PreviewCustomerInformationChangesError.cs` |
| `ErrorListResponse1` | `Models/ErrorListResponse1.cs` |

### ReadCreditNote

- **Auth**: `options.BasicAuth`
- **Signature**: `ReadCreditNote(ReadCreditNoteRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Uid`
- **Returns**: `CreditNote`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ReadCreditNoteRequest` | `Requests/Invoices/ReadCreditNoteRequest.cs` |
| `CreditNote` | `Models/CreditNote.cs` |

### ReadInvoice

- **Auth**: `options.BasicAuth`
- **Signature**: `ReadInvoice(ReadInvoiceRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Uid`
- **Returns**: `Invoice`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ReadInvoiceRequest` | `Requests/Invoices/ReadInvoiceRequest.cs` |
| `Invoice` | `Models/Invoice.cs` |

### RecordPaymentForInvoice

- **Auth**: `options.BasicAuth`
- **Signature**: `RecordPaymentForInvoice(RecordPaymentForInvoiceRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Uid`
- **Returns**: `Invoice`
- **Error**: `ApiException<RecordPaymentForInvoiceError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `RecordPaymentForInvoiceRequest` | `Requests/Invoices/RecordPaymentForInvoiceRequest.cs` |
| `CreateInvoicePaymentRequest` | `Models/CreateInvoicePaymentRequest.cs` |
| `Invoice` | `Models/Invoice.cs` |
| `RecordPaymentForInvoiceError` | `Errors/RecordPaymentForInvoiceError.cs` |
| `ErrorListResponse1` | `Models/ErrorListResponse1.cs` |

### RecordPaymentForMultipleInvoices

- **Auth**: `options.BasicAuth`
- **Signature**: `RecordPaymentForMultipleInvoices(RecordPaymentForMultipleInvoicesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `MultiInvoicePaymentResponse`
- **Error**: `ApiException<RecordPaymentForMultipleInvoicesError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `RecordPaymentForMultipleInvoicesRequest` | `Requests/Invoices/RecordPaymentForMultipleInvoicesRequest.cs` |
| `CreateMultiInvoicePaymentRequest` | `Models/CreateMultiInvoicePaymentRequest.cs` |
| `MultiInvoicePaymentResponse` | `Models/MultiInvoicePaymentResponse.cs` |
| `RecordPaymentForMultipleInvoicesError` | `Errors/RecordPaymentForMultipleInvoicesError.cs` |
| `ErrorListResponse1` | `Models/ErrorListResponse1.cs` |

### RecordPaymentForSubscription

- **Auth**: `options.BasicAuth`
- **Signature**: `RecordPaymentForSubscription(RecordPaymentForSubscriptionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`
- **Returns**: `RecordPaymentResponse`
- **Error**: `ApiException<RecordPaymentForSubscriptionError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `RecordPaymentForSubscriptionRequest` | `Requests/Invoices/RecordPaymentForSubscriptionRequest.cs` |
| `RecordPaymentRequest` | `Models/RecordPaymentRequest.cs` |
| `RecordPaymentResponse` | `Models/RecordPaymentResponse.cs` |
| `RecordPaymentForSubscriptionError` | `Errors/RecordPaymentForSubscriptionError.cs` |
| `ErrorListResponse1` | `Models/ErrorListResponse1.cs` |

### RefundInvoice

- **Auth**: `options.BasicAuth`
- **Signature**: `RefundInvoice(RefundInvoiceOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Uid`
- **Returns**: `Invoice`
- **Error**: `ApiException<RefundInvoiceError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `RefundInvoiceOperationRequest` | `Requests/Invoices/RefundInvoiceOperationRequest.cs` |
| `RefundInvoiceRequest` | `Models/RefundInvoiceRequest.cs` |
| `Invoice` | `Models/Invoice.cs` |
| `RefundInvoiceError` | `Errors/RefundInvoiceError.cs` |
| `ErrorListResponse1` | `Models/ErrorListResponse1.cs` |

### ReopenInvoice

- **Auth**: `options.BasicAuth`
- **Signature**: `ReopenInvoice(ReopenInvoiceRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Uid`
- **Returns**: `Invoice`
- **Error**: `ApiException<ReopenInvoiceError>` — **Case A (typed)**
- **Error accessors**: `TryGetObject(out object?)` [404] · `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ReopenInvoiceRequest` | `Requests/Invoices/ReopenInvoiceRequest.cs` |
| `Invoice` | `Models/Invoice.cs` |
| `ReopenInvoiceError` | `Errors/ReopenInvoiceError.cs` |
| `ErrorListResponse1` | `Models/ErrorListResponse1.cs` |

### SendInvoice

- **Auth**: `options.BasicAuth`
- **Signature**: `SendInvoice(SendInvoiceOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Uid`
- **Returns**: `void` (Task)
- **Error**: `ApiException<SendInvoiceError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SendInvoiceOperationRequest` | `Requests/Invoices/SendInvoiceOperationRequest.cs` |
| `SendInvoiceRequest` | `Models/SendInvoiceRequest.cs` |
| `SendInvoiceError` | `Errors/SendInvoiceError.cs` |
| `ErrorListResponse1` | `Models/ErrorListResponse1.cs` |

### UpdateCustomerInformation

- **Auth**: `options.BasicAuth`
- **Signature**: `UpdateCustomerInformation(UpdateCustomerInformationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Uid`
- **Returns**: `Invoice`
- **Error**: `ApiException<UpdateCustomerInformationError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [404, 422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdateCustomerInformationRequest` | `Requests/Invoices/UpdateCustomerInformationRequest.cs` |
| `Invoice` | `Models/Invoice.cs` |
| `UpdateCustomerInformationError` | `Errors/UpdateCustomerInformationError.cs` |
| `ErrorListResponse1` | `Models/ErrorListResponse1.cs` |

### UpdateInvoice

- **Auth**: `options.BasicAuth`
- **Signature**: `UpdateInvoice(UpdateInvoiceOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`, `Uid`
- **Returns**: `InvoiceResponse`
- **Error**: `ApiException<UpdateInvoiceError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [404] · `TryGetErrorArrayMapResponse1(out ErrorArrayMapResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdateInvoiceOperationRequest` | `Requests/Invoices/UpdateInvoiceOperationRequest.cs` |
| `UpdateInvoiceRequest` | `Models/UpdateInvoiceRequest.cs` |
| `InvoiceResponse` | `Models/InvoiceResponse.cs` |
| `UpdateInvoiceError` | `Errors/UpdateInvoiceError.cs` |
| `ErrorListResponse1` | `Models/ErrorListResponse1.cs` |
| `ErrorArrayMapResponse1` | `Models/ErrorArrayMapResponse1.cs` |

### VoidInvoice

- **Auth**: `options.BasicAuth`
- **Signature**: `VoidInvoice(VoidInvoiceOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Uid`
- **Returns**: `Invoice`
- **Error**: `ApiException<VoidInvoiceError>` — **Case A (typed)**
- **Error accessors**: `TryGetObject(out object?)` [404] · `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `VoidInvoiceOperationRequest` | `Requests/Invoices/VoidInvoiceOperationRequest.cs` |
| `VoidInvoiceRequest` | `Models/VoidInvoiceRequest.cs` |
| `Invoice` | `Models/Invoice.cs` |
| `VoidInvoiceError` | `Errors/VoidInvoiceError.cs` |
| `ErrorListResponse1` | `Models/ErrorListResponse1.cs` |

