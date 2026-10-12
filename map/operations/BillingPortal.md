<!-- Generated file — do not edit; regenerated with the SDK. -->

# BillingPortal — operations

Accessor: `client.BillingPortal` · Source: `src/Maxio/Api/BillingPortal.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### EnableBillingPortalForCustomer

- **Auth**: `options.BasicAuth`
- **Signature**: `EnableBillingPortalForCustomer(EnableBillingPortalForCustomerRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CustomerId`
- **Query params (wire ← C#)**: `auto_invite` ← `AutoInvite`
- **Returns**: `CustomerResponse`
- **Error**: `ApiException<EnableBillingPortalForCustomerError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `EnableBillingPortalForCustomerRequest` | `src/Maxio/Requests/BillingPortal/EnableBillingPortalForCustomerRequest.cs` |
| `AutoInvite` | `src/Maxio/Models/Enums/AutoInvite.cs` |
| `CustomerResponse` | `src/Maxio/Models/CustomerResponse.cs` |
| `EnableBillingPortalForCustomerError` | `src/Maxio/Errors/EnableBillingPortalForCustomerError.cs` |
| `ErrorListResponse1` | `src/Maxio/Models/ErrorListResponse1.cs` |

### ReadBillingPortalLink

- **Auth**: `options.BasicAuth`
- **Signature**: `ReadBillingPortalLink(ReadBillingPortalLinkRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CustomerId`
- **Returns**: `PortalManagementLink`
- **Error**: `ApiException<ReadBillingPortalLinkError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetTooManyManagementLinkRequestsError1(out TooManyManagementLinkRequestsError1)` [429] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ReadBillingPortalLinkRequest` | `src/Maxio/Requests/BillingPortal/ReadBillingPortalLinkRequest.cs` |
| `PortalManagementLink` | `src/Maxio/Models/PortalManagementLink.cs` |
| `ReadBillingPortalLinkError` | `src/Maxio/Errors/ReadBillingPortalLinkError.cs` |
| `ErrorListResponse1` | `src/Maxio/Models/ErrorListResponse1.cs` |
| `TooManyManagementLinkRequestsError1` | `src/Maxio/Models/TooManyManagementLinkRequestsError1.cs` |

### ResendBillingPortalInvitation

- **Auth**: `options.BasicAuth`
- **Signature**: `ResendBillingPortalInvitation(ResendBillingPortalInvitationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CustomerId`
- **Returns**: `ResentInvitation`
- **Error**: `ApiException<ResendBillingPortalInvitationError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404] · `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ResendBillingPortalInvitationRequest` | `src/Maxio/Requests/BillingPortal/ResendBillingPortalInvitationRequest.cs` |
| `ResentInvitation` | `src/Maxio/Models/ResentInvitation.cs` |
| `ResendBillingPortalInvitationError` | `src/Maxio/Errors/ResendBillingPortalInvitationError.cs` |
| `ErrorListResponse1` | `src/Maxio/Models/ErrorListResponse1.cs` |

### RevokeBillingPortalAccess

- **Auth**: `options.BasicAuth`
- **Signature**: `RevokeBillingPortalAccess(RevokeBillingPortalAccessRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CustomerId`
- **Returns**: `RevokedInvitation`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RevokeBillingPortalAccessRequest` | `src/Maxio/Requests/BillingPortal/RevokeBillingPortalAccessRequest.cs` |
| `RevokedInvitation` | `src/Maxio/Models/RevokedInvitation.cs` |

