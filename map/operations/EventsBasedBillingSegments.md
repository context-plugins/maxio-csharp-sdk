<!-- Generated file — do not edit; regenerated with the SDK. -->

# EventsBasedBillingSegments — operations

Accessor: `client.EventsBasedBillingSegments` · Source: `Api/EventsBasedBillingSegments.cs` · 6 operations

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
| `BulkCreateSegmentsRequest` | `Requests/EventsBasedBillingSegments/BulkCreateSegmentsRequest.cs` |
| `BulkCreateSegments` | `Models/BulkCreateSegments.cs` |
| `ListSegmentsResponse` | `Models/ListSegmentsResponse.cs` |
| `BulkCreateSegmentsError` | `Errors/BulkCreateSegmentsError.cs` |
| `EventBasedBillingSegment1` | `Models/EventBasedBillingSegment1.cs` |

### BulkUpdateSegments

- **Auth**: `options.BasicAuth`
- **Signature**: `BulkUpdateSegments(BulkUpdateSegmentsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ComponentId`, `PricePointId`
- **Returns**: `ListSegmentsResponse`
- **Error**: `ApiException<BulkUpdateSegmentsError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404] · `TryGetEventBasedBillingSegment1(out EventBasedBillingSegment1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `BulkUpdateSegmentsRequest` | `Requests/EventsBasedBillingSegments/BulkUpdateSegmentsRequest.cs` |
| `BulkUpdateSegments` | `Models/BulkUpdateSegments.cs` |
| `ListSegmentsResponse` | `Models/ListSegmentsResponse.cs` |
| `BulkUpdateSegmentsError` | `Errors/BulkUpdateSegmentsError.cs` |
| `EventBasedBillingSegment1` | `Models/EventBasedBillingSegment1.cs` |

### CreateSegment

- **Auth**: `options.BasicAuth`
- **Signature**: `CreateSegment(CreateSegmentOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ComponentId`, `PricePointId`
- **Returns**: `SegmentResponse`
- **Error**: `ApiException<CreateSegmentError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404] · `TryGetEventBasedBillingSegmentErrors1(out EventBasedBillingSegmentErrors1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreateSegmentOperationRequest` | `Requests/EventsBasedBillingSegments/CreateSegmentOperationRequest.cs` |
| `CreateSegmentRequest` | `Models/CreateSegmentRequest.cs` |
| `SegmentResponse` | `Models/SegmentResponse.cs` |
| `CreateSegmentError` | `Errors/CreateSegmentError.cs` |
| `EventBasedBillingSegmentErrors1` | `Models/EventBasedBillingSegmentErrors1.cs` |

### DeleteSegment

- **Auth**: `options.BasicAuth`
- **Signature**: `DeleteSegment(DeleteSegmentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ComponentId`, `PricePointId`, `Id`
- **Returns**: `void` (Task)
- **Error**: `ApiException<DeleteSegmentError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404, 422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteSegmentRequest` | `Requests/EventsBasedBillingSegments/DeleteSegmentRequest.cs` |
| `DeleteSegmentError` | `Errors/DeleteSegmentError.cs` |

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
| `ListSegmentsForPricePointRequest` | `Requests/EventsBasedBillingSegments/ListSegmentsForPricePointRequest.cs` |
| `ListSegmentsFilter` | `Models/ListSegmentsFilter.cs` |
| `ListSegmentsResponse` | `Models/ListSegmentsResponse.cs` |
| `ListSegmentsForPricePointError` | `Errors/ListSegmentsForPricePointError.cs` |
| `EventBasedBillingListSegmentsErrors1` | `Models/EventBasedBillingListSegmentsErrors1.cs` |

### UpdateSegment

- **Auth**: `options.BasicAuth`
- **Signature**: `UpdateSegment(UpdateSegmentOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ComponentId`, `PricePointId`, `Id`
- **Returns**: `SegmentResponse`
- **Error**: `ApiException<UpdateSegmentError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404] · `TryGetEventBasedBillingSegmentErrors1(out EventBasedBillingSegmentErrors1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdateSegmentOperationRequest` | `Requests/EventsBasedBillingSegments/UpdateSegmentOperationRequest.cs` |
| `UpdateSegmentRequest` | `Models/UpdateSegmentRequest.cs` |
| `SegmentResponse` | `Models/SegmentResponse.cs` |
| `UpdateSegmentError` | `Errors/UpdateSegmentError.cs` |
| `EventBasedBillingSegmentErrors1` | `Models/EventBasedBillingSegmentErrors1.cs` |

