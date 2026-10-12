<!-- Generated file — do not edit; regenerated with the SDK. -->

# EventsBasedBillingSegments — operations

Accessor: `client.EventsBasedBillingSegments` · Source: `src/Maxio/Api/EventsBasedBillingSegments.cs` · 6 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### BulkCreateSegments

- **Auth**: `options.BasicAuth`
- **Signature**: `BulkCreateSegments(BulkCreateSegmentsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ComponentId`, `PricePointId`
- **Returns**: `ListSegmentsResponse`
- **Error**: `ApiException<BulkCreateSegmentsError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404] · `TryGetEventBasedBillingSegment1(out EventBasedBillingSegment1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `BulkCreateSegmentsRequest` | `src/Maxio/Requests/EventsBasedBillingSegments/BulkCreateSegmentsRequest.cs` |
| `BulkCreateSegments` | `src/Maxio/Models/BulkCreateSegments.cs` |
| `ListSegmentsResponse` | `src/Maxio/Models/ListSegmentsResponse.cs` |
| `BulkCreateSegmentsError` | `src/Maxio/Errors/BulkCreateSegmentsError.cs` |
| `EventBasedBillingSegment1` | `src/Maxio/Models/EventBasedBillingSegment1.cs` |

### BulkUpdateSegments

- **Auth**: `options.BasicAuth`
- **Signature**: `BulkUpdateSegments(BulkUpdateSegmentsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ComponentId`, `PricePointId`
- **Returns**: `ListSegmentsResponse`
- **Error**: `ApiException<BulkUpdateSegmentsError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404] · `TryGetEventBasedBillingSegment1(out EventBasedBillingSegment1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `BulkUpdateSegmentsRequest` | `src/Maxio/Requests/EventsBasedBillingSegments/BulkUpdateSegmentsRequest.cs` |
| `BulkUpdateSegments` | `src/Maxio/Models/BulkUpdateSegments.cs` |
| `ListSegmentsResponse` | `src/Maxio/Models/ListSegmentsResponse.cs` |
| `BulkUpdateSegmentsError` | `src/Maxio/Errors/BulkUpdateSegmentsError.cs` |
| `EventBasedBillingSegment1` | `src/Maxio/Models/EventBasedBillingSegment1.cs` |

### CreateSegment

- **Auth**: `options.BasicAuth`
- **Signature**: `CreateSegment(CreateSegmentOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ComponentId`, `PricePointId`
- **Returns**: `SegmentResponse`
- **Error**: `ApiException<CreateSegmentError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404] · `TryGetEventBasedBillingSegmentErrors1(out EventBasedBillingSegmentErrors1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreateSegmentOperationRequest` | `src/Maxio/Requests/EventsBasedBillingSegments/CreateSegmentOperationRequest.cs` |
| `CreateSegmentRequest` | `src/Maxio/Models/CreateSegmentRequest.cs` |
| `SegmentResponse` | `src/Maxio/Models/SegmentResponse.cs` |
| `CreateSegmentError` | `src/Maxio/Errors/CreateSegmentError.cs` |
| `EventBasedBillingSegmentErrors1` | `src/Maxio/Models/EventBasedBillingSegmentErrors1.cs` |

### DeleteSegment

- **Auth**: `options.BasicAuth`
- **Signature**: `DeleteSegment(DeleteSegmentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ComponentId`, `PricePointId`, `Id`
- **Returns**: `void` (Task)
- **Error**: `ApiException<DeleteSegmentError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404, 422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteSegmentRequest` | `src/Maxio/Requests/EventsBasedBillingSegments/DeleteSegmentRequest.cs` |
| `DeleteSegmentError` | `src/Maxio/Errors/DeleteSegmentError.cs` |

### ListSegmentsForPricePoint

- **Auth**: `options.BasicAuth`
- **Signature**: `ListSegmentsForPricePoint(ListSegmentsForPricePointRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ComponentId`, `PricePointId`
- **Query params (wire ← C#)**: `page` ← `Page`, `per_page` ← `PerPage`, `filter` ← `Filter`
- **Returns**: `ListSegmentsResponse`
- **Error**: `ApiException<ListSegmentsForPricePointError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404] · `TryGetEventBasedBillingListSegmentsErrors1(out EventBasedBillingListSegmentsErrors1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ListSegmentsForPricePointRequest` | `src/Maxio/Requests/EventsBasedBillingSegments/ListSegmentsForPricePointRequest.cs` |
| `ListSegmentsFilter` | `src/Maxio/Models/ListSegmentsFilter.cs` |
| `ListSegmentsResponse` | `src/Maxio/Models/ListSegmentsResponse.cs` |
| `ListSegmentsForPricePointError` | `src/Maxio/Errors/ListSegmentsForPricePointError.cs` |
| `EventBasedBillingListSegmentsErrors1` | `src/Maxio/Models/EventBasedBillingListSegmentsErrors1.cs` |

### UpdateSegment

- **Auth**: `options.BasicAuth`
- **Signature**: `UpdateSegment(UpdateSegmentOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ComponentId`, `PricePointId`, `Id`
- **Returns**: `SegmentResponse`
- **Error**: `ApiException<UpdateSegmentError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404] · `TryGetEventBasedBillingSegmentErrors1(out EventBasedBillingSegmentErrors1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdateSegmentOperationRequest` | `src/Maxio/Requests/EventsBasedBillingSegments/UpdateSegmentOperationRequest.cs` |
| `UpdateSegmentRequest` | `src/Maxio/Models/UpdateSegmentRequest.cs` |
| `SegmentResponse` | `src/Maxio/Models/SegmentResponse.cs` |
| `UpdateSegmentError` | `src/Maxio/Errors/UpdateSegmentError.cs` |
| `EventBasedBillingSegmentErrors1` | `src/Maxio/Models/EventBasedBillingSegmentErrors1.cs` |

