<!-- Generated file — do not edit; regenerated with the SDK. -->

# Events — operations

Accessor: `client.Events` · Source: `src/Maxio/Api/Events.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### ListEvents

- **Auth**: `options.BasicAuth`
- **Signature**: `ListEvents(ListEventsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page` ← `Page`, `per_page` ← `PerPage`, `since_id` ← `SinceId`, `max_id` ← `MaxId`, `direction` ← `Direction`, `filter` ← `Filter`, `date_field` ← `DateField`, `start_date` ← `StartDate`, `end_date` ← `EndDate`, `start_datetime` ← `StartDatetime`, `end_datetime` ← `EndDatetime`
- **Returns**: `IReadOnlyList<EventResponse>`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListEventsRequest` | `src/Maxio/Requests/Events/ListEventsRequest.cs` |
| `Direction` | `src/Maxio/Models/Enums/Direction.cs` |
| `EventKey` | `src/Maxio/Models/Enums/EventKey.cs` |
| `ListEventsDateField` | `src/Maxio/Models/Enums/ListEventsDateField.cs` |
| `EventResponse` | `src/Maxio/Models/EventResponse.cs` |

### ListSubscriptionEvents

- **Auth**: `options.BasicAuth`
- **Signature**: `ListSubscriptionEvents(ListSubscriptionEventsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`
- **Query params (wire ← C#)**: `page` ← `Page`, `per_page` ← `PerPage`, `since_id` ← `SinceId`, `max_id` ← `MaxId`, `direction` ← `Direction`, `filter` ← `Filter`
- **Returns**: `IReadOnlyList<EventResponse>`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListSubscriptionEventsRequest` | `src/Maxio/Requests/Events/ListSubscriptionEventsRequest.cs` |
| `Direction` | `src/Maxio/Models/Enums/Direction.cs` |
| `EventKey` | `src/Maxio/Models/Enums/EventKey.cs` |
| `EventResponse` | `src/Maxio/Models/EventResponse.cs` |

### ReadEventsCount

- **Auth**: `options.BasicAuth`
- **Signature**: `ReadEventsCount(ReadEventsCountRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page` ← `Page`, `per_page` ← `PerPage`, `since_id` ← `SinceId`, `max_id` ← `MaxId`, `direction` ← `Direction`, `filter` ← `Filter`
- **Returns**: `CountResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ReadEventsCountRequest` | `src/Maxio/Requests/Events/ReadEventsCountRequest.cs` |
| `Direction` | `src/Maxio/Models/Enums/Direction.cs` |
| `EventKey` | `src/Maxio/Models/Enums/EventKey.cs` |
| `CountResponse` | `src/Maxio/Models/CountResponse.cs` |

