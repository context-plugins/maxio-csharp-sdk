<!-- Generated file — do not edit; regenerated with the SDK. -->

# Events — operations

Accessor: `client.Events` · Source: `Api/Events.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### ListEvents

- **Auth**: `options.BasicAuth`
- **Signature**: `ListEvents(ListEventsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page` ← `Page`, `per_page` ← `PerPage`, `since_id` ← `SinceId`, `max_id` ← `MaxId`, `direction` ← `Direction`, `filter` ← `Filter`, `date_field` ← `DateField`, `start_date` ← `StartDate`, `end_date` ← `EndDate`, `start_datetime` ← `StartDatetime`, `end_datetime` ← `EndDatetime`
- **Returns**: `IReadOnlyList<EventResponse>`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListEventsRequest` | `Requests/Events/ListEventsRequest.cs` |
| `Direction` | `Models/Enums/Direction.cs` |
| `EventKey` | `Models/Enums/EventKey.cs` |
| `ListEventsDateField` | `Models/Enums/ListEventsDateField.cs` |
| `EventResponse` | `Models/EventResponse.cs` |

### ListSubscriptionEvents

- **Auth**: `options.BasicAuth`
- **Signature**: `ListSubscriptionEvents(ListSubscriptionEventsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`
- **Query params (wire ← C#)**: `page` ← `Page`, `per_page` ← `PerPage`, `since_id` ← `SinceId`, `max_id` ← `MaxId`, `direction` ← `Direction`, `filter` ← `Filter`
- **Returns**: `IReadOnlyList<EventResponse>`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListSubscriptionEventsRequest` | `Requests/Events/ListSubscriptionEventsRequest.cs` |
| `Direction` | `Models/Enums/Direction.cs` |
| `EventKey` | `Models/Enums/EventKey.cs` |
| `EventResponse` | `Models/EventResponse.cs` |

### ReadEventsCount

- **Auth**: `options.BasicAuth`
- **Signature**: `ReadEventsCount(ReadEventsCountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page` ← `Page`, `per_page` ← `PerPage`, `since_id` ← `SinceId`, `max_id` ← `MaxId`, `direction` ← `Direction`, `filter` ← `Filter`
- **Returns**: `CountResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ReadEventsCountRequest` | `Requests/Events/ReadEventsCountRequest.cs` |
| `Direction` | `Models/Enums/Direction.cs` |
| `EventKey` | `Models/Enums/EventKey.cs` |
| `CountResponse` | `Models/CountResponse.cs` |

