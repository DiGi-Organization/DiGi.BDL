#### [DiGi\.BDL](DiGi.BDL.Overview.md 'DiGi\.BDL\.Overview')

## DiGi\.BDL\.Classes Namespace
### Classes

<a name='DiGi.BDL.Classes.Category'></a>

## Category Class

Attribute used to categorize a field with a specific identifier and name\.

```csharp
public class Category : System.Attribute
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [System\.Attribute](https://learn.microsoft.com/en-us/dotnet/api/system.attribute 'System\.Attribute') → Category
### Constructors

<a name='DiGi.BDL.Classes.Category.Category(string)'></a>

## Category\(string\) Constructor

Initializes a new instance of the [Category](DiGi.BDL.Classes.md#DiGi.BDL.Classes.Category 'DiGi\.BDL\.Classes\.Category') class with a specified identifier,
resolving the name automatically\.

```csharp
public Category(string? id);
```
#### Parameters

<a name='DiGi.BDL.Classes.Category.Category(string).id'></a>

`id` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The unique identifier for the category\.

<a name='DiGi.BDL.Classes.Category.Category(string,string)'></a>

## Category\(string, string\) Constructor

Initializes a new instance of the [Category](DiGi.BDL.Classes.md#DiGi.BDL.Classes.Category 'DiGi\.BDL\.Classes\.Category') class with a specified identifier and name\.

```csharp
public Category(string? id, string? name);
```
#### Parameters

<a name='DiGi.BDL.Classes.Category.Category(string,string).id'></a>

`id` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The unique identifier for the category\.

<a name='DiGi.BDL.Classes.Category.Category(string,string).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The descriptive name for the category\.
### Properties

<a name='DiGi.BDL.Classes.Category.Id'></a>

## Category\.Id Property

Gets the unique identifier of the category\.

```csharp
public string? Id { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.BDL.Classes.Category.Name'></a>

## Category\.Name Property

Gets the descriptive name of the category\.

```csharp
public string? Name { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.BDL.Classes.Group'></a>

## Group Class

Specifies that a field belongs to a particular group\.

```csharp
public class Group : System.Attribute
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [System\.Attribute](https://learn.microsoft.com/en-us/dotnet/api/system.attribute 'System\.Attribute') → Group
### Constructors

<a name='DiGi.BDL.Classes.Group.Group(string)'></a>

## Group\(string\) Constructor

Initializes a new instance of the [Group](DiGi.BDL.Classes.md#DiGi.BDL.Classes.Group 'DiGi\.BDL\.Classes\.Group') class with a specified identifier\.

```csharp
public Group(string? id);
```
#### Parameters

<a name='DiGi.BDL.Classes.Group.Group(string).id'></a>

`id` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The unique identifier for the group\.

<a name='DiGi.BDL.Classes.Group.Group(string,string)'></a>

## Group\(string, string\) Constructor

Initializes a new instance of the [Group](DiGi.BDL.Classes.md#DiGi.BDL.Classes.Group 'DiGi\.BDL\.Classes\.Group') class with a specified identifier and name\.

```csharp
public Group(string? id, string? name);
```
#### Parameters

<a name='DiGi.BDL.Classes.Group.Group(string,string).id'></a>

`id` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The unique identifier for the group\.

<a name='DiGi.BDL.Classes.Group.Group(string,string).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The descriptive name for the group\.
### Properties

<a name='DiGi.BDL.Classes.Group.Id'></a>

## Group\.Id Property

Gets the unique identifier of the group\.

```csharp
public string? Id { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.BDL.Classes.Group.Name'></a>

## Group\.Name Property

Gets the display name of the group\.

```csharp
public string? Name { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.BDL.Classes.Links'></a>

## Links Class

Represents a collection of navigation links typically used for pagination in response objects\.

```csharp
public class Links : DiGi.BDL.Interfaces.IResponseObject, DiGi.BDL.Interfaces.IBDLObject, DiGi.Core.Interfaces.IObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Links

Implements [DiGi\.BDL\.Interfaces\.IResponseObject](https://learn.microsoft.com/en-us/dotnet/api/digi.bdl.interfaces.iresponseobject 'DiGi\.BDL\.Interfaces\.IResponseObject'), [DiGi\.BDL\.Interfaces\.IBDLObject](https://learn.microsoft.com/en-us/dotnet/api/digi.bdl.interfaces.ibdlobject 'DiGi\.BDL\.Interfaces\.IBDLObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')
### Properties

<a name='DiGi.BDL.Classes.Links.first'></a>

## Links\.first Property

Gets or sets the URI for the first page of results\.

```csharp
public string? first { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.BDL.Classes.Links.last'></a>

## Links\.last Property

Gets or sets the URI for the last page of results\.

```csharp
public string? last { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.BDL.Classes.Links.next'></a>

## Links\.next Property

Gets or sets the URI for the next page of results\.

```csharp
public string? next { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.BDL.Classes.Links.self'></a>

## Links\.self Property

Gets or sets the URI for the current page of results\.

```csharp
public string? self { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.BDL.Classes.PKOB'></a>

## PKOB Class

Attribute used to define a set of identifiers for a field\.

```csharp
public class PKOB : System.Attribute
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [System\.Attribute](https://learn.microsoft.com/en-us/dotnet/api/system.attribute 'System\.Attribute') → PKOB
### Constructors

<a name='DiGi.BDL.Classes.PKOB.PKOB(short)'></a>

## PKOB\(short\) Constructor

Initializes a new instance of the [PKOB](DiGi.BDL.Classes.md#DiGi.BDL.Classes.PKOB 'DiGi\.BDL\.Classes\.PKOB') class with a single identifier\.

```csharp
public PKOB(short id);
```
#### Parameters

<a name='DiGi.BDL.Classes.PKOB.PKOB(short).id'></a>

`id` [System\.Int16](https://learn.microsoft.com/en-us/dotnet/api/system.int16 'System\.Int16')

The identifier to assign\.

<a name='DiGi.BDL.Classes.PKOB.PKOB(short,short)'></a>

## PKOB\(short, short\) Constructor

Initializes a new instance of the [PKOB](DiGi.BDL.Classes.md#DiGi.BDL.Classes.PKOB 'DiGi\.BDL\.Classes\.PKOB') class with a range of identifiers\.

```csharp
public PKOB(short from, short to);
```
#### Parameters

<a name='DiGi.BDL.Classes.PKOB.PKOB(short,short).from'></a>

`from` [System\.Int16](https://learn.microsoft.com/en-us/dotnet/api/system.int16 'System\.Int16')

The starting identifier of the range\.

<a name='DiGi.BDL.Classes.PKOB.PKOB(short,short).to'></a>

`to` [System\.Int16](https://learn.microsoft.com/en-us/dotnet/api/system.int16 'System\.Int16')

The ending identifier of the range\.

<a name='DiGi.BDL.Classes.PKOB.PKOB(short[])'></a>

## PKOB\(short\[\]\) Constructor

Initializes a new instance of the [PKOB](DiGi.BDL.Classes.md#DiGi.BDL.Classes.PKOB 'DiGi\.BDL\.Classes\.PKOB') class with an array of identifiers\.

```csharp
public PKOB(short[]? ids);
```
#### Parameters

<a name='DiGi.BDL.Classes.PKOB.PKOB(short[]).ids'></a>

`ids` [System\.Int16](https://learn.microsoft.com/en-us/dotnet/api/system.int16 'System\.Int16')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The array of identifiers to assign\.

<a name='DiGi.BDL.Classes.PKOB.PKOB(System.Collections.Generic.IEnumerable_short_)'></a>

## PKOB\(IEnumerable\<short\>\) Constructor

Initializes a new instance of the [PKOB](DiGi.BDL.Classes.md#DiGi.BDL.Classes.PKOB 'DiGi\.BDL\.Classes\.PKOB') class with a collection of identifiers\.

```csharp
public PKOB(System.Collections.Generic.IEnumerable<short>? ids);
```
#### Parameters

<a name='DiGi.BDL.Classes.PKOB.PKOB(System.Collections.Generic.IEnumerable_short_).ids'></a>

`ids` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.Int16](https://learn.microsoft.com/en-us/dotnet/api/system.int16 'System\.Int16')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The enumerable collection of identifiers to assign\.
### Properties

<a name='DiGi.BDL.Classes.PKOB.Ids'></a>

## PKOB\.Ids Property

Gets the collection of identifiers associated with this attribute\.

```csharp
public System.Collections.Generic.HashSet<short>? Ids { get; }
```

#### Property Value
[System\.Collections\.Generic\.HashSet&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1 'System\.Collections\.Generic\.HashSet\`1')[System\.Int16](https://learn.microsoft.com/en-us/dotnet/api/system.int16 'System\.Int16')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1 'System\.Collections\.Generic\.HashSet\`1')

<a name='DiGi.BDL.Classes.Response_TResultObject_'></a>

## Response\<TResultObject\> Class

Represents a generic base response object that encapsulates result data and metadata\.

```csharp
public abstract class Response<TResultObject> : DiGi.BDL.Interfaces.IResponseObject, DiGi.BDL.Interfaces.IBDLObject, DiGi.Core.Interfaces.IObject
    where TResultObject : DiGi.BDL.Interfaces.IResultObject
```
#### Type parameters

<a name='DiGi.BDL.Classes.Response_TResultObject_.TResultObject'></a>

`TResultObject`

The type of the result object, which must implement [DiGi\.BDL\.Interfaces\.IResultObject](https://learn.microsoft.com/en-us/dotnet/api/digi.bdl.interfaces.iresultobject 'DiGi\.BDL\.Interfaces\.IResultObject')\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Response\<TResultObject\>

Derived  
↳ [UnitsResponse](DiGi.BDL.Classes.md#DiGi.BDL.Classes.UnitsResponse 'DiGi\.BDL\.Classes\.UnitsResponse')  
↳ [UnitYearlyValuesResponse](DiGi.BDL.Classes.md#DiGi.BDL.Classes.UnitYearlyValuesResponse 'DiGi\.BDL\.Classes\.UnitYearlyValuesResponse')

Implements [DiGi\.BDL\.Interfaces\.IResponseObject](https://learn.microsoft.com/en-us/dotnet/api/digi.bdl.interfaces.iresponseobject 'DiGi\.BDL\.Interfaces\.IResponseObject'), [DiGi\.BDL\.Interfaces\.IBDLObject](https://learn.microsoft.com/en-us/dotnet/api/digi.bdl.interfaces.ibdlobject 'DiGi\.BDL\.Interfaces\.IBDLObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')
### Properties

<a name='DiGi.BDL.Classes.Response_TResultObject_.links'></a>

## Response\<TResultObject\>\.links Property

Gets or sets the navigation links associated with the response\.

```csharp
public DiGi.BDL.Classes.Links? links { get; set; }
```

#### Property Value
[Links](DiGi.BDL.Classes.md#DiGi.BDL.Classes.Links 'DiGi\.BDL\.Classes\.Links')

<a name='DiGi.BDL.Classes.Response_TResultObject_.results'></a>

## Response\<TResultObject\>\.results Property

Gets or sets the list of result objects contained in the response\.

```csharp
public System.Collections.Generic.List<TResultObject>? results { get; set; }
```

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[TResultObject](DiGi.BDL.Classes.md#DiGi.BDL.Classes.Response_TResultObject_.TResultObject 'DiGi\.BDL\.Classes\.Response\<TResultObject\>\.TResultObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

<a name='DiGi.BDL.Classes.Response_TResultObject_.totalRecords'></a>

## Response\<TResultObject\>\.totalRecords Property

Gets or sets the total number of records available\.

```csharp
public int totalRecords { get; set; }
```

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='DiGi.BDL.Classes.SubGroup'></a>

## SubGroup Class

Attribute used to categorize fields into a specific subgroup\.

```csharp
public class SubGroup : System.Attribute
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [System\.Attribute](https://learn.microsoft.com/en-us/dotnet/api/system.attribute 'System\.Attribute') → SubGroup
### Constructors

<a name='DiGi.BDL.Classes.SubGroup.SubGroup(string)'></a>

## SubGroup\(string\) Constructor

Initializes a new instance of the [SubGroup](DiGi.BDL.Classes.md#DiGi.BDL.Classes.SubGroup 'DiGi\.BDL\.Classes\.SubGroup') class with a specified identifier\.
The name is automatically resolved using the provided identifier\.

```csharp
public SubGroup(string? id);
```
#### Parameters

<a name='DiGi.BDL.Classes.SubGroup.SubGroup(string).id'></a>

`id` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The unique identifier for the subgroup\.

<a name='DiGi.BDL.Classes.SubGroup.SubGroup(string,string)'></a>

## SubGroup\(string, string\) Constructor

Initializes a new instance of the [SubGroup](DiGi.BDL.Classes.md#DiGi.BDL.Classes.SubGroup 'DiGi\.BDL\.Classes\.SubGroup') class with a specified identifier and name\.

```csharp
public SubGroup(string? id, string? name);
```
#### Parameters

<a name='DiGi.BDL.Classes.SubGroup.SubGroup(string,string).id'></a>

`id` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The unique identifier for the subgroup\.

<a name='DiGi.BDL.Classes.SubGroup.SubGroup(string,string).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The descriptive name for the subgroup\.
### Properties

<a name='DiGi.BDL.Classes.SubGroup.Id'></a>

## SubGroup\.Id Property

Gets the unique identifier of the subgroup\.

```csharp
public string? Id { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.BDL.Classes.SubGroup.Name'></a>

## SubGroup\.Name Property

Gets the descriptive name of the subgroup\.

```csharp
public string? Name { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.BDL.Classes.Unit'></a>

## Unit Class

Represents a unit entity that implements the IResultObject interface\.

```csharp
public class Unit : DiGi.BDL.Interfaces.IResultObject, DiGi.BDL.Interfaces.IBDLObject, DiGi.Core.Interfaces.IObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Unit

Implements [DiGi\.BDL\.Interfaces\.IResultObject](https://learn.microsoft.com/en-us/dotnet/api/digi.bdl.interfaces.iresultobject 'DiGi\.BDL\.Interfaces\.IResultObject'), [DiGi\.BDL\.Interfaces\.IBDLObject](https://learn.microsoft.com/en-us/dotnet/api/digi.bdl.interfaces.ibdlobject 'DiGi\.BDL\.Interfaces\.IBDLObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')
### Properties

<a name='DiGi.BDL.Classes.Unit.hasDescription'></a>

## Unit\.hasDescription Property

Gets or sets a value indicating whether the unit has an associated description\.

```csharp
public bool hasDescription { get; set; }
```

#### Property Value
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

<a name='DiGi.BDL.Classes.Unit.id'></a>

## Unit\.id Property

Gets or sets the unique identifier of the unit\.

```csharp
public string? id { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.BDL.Classes.Unit.level'></a>

## Unit\.level Property

Gets or sets the level associated with the unit\.

```csharp
public short level { get; set; }
```

#### Property Value
[System\.Int16](https://learn.microsoft.com/en-us/dotnet/api/system.int16 'System\.Int16')

<a name='DiGi.BDL.Classes.Unit.name'></a>

## Unit\.name Property

Gets or sets the name of the unit\.

```csharp
public string? name { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.BDL.Classes.UnitsResponse'></a>

## UnitsResponse Class

Represents the response object for unit\-related queries, including pagination details\.

```csharp
public class UnitsResponse : DiGi.BDL.Classes.Response<DiGi.BDL.Classes.Unit>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.BDL\.Classes\.Response&lt;](DiGi.BDL.Classes.md#DiGi.BDL.Classes.Response_TResultObject_ 'DiGi\.BDL\.Classes\.Response\<TResultObject\>')[Unit](DiGi.BDL.Classes.md#DiGi.BDL.Classes.Unit 'DiGi\.BDL\.Classes\.Unit')[&gt;](DiGi.BDL.Classes.md#DiGi.BDL.Classes.Response_TResultObject_ 'DiGi\.BDL\.Classes\.Response\<TResultObject\>') → UnitsResponse
### Properties

<a name='DiGi.BDL.Classes.UnitsResponse.page'></a>

## UnitsResponse\.page Property

Gets or sets the current page number of the results\.

```csharp
public int page { get; set; }
```

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='DiGi.BDL.Classes.UnitsResponse.pageSize'></a>

## UnitsResponse\.pageSize Property

Gets or sets the number of items per page\.

```csharp
public int pageSize { get; set; }
```

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='DiGi.BDL.Classes.UnitYearlyValues'></a>

## UnitYearlyValues Class

Represents a data model containing yearly values associated with a specific unit\.

```csharp
public class UnitYearlyValues : DiGi.BDL.Interfaces.IBDLObject, DiGi.Core.Interfaces.IObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → UnitYearlyValues

Implements [DiGi\.BDL\.Interfaces\.IBDLObject](https://learn.microsoft.com/en-us/dotnet/api/digi.bdl.interfaces.ibdlobject 'DiGi\.BDL\.Interfaces\.IBDLObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')
### Properties

<a name='DiGi.BDL.Classes.UnitYearlyValues.aggregateId'></a>

## UnitYearlyValues\.aggregateId Property

Gets or sets the identifier for the aggregate group\.

```csharp
public int aggregateId { get; set; }
```

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='DiGi.BDL.Classes.UnitYearlyValues.results'></a>

## UnitYearlyValues\.results Property

Gets or sets the list of yearly value results associated with the unit\.

```csharp
public System.Collections.Generic.List<DiGi.BDL.Classes.YearlyValues>? results { get; set; }
```

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[YearlyValues](DiGi.BDL.Classes.md#DiGi.BDL.Classes.YearlyValues 'DiGi\.BDL\.Classes\.YearlyValues')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

<a name='DiGi.BDL.Classes.UnitYearlyValues.unitId'></a>

## UnitYearlyValues\.unitId Property

Gets or sets the unique identifier of the unit\.

```csharp
public string? unitId { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.BDL.Classes.UnitYearlyValues.unitName'></a>

## UnitYearlyValues\.unitName Property

Gets or sets the name of the unit\.

```csharp
public string? unitName { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.BDL.Classes.UnitYearlyValuesResponse'></a>

## UnitYearlyValuesResponse Class

Represents a response containing yearly values for a specific unit\.

```csharp
public class UnitYearlyValuesResponse : DiGi.BDL.Classes.Response<DiGi.BDL.Classes.YearlyValues>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.BDL\.Classes\.Response&lt;](DiGi.BDL.Classes.md#DiGi.BDL.Classes.Response_TResultObject_ 'DiGi\.BDL\.Classes\.Response\<TResultObject\>')[YearlyValues](DiGi.BDL.Classes.md#DiGi.BDL.Classes.YearlyValues 'DiGi\.BDL\.Classes\.YearlyValues')[&gt;](DiGi.BDL.Classes.md#DiGi.BDL.Classes.Response_TResultObject_ 'DiGi\.BDL\.Classes\.Response\<TResultObject\>') → UnitYearlyValuesResponse
### Properties

<a name='DiGi.BDL.Classes.UnitYearlyValuesResponse.aggregateId'></a>

## UnitYearlyValuesResponse\.aggregateId Property

Gets or sets the identifier of the aggregate associated with these values\.

```csharp
public int aggregateId { get; set; }
```

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='DiGi.BDL.Classes.UnitYearlyValuesResponse.unitId'></a>

## UnitYearlyValuesResponse\.unitId Property

Gets or sets the unique identifier of the unit\.

```csharp
public string? unitId { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.BDL.Classes.UnitYearlyValuesResponse.unitName'></a>

## UnitYearlyValuesResponse\.unitName Property

Gets or sets the name of the unit\.

```csharp
public string? unitName { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.BDL.Classes.YearBuiltRange'></a>

## YearBuiltRange Class

Attribute giving the construction period a census variable counts, as the years it was published with \(DiGi\-Organization/DiGi\.BDL\#1\)\.

Both bounds are inclusive. A period open towards the past, such as "before 1918", has no first year.

```csharp
public class YearBuiltRange : System.Attribute
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [System\.Attribute](https://learn.microsoft.com/en-us/dotnet/api/system.attribute 'System\.Attribute') → YearBuiltRange
### Constructors

<a name='DiGi.BDL.Classes.YearBuiltRange.YearBuiltRange(short)'></a>

## YearBuiltRange\(short\) Constructor

Initializes a new instance of the [YearBuiltRange](DiGi.BDL.Classes.md#DiGi.BDL.Classes.YearBuiltRange 'DiGi\.BDL\.Classes\.YearBuiltRange') class for a period open towards the past\.

```csharp
public YearBuiltRange(short lastYear);
```
#### Parameters

<a name='DiGi.BDL.Classes.YearBuiltRange.YearBuiltRange(short).lastYear'></a>

`lastYear` [System\.Int16](https://learn.microsoft.com/en-us/dotnet/api/system.int16 'System\.Int16')

The last year of the period, inclusive\.

<a name='DiGi.BDL.Classes.YearBuiltRange.YearBuiltRange(short,short)'></a>

## YearBuiltRange\(short, short\) Constructor

Initializes a new instance of the [YearBuiltRange](DiGi.BDL.Classes.md#DiGi.BDL.Classes.YearBuiltRange 'DiGi\.BDL\.Classes\.YearBuiltRange') class for a closed period\.

```csharp
public YearBuiltRange(short firstYear, short lastYear);
```
#### Parameters

<a name='DiGi.BDL.Classes.YearBuiltRange.YearBuiltRange(short,short).firstYear'></a>

`firstYear` [System\.Int16](https://learn.microsoft.com/en-us/dotnet/api/system.int16 'System\.Int16')

The first year of the period, inclusive\.

<a name='DiGi.BDL.Classes.YearBuiltRange.YearBuiltRange(short,short).lastYear'></a>

`lastYear` [System\.Int16](https://learn.microsoft.com/en-us/dotnet/api/system.int16 'System\.Int16')

The last year of the period, inclusive\.
### Properties

<a name='DiGi.BDL.Classes.YearBuiltRange.FirstYear'></a>

## YearBuiltRange\.FirstYear Property

Gets the first year of the period, or null when the period is open towards the past\.

```csharp
public System.Nullable<short> FirstYear { get; }
```

#### Property Value
[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Int16](https://learn.microsoft.com/en-us/dotnet/api/system.int16 'System\.Int16')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

<a name='DiGi.BDL.Classes.YearBuiltRange.LastYear'></a>

## YearBuiltRange\.LastYear Property

Gets the last year of the period\.

```csharp
public short LastYear { get; }
```

#### Property Value
[System\.Int16](https://learn.microsoft.com/en-us/dotnet/api/system.int16 'System\.Int16')

<a name='DiGi.BDL.Classes.YearlyValue'></a>

## YearlyValue Class

Represents a data object containing a value associated with a specific year and attribute identifier\.

```csharp
public class YearlyValue : DiGi.BDL.Interfaces.IBDLObject, DiGi.Core.Interfaces.IObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → YearlyValue

Implements [DiGi\.BDL\.Interfaces\.IBDLObject](https://learn.microsoft.com/en-us/dotnet/api/digi.bdl.interfaces.ibdlobject 'DiGi\.BDL\.Interfaces\.IBDLObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')
### Properties

<a name='DiGi.BDL.Classes.YearlyValue.attrId'></a>

## YearlyValue\.attrId Property

Gets or sets the unique identifier of the attribute associated with this value\.

```csharp
public int attrId { get; set; }
```

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='DiGi.BDL.Classes.YearlyValue.val'></a>

## YearlyValue\.val Property

Gets or sets the numeric value for the specified year and attribute\.

```csharp
public double val { get; set; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.BDL.Classes.YearlyValue.year'></a>

## YearlyValue\.year Property

Gets or sets the year string associated with the value\.

```csharp
public string? year { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.BDL.Classes.YearlyValues'></a>

## YearlyValues Class

Represents a set of yearly values associated with a specific measurement unit and identifier\.

```csharp
public class YearlyValues : DiGi.BDL.Interfaces.IResultObject, DiGi.BDL.Interfaces.IBDLObject, DiGi.Core.Interfaces.IObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → YearlyValues

Implements [DiGi\.BDL\.Interfaces\.IResultObject](https://learn.microsoft.com/en-us/dotnet/api/digi.bdl.interfaces.iresultobject 'DiGi\.BDL\.Interfaces\.IResultObject'), [DiGi\.BDL\.Interfaces\.IBDLObject](https://learn.microsoft.com/en-us/dotnet/api/digi.bdl.interfaces.ibdlobject 'DiGi\.BDL\.Interfaces\.IBDLObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')
### Properties

<a name='DiGi.BDL.Classes.YearlyValues.id'></a>

## YearlyValues\.id Property

Gets or sets the unique identifier for the yearly values record\.

```csharp
public int id { get; set; }
```

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='DiGi.BDL.Classes.YearlyValues.lastUpdate'></a>

## YearlyValues\.lastUpdate Property

Gets or sets the date and time when the yearly values were last updated\.

```csharp
public System.DateTime lastUpdate { get; set; }
```

#### Property Value
[System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')

<a name='DiGi.BDL.Classes.YearlyValues.measureUnitId'></a>

## YearlyValues\.measureUnitId Property

Gets or sets the identifier of the measurement unit used for these values\.

```csharp
public int measureUnitId { get; set; }
```

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='DiGi.BDL.Classes.YearlyValues.values'></a>

## YearlyValues\.values Property

Gets or sets the list of individual yearly value entries\.

```csharp
public System.Collections.Generic.List<DiGi.BDL.Classes.YearlyValue>? values { get; set; }
```

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[YearlyValue](DiGi.BDL.Classes.md#DiGi.BDL.Classes.YearlyValue 'DiGi\.BDL\.Classes\.YearlyValue')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')