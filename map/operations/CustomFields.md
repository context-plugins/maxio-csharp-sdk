<!-- Generated file — do not edit; regenerated with the SDK. -->

# CustomFields — operations

Accessor: `client.CustomFields` · Source: `src/Maxio/Api/CustomFields.cs` · 9 operations

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
| `CreateMetadataOperationRequest` | `src/Maxio/Requests/CustomFields/CreateMetadataOperationRequest.cs` |
| `ResourceType` | `src/Maxio/Models/Enums/ResourceType.cs` |
| `CreateMetadataRequest` | `src/Maxio/Models/CreateMetadataRequest.cs` |
| `Metadata` | `src/Maxio/Models/Metadata.cs` |
| `CreateMetadataError` | `src/Maxio/Errors/CreateMetadataError.cs` |
| `SingleErrorResponse1` | `src/Maxio/Models/SingleErrorResponse1.cs` |

### CreateMetafields

- **Auth**: `options.BasicAuth`
- **Signature**: `CreateMetafields(CreateMetafieldsOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ResourceType`
- **Returns**: `IReadOnlyList<Metafield>`
- **Error**: `ApiException<CreateMetafieldsError>` — **Case A (typed)**
- **Error accessors**: `TryGetSingleErrorResponse1(out SingleErrorResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreateMetafieldsOperationRequest` | `src/Maxio/Requests/CustomFields/CreateMetafieldsOperationRequest.cs` |
| `ResourceType` | `src/Maxio/Models/Enums/ResourceType.cs` |
| `CreateMetafieldsRequest` | `src/Maxio/Models/CreateMetafieldsRequest.cs` |
| `Metafield` | `src/Maxio/Models/Metafield.cs` |
| `CreateMetafieldsError` | `src/Maxio/Errors/CreateMetafieldsError.cs` |
| `SingleErrorResponse1` | `src/Maxio/Models/SingleErrorResponse1.cs` |

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
| `DeleteMetadataRequest` | `src/Maxio/Requests/CustomFields/DeleteMetadataRequest.cs` |
| `ResourceType` | `src/Maxio/Models/Enums/ResourceType.cs` |
| `DeleteMetadataError` | `src/Maxio/Errors/DeleteMetadataError.cs` |

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
| `DeleteMetafieldRequest` | `src/Maxio/Requests/CustomFields/DeleteMetafieldRequest.cs` |
| `ResourceType` | `src/Maxio/Models/Enums/ResourceType.cs` |
| `DeleteMetafieldError` | `src/Maxio/Errors/DeleteMetafieldError.cs` |

### ListMetadata

- **Auth**: `options.BasicAuth`
- **Signature**: `ListMetadata(ListMetadataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ResourceType`, `ResourceId`
- **Query params (wire ← C#)**: `page` ← `Page`, `per_page` ← `PerPage`
- **Returns**: `PaginatedMetadata`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListMetadataRequest` | `src/Maxio/Requests/CustomFields/ListMetadataRequest.cs` |
| `ResourceType` | `src/Maxio/Models/Enums/ResourceType.cs` |
| `PaginatedMetadata` | `src/Maxio/Models/PaginatedMetadata.cs` |

### ListMetadataForResourceType

- **Auth**: `options.BasicAuth`
- **Signature**: `ListMetadataForResourceType(ListMetadataForResourceTypeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ResourceType`
- **Query params (wire ← C#)**: `page` ← `Page`, `per_page` ← `PerPage`, `date_field` ← `DateField`, `start_date` ← `StartDate`, `end_date` ← `EndDate`, `start_datetime` ← `StartDatetime`, `end_datetime` ← `EndDatetime`, `with_deleted` ← `WithDeleted`, `resource_ids` ← `ResourceIds`, `direction` ← `Direction`
- **Returns**: `PaginatedMetadata`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListMetadataForResourceTypeRequest` | `src/Maxio/Requests/CustomFields/ListMetadataForResourceTypeRequest.cs` |
| `ResourceType` | `src/Maxio/Models/Enums/ResourceType.cs` |
| `BasicDateField` | `src/Maxio/Models/Enums/BasicDateField.cs` |
| `SortingDirection` | `src/Maxio/Models/Enums/SortingDirection.cs` |
| `PaginatedMetadata` | `src/Maxio/Models/PaginatedMetadata.cs` |

### ListMetafields

- **Auth**: `options.BasicAuth`
- **Signature**: `ListMetafields(ListMetafieldsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ResourceType`
- **Query params (wire ← C#)**: `name` ← `Name`, `page` ← `Page`, `per_page` ← `PerPage`, `direction` ← `Direction`
- **Returns**: `ListMetafieldsResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListMetafieldsRequest` | `src/Maxio/Requests/CustomFields/ListMetafieldsRequest.cs` |
| `ResourceType` | `src/Maxio/Models/Enums/ResourceType.cs` |
| `SortingDirection` | `src/Maxio/Models/Enums/SortingDirection.cs` |
| `ListMetafieldsResponse` | `src/Maxio/Models/ListMetafieldsResponse.cs` |

### UpdateMetadata

- **Auth**: `options.BasicAuth`
- **Signature**: `UpdateMetadata(UpdateMetadataOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ResourceType`, `ResourceId`
- **Returns**: `IReadOnlyList<Metadata>`
- **Error**: `ApiException<UpdateMetadataError>` — **Case A (typed)**
- **Error accessors**: `TryGetSingleErrorResponse1(out SingleErrorResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdateMetadataOperationRequest` | `src/Maxio/Requests/CustomFields/UpdateMetadataOperationRequest.cs` |
| `ResourceType` | `src/Maxio/Models/Enums/ResourceType.cs` |
| `UpdateMetadataRequest` | `src/Maxio/Models/UpdateMetadataRequest.cs` |
| `Metadata` | `src/Maxio/Models/Metadata.cs` |
| `UpdateMetadataError` | `src/Maxio/Errors/UpdateMetadataError.cs` |
| `SingleErrorResponse1` | `src/Maxio/Models/SingleErrorResponse1.cs` |

### UpdateMetafield

- **Auth**: `options.BasicAuth`
- **Signature**: `UpdateMetafield(UpdateMetafieldRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ResourceType`
- **Returns**: `IReadOnlyList<Metafield>`
- **Error**: `ApiException<UpdateMetafieldError>` — **Case A (typed)**
- **Error accessors**: `TryGetSingleErrorResponse1(out SingleErrorResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdateMetafieldRequest` | `src/Maxio/Requests/CustomFields/UpdateMetafieldRequest.cs` |
| `ResourceType` | `src/Maxio/Models/Enums/ResourceType.cs` |
| `UpdateMetafieldsRequest` | `src/Maxio/Models/UpdateMetafieldsRequest.cs` |
| `Metafield` | `src/Maxio/Models/Metafield.cs` |
| `UpdateMetafieldError` | `src/Maxio/Errors/UpdateMetafieldError.cs` |
| `SingleErrorResponse1` | `src/Maxio/Models/SingleErrorResponse1.cs` |

