<!-- Generated file — do not edit; regenerated with the SDK. -->

# Sites — operations

Accessor: `client.Sites` · Source: `src/Maxio/Api/Sites.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### ClearSite

- **Auth**: `options.BasicAuth`
- **Signature**: `ClearSite(ClearSiteRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `cleanup_scope` ← `CleanupScope`
- **Returns**: `void` (Task)
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ClearSiteRequest` | `src/Maxio/Requests/Sites/ClearSiteRequest.cs` |
| `CleanupScope` | `src/Maxio/Models/Enums/CleanupScope.cs` |

### ListChargifyJsPublicKeys

- **Auth**: `options.BasicAuth`
- **Signature**: `ListChargifyJsPublicKeys(ListChargifyJsPublicKeysRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page` ← `Page`, `per_page` ← `PerPage`
- **Returns**: `ListPublicKeysResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListChargifyJsPublicKeysRequest` | `src/Maxio/Requests/Sites/ListChargifyJsPublicKeysRequest.cs` |
| `ListPublicKeysResponse` | `src/Maxio/Models/ListPublicKeysResponse.cs` |

### ReadSite

- **Auth**: `options.BasicAuth`
- **Signature**: `ReadSite(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `SiteResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SiteResponse` | `src/Maxio/Models/SiteResponse.cs` |

