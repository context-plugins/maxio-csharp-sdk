<!-- Generated file — do not edit; regenerated with the SDK. -->

# CustomFields — operations

Accessor: `client.CustomFields` · Source: `Api/CustomFields.cs` · 9 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateMetadata

- **Auth**: `options.BasicAuth`
- **Signature**: `CreateMetadata(CreateMetadataOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ResourceType`, `ResourceId`
- **Returns**: `IReadOnlyList<Metadata>`
- **Error**: `ApiException<CreateMetadataError>` — **Case A (typed)**
- **Error accessors**: `TryGetSingleErrorResponse1(out SingleErrorResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreateMetadataOperationRequest` | `Requests/CustomFields/CreateMetadataOperationRequest.cs` |
| `ResourceType` | `Models/Enums/ResourceType.cs` |
| `CreateMetadataRequest` | `Models/CreateMetadataRequest.cs` |
| `Metadata` | `Models/Metadata.cs` |
| `CreateMetadataError` | `Errors/CreateMetadataError.cs` |
| `SingleErrorResponse1` | `Models/SingleErrorResponse1.cs` |

### CreateMetafields

- **Auth**: `options.BasicAuth`
- **Signature**: `CreateMetafields(CreateMetafieldsOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ResourceType`
- **Returns**: `IReadOnlyList<Metafield>`
- **Error**: `ApiException<CreateMetafieldsError>` — **Case A (typed)**
- **Error accessors**: `TryGetSingleErrorResponse1(out SingleErrorResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreateMetafieldsOperationRequest` | `Requests/CustomFields/CreateMetafieldsOperationRequest.cs` |
| `ResourceType` | `Models/Enums/ResourceType.cs` |
| `CreateMetafieldsRequest` | `Models/CreateMetafieldsRequest.cs` |
| `Metafield` | `Models/Metafield.cs` |
| `CreateMetafieldsError` | `Errors/CreateMetafieldsError.cs` |
| `SingleErrorResponse1` | `Models/SingleErrorResponse1.cs` |

### DeleteMetadata

- **Auth**: `options.BasicAuth`
- **Signature**: `DeleteMetadata(DeleteMetadataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ResourceType`, `ResourceId`
- **Query params (wire ← C#)**: `name` ← `Name`, `names` ← `Names`
- **Returns**: `void` (Task)
- **Error**: `ApiException<DeleteMetadataError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteMetadataRequest` | `Requests/CustomFields/DeleteMetadataRequest.cs` |
| `ResourceType` | `Models/Enums/ResourceType.cs` |
| `DeleteMetadataError` | `Errors/DeleteMetadataError.cs` |

### DeleteMetafield

- **Auth**: `options.BasicAuth`
- **Signature**: `DeleteMetafield(DeleteMetafieldRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ResourceType`
- **Query params (wire ← C#)**: `name` ← `Name`
- **Returns**: `void` (Task)
- **Error**: `ApiException<DeleteMetafieldError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteMetafieldRequest` | `Requests/CustomFields/DeleteMetafieldRequest.cs` |
| `ResourceType` | `Models/Enums/ResourceType.cs` |
| `DeleteMetafieldError` | `Errors/DeleteMetafieldError.cs` |

### ListMetadata

- **Auth**: `options.BasicAuth`
- **Signature**: `ListMetadata(ListMetadataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ResourceType`, `ResourceId`
- **Query params (wire ← C#)**: `page` ← `Page`, `per_page` ← `PerPage`
- **Returns**: `PaginatedMetadata`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListMetadataRequest` | `Requests/CustomFields/ListMetadataRequest.cs` |
| `ResourceType` | `Models/Enums/ResourceType.cs` |
| `PaginatedMetadata` | `Models/PaginatedMetadata.cs` |

### ListMetadataForResourceType

- **Auth**: `options.BasicAuth`
- **Signature**: `ListMetadataForResourceType(ListMetadataForResourceTypeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ResourceType`
- **Query params (wire ← C#)**: `page` ← `Page`, `per_page` ← `PerPage`, `date_field` ← `DateField`, `start_date` ← `StartDate`, `end_date` ← `EndDate`, `start_datetime` ← `StartDatetime`, `end_datetime` ← `EndDatetime`, `with_deleted` ← `WithDeleted`, `resource_ids` ← `ResourceIds`, `direction` ← `Direction`
- **Returns**: `PaginatedMetadata`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListMetadataForResourceTypeRequest` | `Requests/CustomFields/ListMetadataForResourceTypeRequest.cs` |
| `ResourceType` | `Models/Enums/ResourceType.cs` |
| `BasicDateField` | `Models/Enums/BasicDateField.cs` |
| `SortingDirection` | `Models/Enums/SortingDirection.cs` |
| `PaginatedMetadata` | `Models/PaginatedMetadata.cs` |

### ListMetafields

- **Auth**: `options.BasicAuth`
- **Signature**: `ListMetafields(ListMetafieldsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ResourceType`
- **Query params (wire ← C#)**: `name` ← `Name`, `page` ← `Page`, `per_page` ← `PerPage`, `direction` ← `Direction`
- **Returns**: `ListMetafieldsResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListMetafieldsRequest` | `Requests/CustomFields/ListMetafieldsRequest.cs` |
| `ResourceType` | `Models/Enums/ResourceType.cs` |
| `SortingDirection` | `Models/Enums/SortingDirection.cs` |
| `ListMetafieldsResponse` | `Models/ListMetafieldsResponse.cs` |

### UpdateMetadata

- **Auth**: `options.BasicAuth`
- **Signature**: `UpdateMetadata(UpdateMetadataOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ResourceType`, `ResourceId`
- **Returns**: `IReadOnlyList<Metadata>`
- **Error**: `ApiException<UpdateMetadataError>` — **Case A (typed)**
- **Error accessors**: `TryGetSingleErrorResponse1(out SingleErrorResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdateMetadataOperationRequest` | `Requests/CustomFields/UpdateMetadataOperationRequest.cs` |
| `ResourceType` | `Models/Enums/ResourceType.cs` |
| `UpdateMetadataRequest` | `Models/UpdateMetadataRequest.cs` |
| `Metadata` | `Models/Metadata.cs` |
| `UpdateMetadataError` | `Errors/UpdateMetadataError.cs` |
| `SingleErrorResponse1` | `Models/SingleErrorResponse1.cs` |

### UpdateMetafield

- **Auth**: `options.BasicAuth`
- **Signature**: `UpdateMetafield(UpdateMetafieldRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ResourceType`
- **Returns**: `IReadOnlyList<Metafield>`
- **Error**: `ApiException<UpdateMetafieldError>` — **Case A (typed)**
- **Error accessors**: `TryGetSingleErrorResponse1(out SingleErrorResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdateMetafieldRequest` | `Requests/CustomFields/UpdateMetafieldRequest.cs` |
| `ResourceType` | `Models/Enums/ResourceType.cs` |
| `UpdateMetafieldsRequest` | `Models/UpdateMetafieldsRequest.cs` |
| `Metafield` | `Models/Metafield.cs` |
| `UpdateMetafieldError` | `Errors/UpdateMetafieldError.cs` |
| `SingleErrorResponse1` | `Models/SingleErrorResponse1.cs` |

