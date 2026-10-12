<!-- Generated file — do not edit; regenerated with the SDK. -->

# Components — operations

Accessor: `client.Components` · Source: `src/Maxio/Api/Components.cs` · 12 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### ArchiveComponent

- **Auth**: `options.BasicAuth`
- **Signature**: `ArchiveComponent(ArchiveComponentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProductFamilyId`, `ComponentId`
- **Returns**: `Component`
- **Error**: `ApiException<ArchiveComponentError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ArchiveComponentRequest` | `src/Maxio/Requests/Components/ArchiveComponentRequest.cs` |
| `Component` | `src/Maxio/Models/Component.cs` |
| `ArchiveComponentError` | `src/Maxio/Errors/ArchiveComponentError.cs` |
| `ErrorListResponse1` | `src/Maxio/Models/ErrorListResponse1.cs` |

### CreateEventBasedComponent

- **Auth**: `options.BasicAuth`
- **Signature**: `CreateEventBasedComponent(CreateEventBasedComponentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProductFamilyId`
- **Returns**: `ComponentResponse`
- **Error**: `ApiException<CreateEventBasedComponentError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404] · `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreateEventBasedComponentRequest` | `src/Maxio/Requests/Components/CreateEventBasedComponentRequest.cs` |
| `CreateEbbComponent` | `src/Maxio/Models/CreateEbbComponent.cs` |
| `ComponentResponse` | `src/Maxio/Models/ComponentResponse.cs` |
| `CreateEventBasedComponentError` | `src/Maxio/Errors/CreateEventBasedComponentError.cs` |
| `ErrorListResponse1` | `src/Maxio/Models/ErrorListResponse1.cs` |

### CreateMeteredComponent

- **Auth**: `options.BasicAuth`
- **Signature**: `CreateMeteredComponent(CreateMeteredComponentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProductFamilyId`
- **Returns**: `ComponentResponse`
- **Error**: `ApiException<CreateMeteredComponentError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404] · `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreateMeteredComponentRequest` | `src/Maxio/Requests/Components/CreateMeteredComponentRequest.cs` |
| `CreateMeteredComponent` | `src/Maxio/Models/CreateMeteredComponent.cs` |
| `ComponentResponse` | `src/Maxio/Models/ComponentResponse.cs` |
| `CreateMeteredComponentError` | `src/Maxio/Errors/CreateMeteredComponentError.cs` |
| `ErrorListResponse1` | `src/Maxio/Models/ErrorListResponse1.cs` |

### CreateOnOffComponent

- **Auth**: `options.BasicAuth`
- **Signature**: `CreateOnOffComponent(CreateOnOffComponentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProductFamilyId`
- **Returns**: `ComponentResponse`
- **Error**: `ApiException<CreateOnOffComponentError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404] · `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreateOnOffComponentRequest` | `src/Maxio/Requests/Components/CreateOnOffComponentRequest.cs` |
| `CreateOnOffComponent` | `src/Maxio/Models/CreateOnOffComponent.cs` |
| `ComponentResponse` | `src/Maxio/Models/ComponentResponse.cs` |
| `CreateOnOffComponentError` | `src/Maxio/Errors/CreateOnOffComponentError.cs` |
| `ErrorListResponse1` | `src/Maxio/Models/ErrorListResponse1.cs` |

### CreatePrepaidUsageComponent

- **Auth**: `options.BasicAuth`
- **Signature**: `CreatePrepaidUsageComponent(CreatePrepaidUsageComponentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProductFamilyId`
- **Returns**: `ComponentResponse`
- **Error**: `ApiException<CreatePrepaidUsageComponentError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404] · `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreatePrepaidUsageComponentRequest` | `src/Maxio/Requests/Components/CreatePrepaidUsageComponentRequest.cs` |
| `CreatePrepaidComponent` | `src/Maxio/Models/CreatePrepaidComponent.cs` |
| `ComponentResponse` | `src/Maxio/Models/ComponentResponse.cs` |
| `CreatePrepaidUsageComponentError` | `src/Maxio/Errors/CreatePrepaidUsageComponentError.cs` |
| `ErrorListResponse1` | `src/Maxio/Models/ErrorListResponse1.cs` |

### CreateQuantityBasedComponent

- **Auth**: `options.BasicAuth`
- **Signature**: `CreateQuantityBasedComponent(CreateQuantityBasedComponentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProductFamilyId`
- **Returns**: `ComponentResponse`
- **Error**: `ApiException<CreateQuantityBasedComponentError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404] · `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreateQuantityBasedComponentRequest` | `src/Maxio/Requests/Components/CreateQuantityBasedComponentRequest.cs` |
| `CreateQuantityBasedComponent` | `src/Maxio/Models/CreateQuantityBasedComponent.cs` |
| `ComponentResponse` | `src/Maxio/Models/ComponentResponse.cs` |
| `CreateQuantityBasedComponentError` | `src/Maxio/Errors/CreateQuantityBasedComponentError.cs` |
| `ErrorListResponse1` | `src/Maxio/Models/ErrorListResponse1.cs` |

### FindComponent

- **Auth**: `options.BasicAuth`
- **Signature**: `FindComponent(FindComponentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Handle`
- **Query params (wire ← C#)**: `handle` ← `Handle`
- **Returns**: `ComponentResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `FindComponentRequest` | `src/Maxio/Requests/Components/FindComponentRequest.cs` |
| `ComponentResponse` | `src/Maxio/Models/ComponentResponse.cs` |

### ListComponents

- **Auth**: `options.BasicAuth`
- **Signature**: `ListComponents(ListComponentsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `date_field` ← `DateField`, `start_date` ← `StartDate`, `end_date` ← `EndDate`, `start_datetime` ← `StartDatetime`, `end_datetime` ← `EndDatetime`, `include_archived` ← `IncludeArchived`, `page` ← `Page`, `per_page` ← `PerPage`, `filter` ← `Filter`
- **Returns**: `IReadOnlyList<ComponentResponse>`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListComponentsRequest` | `src/Maxio/Requests/Components/ListComponentsRequest.cs` |
| `BasicDateField` | `src/Maxio/Models/Enums/BasicDateField.cs` |
| `ListComponentsFilter` | `src/Maxio/Models/ListComponentsFilter.cs` |
| `ComponentResponse` | `src/Maxio/Models/ComponentResponse.cs` |

### ListComponentsForProductFamily

- **Auth**: `options.BasicAuth`
- **Signature**: `ListComponentsForProductFamily(ListComponentsForProductFamilyRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProductFamilyId`
- **Query params (wire ← C#)**: `include_archived` ← `IncludeArchived`, `page` ← `Page`, `per_page` ← `PerPage`, `filter` ← `Filter`, `date_field` ← `DateField`, `end_date` ← `EndDate`, `end_datetime` ← `EndDatetime`, `start_date` ← `StartDate`, `start_datetime` ← `StartDatetime`
- **Returns**: `IReadOnlyList<ComponentResponse>`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListComponentsForProductFamilyRequest` | `src/Maxio/Requests/Components/ListComponentsForProductFamilyRequest.cs` |
| `ListComponentsFilter` | `src/Maxio/Models/ListComponentsFilter.cs` |
| `BasicDateField` | `src/Maxio/Models/Enums/BasicDateField.cs` |
| `ComponentResponse` | `src/Maxio/Models/ComponentResponse.cs` |

### ReadComponent

- **Auth**: `options.BasicAuth`
- **Signature**: `ReadComponent(ReadComponentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProductFamilyId`, `ComponentId`
- **Query params (wire ← C#)**: `include_features` ← `IncludeFeatures`
- **Returns**: `ComponentResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ReadComponentRequest` | `src/Maxio/Requests/Components/ReadComponentRequest.cs` |
| `ComponentResponse` | `src/Maxio/Models/ComponentResponse.cs` |

### UpdateComponent

- **Auth**: `options.BasicAuth`
- **Signature**: `UpdateComponent(UpdateComponentOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ComponentId`
- **Returns**: `ComponentResponse`
- **Error**: `ApiException<UpdateComponentError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdateComponentOperationRequest` | `src/Maxio/Requests/Components/UpdateComponentOperationRequest.cs` |
| `UpdateComponentRequest` | `src/Maxio/Models/UpdateComponentRequest.cs` |
| `ComponentResponse` | `src/Maxio/Models/ComponentResponse.cs` |
| `UpdateComponentError` | `src/Maxio/Errors/UpdateComponentError.cs` |
| `ErrorListResponse1` | `src/Maxio/Models/ErrorListResponse1.cs` |

### UpdateProductFamilyComponent

- **Auth**: `options.BasicAuth`
- **Signature**: `UpdateProductFamilyComponent(UpdateProductFamilyComponentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProductFamilyId`, `ComponentId`
- **Returns**: `ComponentResponse`
- **Error**: `ApiException<UpdateProductFamilyComponentError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdateProductFamilyComponentRequest` | `src/Maxio/Requests/Components/UpdateProductFamilyComponentRequest.cs` |
| `UpdateComponentRequest` | `src/Maxio/Models/UpdateComponentRequest.cs` |
| `ComponentResponse` | `src/Maxio/Models/ComponentResponse.cs` |
| `UpdateProductFamilyComponentError` | `src/Maxio/Errors/UpdateProductFamilyComponentError.cs` |
| `ErrorListResponse1` | `src/Maxio/Models/ErrorListResponse1.cs` |

