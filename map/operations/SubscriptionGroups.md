<!-- Generated file — do not edit; regenerated with the SDK. -->

# SubscriptionGroups — operations

Accessor: `client.SubscriptionGroups` · Source: `Api/SubscriptionGroups.cs` · 9 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AddSubscriptionToGroup

- **Auth**: `options.BasicAuth`
- **Signature**: `AddSubscriptionToGroup(AddSubscriptionToGroupRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`
- **Returns**: `SubscriptionGroupResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AddSubscriptionToGroupRequest` | `Requests/SubscriptionGroups/AddSubscriptionToGroupRequest.cs` |
| `AddSubscriptionToAGroup` | `Models/AddSubscriptionToAGroup.cs` |
| `SubscriptionGroupResponse` | `Models/SubscriptionGroupResponse.cs` |

### CreateSubscriptionGroup

- **Auth**: `options.BasicAuth`
- **Signature**: `CreateSubscriptionGroup(CreateSubscriptionGroupOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `SubscriptionGroupResponse`
- **Error**: `ApiException<CreateSubscriptionGroupError>` — **Case A (typed)**
- **Error accessors**: `TryGetSubscriptionGroupCreateErrorResponse1(out SubscriptionGroupCreateErrorResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreateSubscriptionGroupOperationRequest` | `Requests/SubscriptionGroups/CreateSubscriptionGroupOperationRequest.cs` |
| `CreateSubscriptionGroupRequest` | `Models/CreateSubscriptionGroupRequest.cs` |
| `SubscriptionGroupResponse` | `Models/SubscriptionGroupResponse.cs` |
| `CreateSubscriptionGroupError` | `Errors/CreateSubscriptionGroupError.cs` |
| `SubscriptionGroupCreateErrorResponse1` | `Models/SubscriptionGroupCreateErrorResponse1.cs` |

### DeleteSubscriptionGroup

- **Auth**: `options.BasicAuth`
- **Signature**: `DeleteSubscriptionGroup(DeleteSubscriptionGroupRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Uid`
- **Returns**: `DeleteSubscriptionGroupResponse`
- **Error**: `ApiException<DeleteSubscriptionGroupError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteSubscriptionGroupRequest` | `Requests/SubscriptionGroups/DeleteSubscriptionGroupRequest.cs` |
| `DeleteSubscriptionGroupResponse` | `Models/DeleteSubscriptionGroupResponse.cs` |
| `DeleteSubscriptionGroupError` | `Errors/DeleteSubscriptionGroupError.cs` |

### FindSubscriptionGroup

- **Auth**: `options.BasicAuth`
- **Signature**: `FindSubscriptionGroup(FindSubscriptionGroupRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`
- **Query params (wire ← C#)**: `subscription_id` ← `SubscriptionId`
- **Returns**: `FullSubscriptionGroupResponse`
- **Error**: `ApiException<FindSubscriptionGroupError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `FindSubscriptionGroupRequest` | `Requests/SubscriptionGroups/FindSubscriptionGroupRequest.cs` |
| `FullSubscriptionGroupResponse` | `Models/FullSubscriptionGroupResponse.cs` |
| `FindSubscriptionGroupError` | `Errors/FindSubscriptionGroupError.cs` |

### ListSubscriptionGroups

- **Auth**: `options.BasicAuth`
- **Signature**: `ListSubscriptionGroups(ListSubscriptionGroupsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page` ← `Page`, `per_page` ← `PerPage`, `include` ← `Include`
- **Returns**: `ListSubscriptionGroupsResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListSubscriptionGroupsRequest` | `Requests/SubscriptionGroups/ListSubscriptionGroupsRequest.cs` |
| `SubscriptionGroupsListInclude` | `Models/Enums/SubscriptionGroupsListInclude.cs` |
| `ListSubscriptionGroupsResponse` | `Models/ListSubscriptionGroupsResponse.cs` |

### ReadSubscriptionGroup

- **Auth**: `options.BasicAuth`
- **Signature**: `ReadSubscriptionGroup(ReadSubscriptionGroupRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Uid`
- **Query params (wire ← C#)**: `include` ← `Include`
- **Returns**: `FullSubscriptionGroupResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ReadSubscriptionGroupRequest` | `Requests/SubscriptionGroups/ReadSubscriptionGroupRequest.cs` |
| `SubscriptionGroupInclude` | `Models/Enums/SubscriptionGroupInclude.cs` |
| `FullSubscriptionGroupResponse` | `Models/FullSubscriptionGroupResponse.cs` |

### RemoveSubscriptionFromGroup

- **Auth**: `options.BasicAuth`
- **Signature**: `RemoveSubscriptionFromGroup(RemoveSubscriptionFromGroupRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`
- **Returns**: `void` (Task)
- **Error**: `ApiException<RemoveSubscriptionFromGroupError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404] · `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `RemoveSubscriptionFromGroupRequest` | `Requests/SubscriptionGroups/RemoveSubscriptionFromGroupRequest.cs` |
| `RemoveSubscriptionFromGroupError` | `Errors/RemoveSubscriptionFromGroupError.cs` |
| `ErrorListResponse1` | `Models/ErrorListResponse1.cs` |

### SignupWithSubscriptionGroup

- **Auth**: `options.BasicAuth`
- **Signature**: `SignupWithSubscriptionGroup(SignupWithSubscriptionGroupRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `SubscriptionGroupSignupResponse`
- **Error**: `ApiException<SignupWithSubscriptionGroupError>` — **Case A (typed)**
- **Error accessors**: `TryGetSubscriptionGroupSignupErrorResponse1(out SubscriptionGroupSignupErrorResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SignupWithSubscriptionGroupRequest` | `Requests/SubscriptionGroups/SignupWithSubscriptionGroupRequest.cs` |
| `SubscriptionGroupSignupRequest` | `Models/SubscriptionGroupSignupRequest.cs` |
| `SubscriptionGroupSignupResponse` | `Models/SubscriptionGroupSignupResponse.cs` |
| `SignupWithSubscriptionGroupError` | `Errors/SignupWithSubscriptionGroupError.cs` |
| `SubscriptionGroupSignupErrorResponse1` | `Models/SubscriptionGroupSignupErrorResponse1.cs` |

### UpdateSubscriptionGroupMembers

- **Auth**: `options.BasicAuth`
- **Signature**: `UpdateSubscriptionGroupMembers(UpdateSubscriptionGroupMembersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Uid`
- **Returns**: `SubscriptionGroupResponse`
- **Error**: `ApiException<UpdateSubscriptionGroupMembersError>` — **Case A (typed)**
- **Error accessors**: `TryGetSubscriptionGroupUpdateErrorResponse1(out SubscriptionGroupUpdateErrorResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdateSubscriptionGroupMembersRequest` | `Requests/SubscriptionGroups/UpdateSubscriptionGroupMembersRequest.cs` |
| `UpdateSubscriptionGroupRequest` | `Models/UpdateSubscriptionGroupRequest.cs` |
| `SubscriptionGroupResponse` | `Models/SubscriptionGroupResponse.cs` |
| `UpdateSubscriptionGroupMembersError` | `Errors/UpdateSubscriptionGroupMembersError.cs` |
| `SubscriptionGroupUpdateErrorResponse1` | `Models/SubscriptionGroupUpdateErrorResponse1.cs` |

