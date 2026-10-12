<!-- Generated file — do not edit; regenerated with the SDK. -->

# Customers — operations

Accessor: `client.Customers` · Source: `src/Maxio/Api/Customers.cs` · 7 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateCustomer

- **Auth**: `options.BasicAuth`
- **Signature**: `CreateCustomer(CreateCustomerOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `CustomerResponse`
- **Error**: `ApiException<CreateCustomerError>` — **Case A (typed)**
- **Error accessors**: `TryGetCustomerErrorResponse1(out CustomerErrorResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreateCustomerOperationRequest` | `src/Maxio/Requests/Customers/CreateCustomerOperationRequest.cs` |
| `CreateCustomerRequest` | `src/Maxio/Models/CreateCustomerRequest.cs` |
| `CustomerResponse` | `src/Maxio/Models/CustomerResponse.cs` |
| `CreateCustomerError` | `src/Maxio/Errors/CreateCustomerError.cs` |
| `CustomerErrorResponse1` | `src/Maxio/Models/CustomerErrorResponse1.cs` |

### DeleteCustomer

- **Auth**: `options.BasicAuth`
- **Signature**: `DeleteCustomer(DeleteCustomerRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `void` (Task)
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DeleteCustomerRequest` | `src/Maxio/Requests/Customers/DeleteCustomerRequest.cs` |

### ListCustomerSubscriptions

- **Auth**: `options.BasicAuth`
- **Signature**: `ListCustomerSubscriptions(ListCustomerSubscriptionsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CustomerId`
- **Returns**: `IReadOnlyList<SubscriptionResponse>`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListCustomerSubscriptionsRequest` | `src/Maxio/Requests/Customers/ListCustomerSubscriptionsRequest.cs` |
| `SubscriptionResponse` | `src/Maxio/Models/SubscriptionResponse.cs` |

### ListCustomers

- **Auth**: `options.BasicAuth`
- **Signature**: `ListCustomers(ListCustomersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `direction` ← `Direction`, `page` ← `Page`, `per_page` ← `PerPage`, `date_field` ← `DateField`, `start_date` ← `StartDate`, `end_date` ← `EndDate`, `start_datetime` ← `StartDatetime`, `end_datetime` ← `EndDatetime`, `q` ← `Q`
- **Returns**: `IReadOnlyList<CustomerResponse>`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListCustomersRequest` | `src/Maxio/Requests/Customers/ListCustomersRequest.cs` |
| `SortingDirection` | `src/Maxio/Models/Enums/SortingDirection.cs` |
| `BasicDateField` | `src/Maxio/Models/Enums/BasicDateField.cs` |
| `CustomerResponse` | `src/Maxio/Models/CustomerResponse.cs` |

### ReadCustomer

- **Auth**: `options.BasicAuth`
- **Signature**: `ReadCustomer(ReadCustomerRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `CustomerResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ReadCustomerRequest` | `src/Maxio/Requests/Customers/ReadCustomerRequest.cs` |
| `CustomerResponse` | `src/Maxio/Models/CustomerResponse.cs` |

### ReadCustomerByReference

- **Auth**: `options.BasicAuth`
- **Signature**: `ReadCustomerByReference(ReadCustomerByReferenceRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Reference`
- **Query params (wire ← C#)**: `reference` ← `Reference`
- **Returns**: `CustomerResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ReadCustomerByReferenceRequest` | `src/Maxio/Requests/Customers/ReadCustomerByReferenceRequest.cs` |
| `CustomerResponse` | `src/Maxio/Models/CustomerResponse.cs` |

### UpdateCustomer

- **Auth**: `options.BasicAuth`
- **Signature**: `UpdateCustomer(UpdateCustomerOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `CustomerResponse`
- **Error**: `ApiException<UpdateCustomerError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404] · `TryGetCustomerErrorResponse1(out CustomerErrorResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdateCustomerOperationRequest` | `src/Maxio/Requests/Customers/UpdateCustomerOperationRequest.cs` |
| `UpdateCustomerRequest` | `src/Maxio/Models/UpdateCustomerRequest.cs` |
| `CustomerResponse` | `src/Maxio/Models/CustomerResponse.cs` |
| `UpdateCustomerError` | `src/Maxio/Errors/UpdateCustomerError.cs` |
| `CustomerErrorResponse1` | `src/Maxio/Models/CustomerErrorResponse1.cs` |

