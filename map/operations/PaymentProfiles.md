<!-- Generated file — do not edit; regenerated with the SDK. -->

# PaymentProfiles — operations

Accessor: `client.PaymentProfiles` · Source: `Api/PaymentProfiles.cs` · 12 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### ChangeSubscriptionDefaultPaymentProfile

- **Auth**: `options.BasicAuth`
- **Signature**: `ChangeSubscriptionDefaultPaymentProfile(ChangeSubscriptionDefaultPaymentProfileRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`, `PaymentProfileId`
- **Returns**: `PaymentProfileResponse`
- **Error**: `ApiException<ChangeSubscriptionDefaultPaymentProfileError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404] · `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ChangeSubscriptionDefaultPaymentProfileRequest` | `Requests/PaymentProfiles/ChangeSubscriptionDefaultPaymentProfileRequest.cs` |
| `PaymentProfileResponse` | `Models/PaymentProfileResponse.cs` |
| `ChangeSubscriptionDefaultPaymentProfileError` | `Errors/ChangeSubscriptionDefaultPaymentProfileError.cs` |
| `ErrorListResponse1` | `Models/ErrorListResponse1.cs` |

### ChangeSubscriptionGroupDefaultPaymentProfile

- **Auth**: `options.BasicAuth`
- **Signature**: `ChangeSubscriptionGroupDefaultPaymentProfile(ChangeSubscriptionGroupDefaultPaymentProfileRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Uid`, `PaymentProfileId`
- **Returns**: `PaymentProfileResponse`
- **Error**: `ApiException<ChangeSubscriptionGroupDefaultPaymentProfileError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ChangeSubscriptionGroupDefaultPaymentProfileRequest` | `Requests/PaymentProfiles/ChangeSubscriptionGroupDefaultPaymentProfileRequest.cs` |
| `PaymentProfileResponse` | `Models/PaymentProfileResponse.cs` |
| `ChangeSubscriptionGroupDefaultPaymentProfileError` | `Errors/ChangeSubscriptionGroupDefaultPaymentProfileError.cs` |
| `ErrorListResponse1` | `Models/ErrorListResponse1.cs` |

### CreatePaymentProfile

- **Auth**: `options.BasicAuth`
- **Signature**: `CreatePaymentProfile(CreatePaymentProfileOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `PaymentProfileResponse`
- **Error**: `ApiException<CreatePaymentProfileError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404] · `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreatePaymentProfileOperationRequest` | `Requests/PaymentProfiles/CreatePaymentProfileOperationRequest.cs` |
| `CreatePaymentProfileRequest` | `Models/CreatePaymentProfileRequest.cs` |
| `PaymentProfileResponse` | `Models/PaymentProfileResponse.cs` |
| `CreatePaymentProfileError` | `Errors/CreatePaymentProfileError.cs` |
| `ErrorListResponse1` | `Models/ErrorListResponse1.cs` |

### DeleteSubscriptionGroupPaymentProfile

- **Auth**: `options.BasicAuth`
- **Signature**: `DeleteSubscriptionGroupPaymentProfile(DeleteSubscriptionGroupPaymentProfileRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Uid`, `PaymentProfileId`
- **Returns**: `void` (Task)
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DeleteSubscriptionGroupPaymentProfileRequest` | `Requests/PaymentProfiles/DeleteSubscriptionGroupPaymentProfileRequest.cs` |

### DeleteSubscriptionsPaymentProfile

- **Auth**: `options.BasicAuth`
- **Signature**: `DeleteSubscriptionsPaymentProfile(DeleteSubscriptionsPaymentProfileRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`, `PaymentProfileId`
- **Returns**: `void` (Task)
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DeleteSubscriptionsPaymentProfileRequest` | `Requests/PaymentProfiles/DeleteSubscriptionsPaymentProfileRequest.cs` |

### DeleteUnusedPaymentProfile

- **Auth**: `options.BasicAuth`
- **Signature**: `DeleteUnusedPaymentProfile(DeleteUnusedPaymentProfileRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `PaymentProfileId`
- **Returns**: `void` (Task)
- **Error**: `ApiException<DeleteUnusedPaymentProfileError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404] · `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteUnusedPaymentProfileRequest` | `Requests/PaymentProfiles/DeleteUnusedPaymentProfileRequest.cs` |
| `DeleteUnusedPaymentProfileError` | `Errors/DeleteUnusedPaymentProfileError.cs` |
| `ErrorListResponse1` | `Models/ErrorListResponse1.cs` |

### ListPaymentProfiles

- **Auth**: `options.BasicAuth`
- **Signature**: `ListPaymentProfiles(ListPaymentProfilesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page` ← `Page`, `per_page` ← `PerPage`, `customer_id` ← `CustomerId`
- **Returns**: `IReadOnlyList<PaymentProfileResponse>`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListPaymentProfilesRequest` | `Requests/PaymentProfiles/ListPaymentProfilesRequest.cs` |
| `PaymentProfileResponse` | `Models/PaymentProfileResponse.cs` |

### ReadOneTimeToken

- **Auth**: `options.BasicAuth`
- **Signature**: `ReadOneTimeToken(ReadOneTimeTokenRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ChargifyToken`
- **Returns**: `GetOneTimeTokenRequest`
- **Error**: `ApiException<ReadOneTimeTokenError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ReadOneTimeTokenRequest` | `Requests/PaymentProfiles/ReadOneTimeTokenRequest.cs` |
| `GetOneTimeTokenRequest` | `Models/GetOneTimeTokenRequest.cs` |
| `ReadOneTimeTokenError` | `Errors/ReadOneTimeTokenError.cs` |
| `ErrorListResponse1` | `Models/ErrorListResponse1.cs` |

### ReadPaymentProfile

- **Auth**: `options.BasicAuth`
- **Signature**: `ReadPaymentProfile(ReadPaymentProfileRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `PaymentProfileId`
- **Returns**: `PaymentProfileResponse`
- **Error**: `ApiException<ReadPaymentProfileError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ReadPaymentProfileRequest` | `Requests/PaymentProfiles/ReadPaymentProfileRequest.cs` |
| `PaymentProfileResponse` | `Models/PaymentProfileResponse.cs` |
| `ReadPaymentProfileError` | `Errors/ReadPaymentProfileError.cs` |

### SendRequestUpdatePaymentEmail

- **Auth**: `options.BasicAuth`
- **Signature**: `SendRequestUpdatePaymentEmail(SendRequestUpdatePaymentEmailRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`
- **Returns**: `void` (Task)
- **Error**: `ApiException<SendRequestUpdatePaymentEmailError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404] · `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SendRequestUpdatePaymentEmailRequest` | `Requests/PaymentProfiles/SendRequestUpdatePaymentEmailRequest.cs` |
| `SendRequestUpdatePaymentEmailError` | `Errors/SendRequestUpdatePaymentEmailError.cs` |
| `ErrorListResponse1` | `Models/ErrorListResponse1.cs` |

### UpdatePaymentProfile

- **Auth**: `options.BasicAuth`
- **Signature**: `UpdatePaymentProfile(UpdatePaymentProfileOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `PaymentProfileId`
- **Returns**: `PaymentProfileResponse`
- **Error**: `ApiException<UpdatePaymentProfileError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404] · `TryGetErrorStringMapResponse1(out ErrorStringMapResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdatePaymentProfileOperationRequest` | `Requests/PaymentProfiles/UpdatePaymentProfileOperationRequest.cs` |
| `UpdatePaymentProfileRequest` | `Models/UpdatePaymentProfileRequest.cs` |
| `PaymentProfileResponse` | `Models/PaymentProfileResponse.cs` |
| `UpdatePaymentProfileError` | `Errors/UpdatePaymentProfileError.cs` |
| `ErrorStringMapResponse1` | `Models/ErrorStringMapResponse1.cs` |

### VerifyBankAccount

- **Auth**: `options.BasicAuth`
- **Signature**: `VerifyBankAccount(VerifyBankAccountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `BankAccountId`
- **Returns**: `BankAccountResponse`
- **Error**: `ApiException<VerifyBankAccountError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404] · `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `VerifyBankAccountRequest` | `Requests/PaymentProfiles/VerifyBankAccountRequest.cs` |
| `BankAccountVerificationRequest` | `Models/BankAccountVerificationRequest.cs` |
| `BankAccountResponse` | `Models/BankAccountResponse.cs` |
| `VerifyBankAccountError` | `Errors/VerifyBankAccountError.cs` |
| `ErrorListResponse1` | `Models/ErrorListResponse1.cs` |

