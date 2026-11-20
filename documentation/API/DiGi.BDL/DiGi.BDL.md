#### [DiGi\.BDL](DiGi.BDL.Overview.md 'DiGi\.BDL\.Overview')

## DiGi\.BDL Namespace
### Classes

<a name='DiGi.BDL.Create'></a>

## Create Class

```csharp
public static class Create
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Create
### Methods

<a name='DiGi.BDL.Create.JsonObjects(string,int,string,int,int)'></a>

## Create\.JsonObjects\(string, int, string, int, int\) Method

Asynchronously retrieves a list of [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') instances from the specified URL,
automatically following pagination links until all data is collected\.

A page refused for exceeding a rate limit (HTTP 429) is requested again after the wait its `Retry-After` header gives (BDL writes it as "`913 sek`"), up to [retryCount](DiGi.BDL.md#DiGi.BDL.Create.JsonObjects(string,int,string,int,int).retryCount 'DiGi\.BDL\.Create\.JsonObjects\(string, int, string, int, int\)\.retryCount') times, when that wait is at most [retryMaxWaitSeconds](DiGi.BDL.md#DiGi.BDL.Create.JsonObjects(string,int,string,int,int).retryMaxWaitSeconds 'DiGi\.BDL\.Create\.JsonObjects\(string, int, string, int, int\)\.retryMaxWaitSeconds'); a longer wait - a 12-hour or 7-day quota - fails at once (DiGi-Organization/DiGi.GIS.PostgreSQL#149). Any other failure, a security block of the client's address included (an HTML page with HTTP 500), fails at once.

```csharp
public static System.Threading.Tasks.Task<System.Collections.Generic.List<System.Text.Json.Nodes.JsonObject>?> JsonObjects(string? url, int pageSize=100, string? clientId=null, int retryCount=3, int retryMaxWaitSeconds=60);
```
#### Parameters

<a name='DiGi.BDL.Create.JsonObjects(string,int,string,int,int).url'></a>

`url` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The starting URL to fetch JSON objects from\.

<a name='DiGi.BDL.Create.JsonObjects(string,int,string,int,int).pageSize'></a>

`pageSize` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The number of records to request per page\. Defaults to 100\.

<a name='DiGi.BDL.Create.JsonObjects(string,int,string,int,int).clientId'></a>

`clientId` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

Optional BDL API client identifier \(API key\) passed in the X\-ClientId header\. Without it the anonymous limits apply\.

<a name='DiGi.BDL.Create.JsonObjects(string,int,string,int,int).retryCount'></a>

`retryCount` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The number of times a page refused for a rate limit is requested again\.

<a name='DiGi.BDL.Create.JsonObjects(string,int,string,int,int).retryMaxWaitSeconds'></a>

`retryMaxWaitSeconds` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The longest wait, in seconds, a retry waits for\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A list of [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') if the operation is successful; otherwise, null\.

<a name='DiGi.BDL.Create.Units(int,string)'></a>

## Create\.Units\(int, string\) Method

Asynchronously retrieves a list of units from the API endpoint\.

```csharp
public static System.Threading.Tasks.Task<System.Collections.Generic.List<DiGi.BDL.Classes.Unit>?> Units(int pageSize=100, string? clientId=null);
```
#### Parameters

<a name='DiGi.BDL.Create.Units(int,string).pageSize'></a>

`pageSize` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The number of records to retrieve per page\.

<a name='DiGi.BDL.Create.Units(int,string).clientId'></a>

`clientId` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

Optional BDL API client identifier \(API key\) passed in the X\-ClientId header\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Unit](DiGi.BDL.Classes.md#DiGi.BDL.Classes.Unit 'DiGi\.BDL\.Classes\.Unit')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\. The task result contains a list of [Unit](DiGi.BDL.Classes.md#DiGi.BDL.Classes.Unit 'DiGi\.BDL\.Classes\.Unit') objects, or null if no data is returned\.

<a name='DiGi.BDL.Create.UnitYearlyValues(string,System.Collections.Generic.IEnumerable_DiGi.BDL.Enums.Variable_,System.Collections.Generic.IEnumerable_int_,int,int,string)'></a>

## Create\.UnitYearlyValues\(string, IEnumerable\<Variable\>, IEnumerable\<int\>, int, int, string\) Method

Retrieves yearly values for a specific unit based on the provided variables and years\.

```csharp
public static System.Threading.Tasks.Task<DiGi.BDL.Classes.UnitYearlyValues?> UnitYearlyValues(string? unitId, System.Collections.Generic.IEnumerable<DiGi.BDL.Enums.Variable>? variables, System.Collections.Generic.IEnumerable<int>? years, int pageSize=100, int variablesMaxCount=50, string? clientId=null);
```
#### Parameters

<a name='DiGi.BDL.Create.UnitYearlyValues(string,System.Collections.Generic.IEnumerable_DiGi.BDL.Enums.Variable_,System.Collections.Generic.IEnumerable_int_,int,int,string).unitId'></a>

`unitId` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The unique identifier of the unit\.

<a name='DiGi.BDL.Create.UnitYearlyValues(string,System.Collections.Generic.IEnumerable_DiGi.BDL.Enums.Variable_,System.Collections.Generic.IEnumerable_int_,int,int,string).variables'></a>

`variables` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Variable](DiGi.BDL.Enums.md#DiGi.BDL.Enums.Variable 'DiGi\.BDL\.Enums\.Variable')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

A collection of variables to retrieve data for\.

<a name='DiGi.BDL.Create.UnitYearlyValues(string,System.Collections.Generic.IEnumerable_DiGi.BDL.Enums.Variable_,System.Collections.Generic.IEnumerable_int_,int,int,string).years'></a>

`years` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

A collection of years for which to retrieve data\.

<a name='DiGi.BDL.Create.UnitYearlyValues(string,System.Collections.Generic.IEnumerable_DiGi.BDL.Enums.Variable_,System.Collections.Generic.IEnumerable_int_,int,int,string).pageSize'></a>

`pageSize` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The number of results per page\.

<a name='DiGi.BDL.Create.UnitYearlyValues(string,System.Collections.Generic.IEnumerable_DiGi.BDL.Enums.Variable_,System.Collections.Generic.IEnumerable_int_,int,int,string).variablesMaxCount'></a>

`variablesMaxCount` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The maximum number of variables to process in a single request batch\.

<a name='DiGi.BDL.Create.UnitYearlyValues(string,System.Collections.Generic.IEnumerable_DiGi.BDL.Enums.Variable_,System.Collections.Generic.IEnumerable_int_,int,int,string).clientId'></a>

`clientId` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The BDL API client identifier sent in the X\-ClientId header, or null for the anonymous limits \(DiGi\-Organization/DiGi\.GIS\.PostgreSQL\#149\)\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[UnitYearlyValues](DiGi.BDL.Classes.md#DiGi.BDL.Classes.UnitYearlyValues 'DiGi\.BDL\.Classes\.UnitYearlyValues')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
An instance of [UnitYearlyValues\(string, IEnumerable&lt;Variable&gt;, IEnumerable&lt;int&gt;, int, int, string\)](DiGi.BDL.md#DiGi.BDL.Create.UnitYearlyValues(string,System.Collections.Generic.IEnumerable_DiGi.BDL.Enums.Variable_,System.Collections.Generic.IEnumerable_int_,int,int,string) 'DiGi\.BDL\.Create\.UnitYearlyValues\(string, System\.Collections\.Generic\.IEnumerable\<DiGi\.BDL\.Enums\.Variable\>, System\.Collections\.Generic\.IEnumerable\<int\>, int, int, string\)') containing the retrieved data, or null if inputs are invalid or retrieval fails\.

<a name='DiGi.BDL.Create.UnitYearlyValuesDictionary(DiGi.BDL.Enums.Variable,int,System.Collections.Generic.IEnumerable_int_,int,string)'></a>

## Create\.UnitYearlyValuesDictionary\(Variable, int, IEnumerable\<int\>, int, string\) Method

Retrieves the values of one variable for every territorial unit of one level, keyed by unit id, from the BDL `data/by-variable` endpoint \(DiGi\-Organization/DiGi\.GIS\.PostgreSQL\#149\)\.

One request per page of [pageSize](DiGi.BDL.md#DiGi.BDL.Create.UnitYearlyValuesDictionary(DiGi.BDL.Enums.Variable,int,System.Collections.Generic.IEnumerable_int_,int,string).pageSize 'DiGi\.BDL\.Create\.UnitYearlyValuesDictionary\(DiGi\.BDL\.Enums\.Variable, int, System\.Collections\.Generic\.IEnumerable\<int\>, int, string\)\.pageSize') units - about 40 for the gmina level - instead of one per unit, so a variable missing from every unit is fetched within the BDL limits. A level the variable is not published at answers no units.

```csharp
public static System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<string,DiGi.BDL.Classes.UnitYearlyValues>?> UnitYearlyValuesDictionary(DiGi.BDL.Enums.Variable variable, int unitLevel, System.Collections.Generic.IEnumerable<int>? years, int pageSize=100, string? clientId=null);
```
#### Parameters

<a name='DiGi.BDL.Create.UnitYearlyValuesDictionary(DiGi.BDL.Enums.Variable,int,System.Collections.Generic.IEnumerable_int_,int,string).variable'></a>

`variable` [Variable](DiGi.BDL.Enums.md#DiGi.BDL.Enums.Variable 'DiGi\.BDL\.Enums\.Variable')

The variable to retrieve\.

<a name='DiGi.BDL.Create.UnitYearlyValuesDictionary(DiGi.BDL.Enums.Variable,int,System.Collections.Generic.IEnumerable_int_,int,string).unitLevel'></a>

`unitLevel` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The BDL unit level, 0 \(country\) to 6 \(gmina\)\.

<a name='DiGi.BDL.Create.UnitYearlyValuesDictionary(DiGi.BDL.Enums.Variable,int,System.Collections.Generic.IEnumerable_int_,int,string).years'></a>

`years` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The years to retrieve\.

<a name='DiGi.BDL.Create.UnitYearlyValuesDictionary(DiGi.BDL.Enums.Variable,int,System.Collections.Generic.IEnumerable_int_,int,string).pageSize'></a>

`pageSize` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The number of units per page\.

<a name='DiGi.BDL.Create.UnitYearlyValuesDictionary(DiGi.BDL.Enums.Variable,int,System.Collections.Generic.IEnumerable_int_,int,string).clientId'></a>

`clientId` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The BDL API client identifier sent in the X\-ClientId header, or null for the anonymous limits\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[System\.Collections\.Generic\.Dictionary&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[UnitYearlyValues](DiGi.BDL.Classes.md#DiGi.BDL.Classes.UnitYearlyValues 'DiGi\.BDL\.Classes\.UnitYearlyValues')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
The values of the variable keyed by unit id, each as a [UnitYearlyValues](DiGi.BDL.Classes.md#DiGi.BDL.Classes.UnitYearlyValues 'DiGi\.BDL\.Classes\.UnitYearlyValues') holding that one variable; null when the inputs are invalid or a request failed\.

<a name='DiGi.BDL.Create.UnitYearlyValuesDictionary(DiGi.BDL.Enums.Variable,System.Collections.Generic.IEnumerable_System.Text.Json.Nodes.JsonObject_)'></a>

## Create\.UnitYearlyValuesDictionary\(Variable, IEnumerable\<JsonObject\>\) Method

Converts the pages of the BDL `data/by-variable` endpoint for one variable into its values keyed by unit id \(DiGi\-Organization/DiGi\.GIS\.PostgreSQL\#149\)\.

```csharp
public static System.Collections.Generic.Dictionary<string,DiGi.BDL.Classes.UnitYearlyValues> UnitYearlyValuesDictionary(DiGi.BDL.Enums.Variable variable, System.Collections.Generic.IEnumerable<System.Text.Json.Nodes.JsonObject>? jsonObjects);
```
#### Parameters

<a name='DiGi.BDL.Create.UnitYearlyValuesDictionary(DiGi.BDL.Enums.Variable,System.Collections.Generic.IEnumerable_System.Text.Json.Nodes.JsonObject_).variable'></a>

`variable` [Variable](DiGi.BDL.Enums.md#DiGi.BDL.Enums.Variable 'DiGi\.BDL\.Enums\.Variable')

The variable the pages hold\.

<a name='DiGi.BDL.Create.UnitYearlyValuesDictionary(DiGi.BDL.Enums.Variable,System.Collections.Generic.IEnumerable_System.Text.Json.Nodes.JsonObject_).jsonObjects'></a>

`jsonObjects` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The pages, as [JsonObjects\(string, int, string, int, int\)](DiGi.BDL.md#DiGi.BDL.Create.JsonObjects(string,int,string,int,int) 'DiGi\.BDL\.Create\.JsonObjects\(string, int, string, int, int\)') returns them\.

#### Returns
[System\.Collections\.Generic\.Dictionary&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[UnitYearlyValues](DiGi.BDL.Classes.md#DiGi.BDL.Classes.UnitYearlyValues 'DiGi\.BDL\.Classes\.UnitYearlyValues')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')  
One [UnitYearlyValues](DiGi.BDL.Classes.md#DiGi.BDL.Classes.UnitYearlyValues 'DiGi\.BDL\.Classes\.UnitYearlyValues') per unit with an id, holding the one variable; a unit spread over two pages has its values joined\. Empty when no page holds a unit\.

<a name='DiGi.BDL.Query'></a>

## Query Class

```csharp
public static class Query
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Query
### Methods

<a name='DiGi.BDL.Query.Category(thisSystem.Enum)'></a>

## Query\.Category\(this Enum\) Method

Retrieves the Category attribute associated with the specified enumeration value\.

```csharp
public static DiGi.BDL.Classes.Category? Category(this System.Enum? @enum);
```
#### Parameters

<a name='DiGi.BDL.Query.Category(thisSystem.Enum).enum'></a>

`enum` [System\.Enum](https://learn.microsoft.com/en-us/dotnet/api/system.enum 'System\.Enum')

The enumeration value to query for the Category attribute\.

#### Returns
[Category](DiGi.BDL.Classes.md#DiGi.BDL.Classes.Category 'DiGi\.BDL\.Classes\.Category')  
The [Category\(this Enum\)](DiGi.BDL.md#DiGi.BDL.Query.Category(thisSystem.Enum) 'DiGi\.BDL\.Query\.Category\(this System\.Enum\)') attribute if found; otherwise, null\.

<a name='DiGi.BDL.Query.CustomAttribute_TAttribute_(thisSystem.Enum)'></a>

## Query\.CustomAttribute\<TAttribute\>\(this Enum\) Method

Retrieves the specified attribute from the field of the provided enumeration value\.

```csharp
public static TAttribute? CustomAttribute<TAttribute>(this System.Enum? @enum)
    where TAttribute : System.Attribute;
```
#### Type parameters

<a name='DiGi.BDL.Query.CustomAttribute_TAttribute_(thisSystem.Enum).TAttribute'></a>

`TAttribute`

The type of the attribute to retrieve\.
#### Parameters

<a name='DiGi.BDL.Query.CustomAttribute_TAttribute_(thisSystem.Enum).enum'></a>

`enum` [System\.Enum](https://learn.microsoft.com/en-us/dotnet/api/system.enum 'System\.Enum')

The enumeration value to inspect\.

#### Returns
[TAttribute](DiGi.BDL.md#DiGi.BDL.Query.CustomAttribute_TAttribute_(thisSystem.Enum).TAttribute 'DiGi\.BDL\.Query\.CustomAttribute\<TAttribute\>\(this System\.Enum\)\.TAttribute')  
The requested attribute if found; otherwise, null\.

<a name='DiGi.BDL.Query.FieldDictionary(thisSystem.Type)'></a>

## Query\.FieldDictionary\(this Type\) Method

Extracts a dictionary of field names and their corresponding values from the specified type, 
filtering for public static literal fields that are not initialization\-only\.

```csharp
public static System.Collections.Generic.Dictionary<string,object> FieldDictionary(this System.Type type);
```
#### Parameters

<a name='DiGi.BDL.Query.FieldDictionary(thisSystem.Type).type'></a>

`type` [System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')

The type to extract fields from\.

#### Returns
[System\.Collections\.Generic\.Dictionary&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')  
A dictionary containing the names and values of the filtered fields\.

<a name='DiGi.BDL.Query.Group(thisSystem.Enum)'></a>

## Query\.Group\(this Enum\) Method

Retrieves the Group attribute associated with the specified enumeration value\.

```csharp
public static DiGi.BDL.Classes.Group? Group(this System.Enum? @enum);
```
#### Parameters

<a name='DiGi.BDL.Query.Group(thisSystem.Enum).enum'></a>

`enum` [System\.Enum](https://learn.microsoft.com/en-us/dotnet/api/system.enum 'System\.Enum')

The enumeration value to query for the Group attribute\.

#### Returns
[Group](DiGi.BDL.Classes.md#DiGi.BDL.Classes.Group 'DiGi\.BDL\.Classes\.Group')  
The Group attribute if found; otherwise, null\.

<a name='DiGi.BDL.Query.Name(thisSystem.Type,string)'></a>

## Query\.Name\(this Type, string\) Method

Retrieves the name associated with a specific identifier for a given type from its field dictionary\.

```csharp
public static string? Name(this System.Type? type, string? id);
```
#### Parameters

<a name='DiGi.BDL.Query.Name(thisSystem.Type,string).type'></a>

`type` [System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')

The type to query\.

<a name='DiGi.BDL.Query.Name(thisSystem.Type,string).id'></a>

`id` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The identifier of the field whose name is being requested\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
The string representation of the found value, or null if the type is null, the id is empty, or the value is not found\.

<a name='DiGi.BDL.Query.PKOB(thisSystem.Enum)'></a>

## Query\.PKOB\(this Enum\) Method

Retrieves the PKOB custom attribute associated with the specified enumeration value\.

```csharp
public static DiGi.BDL.Classes.PKOB? PKOB(this System.Enum? @enum);
```
#### Parameters

<a name='DiGi.BDL.Query.PKOB(thisSystem.Enum).enum'></a>

`enum` [System\.Enum](https://learn.microsoft.com/en-us/dotnet/api/system.enum 'System\.Enum')

The enumeration value to evaluate\.

#### Returns
[PKOB](DiGi.BDL.Classes.md#DiGi.BDL.Classes.PKOB 'DiGi\.BDL\.Classes\.PKOB')  
The PKOB attribute if found; otherwise, null\.

<a name='DiGi.BDL.Query.SubGroup(thisSystem.Enum)'></a>

## Query\.SubGroup\(this Enum\) Method

Retrieves the SubGroup attribute associated with the specified enumeration value\.

```csharp
public static DiGi.BDL.Classes.SubGroup? SubGroup(this System.Enum? @enum);
```
#### Parameters

<a name='DiGi.BDL.Query.SubGroup(thisSystem.Enum).enum'></a>

`enum` [System\.Enum](https://learn.microsoft.com/en-us/dotnet/api/system.enum 'System\.Enum')

The enumeration value to evaluate\.

#### Returns
[SubGroup](DiGi.BDL.Classes.md#DiGi.BDL.Classes.SubGroup 'DiGi\.BDL\.Classes\.SubGroup')  
The [SubGroup\(this Enum\)](DiGi.BDL.md#DiGi.BDL.Query.SubGroup(thisSystem.Enum) 'DiGi\.BDL\.Query\.SubGroup\(this System\.Enum\)') attribute if it exists; otherwise, null\.

<a name='DiGi.BDL.Query.YearBuiltRange(thisSystem.Enum)'></a>

## Query\.YearBuiltRange\(this Enum\) Method

Retrieves the construction period a census variable counts \(DiGi\-Organization/DiGi\.BDL\#1\)\.

```csharp
public static DiGi.BDL.Classes.YearBuiltRange? YearBuiltRange(this System.Enum? @enum);
```
#### Parameters

<a name='DiGi.BDL.Query.YearBuiltRange(thisSystem.Enum).enum'></a>

`enum` [System\.Enum](https://learn.microsoft.com/en-us/dotnet/api/system.enum 'System\.Enum')

The enumeration value to evaluate\.

#### Returns
[YearBuiltRange](DiGi.BDL.Classes.md#DiGi.BDL.Classes.YearBuiltRange 'DiGi\.BDL\.Classes\.YearBuiltRange')  
The YearBuiltRange attribute if found; otherwise, null \- also for a total or any variable that is not a count by construction period\.