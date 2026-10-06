<!-- Generated file — do not edit; regenerated with the SDK. -->

# ReferralCodes — operations

Accessor: `client.ReferralCodes` · Source: `Api/ReferralCodes.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### ValidateReferralCode

- **Auth**: `options.BasicAuth`
- **Signature**: `ValidateReferralCode(ValidateReferralCodeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Code`
- **Query params (wire ← C#)**: `code` ← `Code`
- **Returns**: `ReferralValidationResponse`
- **Error**: `ApiException<ValidateReferralCodeError>` — **Case A (typed)**
- **Error accessors**: `TryGetSingleStringErrorResponse1(out SingleStringErrorResponse1)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ValidateReferralCodeRequest` | `Requests/ReferralCodes/ValidateReferralCodeRequest.cs` |
| `ReferralValidationResponse` | `Models/ReferralValidationResponse.cs` |
| `ValidateReferralCodeError` | `Errors/ValidateReferralCodeError.cs` |
| `SingleStringErrorResponse1` | `Models/SingleStringErrorResponse1.cs` |

