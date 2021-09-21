<a name='assembly'></a>
# Raccoon.Ninja.Extensions.Common

## Contents

- [DateTimeExtensions](#T-Raccoon-Ninja-Extensions-Common-DateTimeExtensions 'Raccoon.Ninja.Extensions.Common.DateTimeExtensions')
  - [AdjustDate(dt,year,month,day)](#M-Raccoon-Ninja-Extensions-Common-DateTimeExtensions-AdjustDate-System-DateTime,System-Nullable{System-Int32},System-Nullable{System-Int32},System-Nullable{System-Int32}- 'Raccoon.Ninja.Extensions.Common.DateTimeExtensions.AdjustDate(System.DateTime,System.Nullable{System.Int32},System.Nullable{System.Int32},System.Nullable{System.Int32})')
  - [AdjustTime(dt,hour,minute,second,ms)](#M-Raccoon-Ninja-Extensions-Common-DateTimeExtensions-AdjustTime-System-DateTime,System-Nullable{System-Int32},System-Nullable{System-Int32},System-Nullable{System-Int32},System-Nullable{System-Int32}- 'Raccoon.Ninja.Extensions.Common.DateTimeExtensions.AdjustTime(System.DateTime,System.Nullable{System.Int32},System.Nullable{System.Int32},System.Nullable{System.Int32},System.Nullable{System.Int32})')
  - [AdjustToMinuteEnd(dt)](#M-Raccoon-Ninja-Extensions-Common-DateTimeExtensions-AdjustToMinuteEnd-System-DateTime- 'Raccoon.Ninja.Extensions.Common.DateTimeExtensions.AdjustToMinuteEnd(System.DateTime)')
  - [AdjustToMinuteStart(dt)](#M-Raccoon-Ninja-Extensions-Common-DateTimeExtensions-AdjustToMinuteStart-System-DateTime- 'Raccoon.Ninja.Extensions.Common.DateTimeExtensions.AdjustToMinuteStart(System.DateTime)')
  - [IsMidnight(dt,utcOffset)](#M-Raccoon-Ninja-Extensions-Common-DateTimeExtensions-IsMidnight-System-DateTime,System-Int32- 'Raccoon.Ninja.Extensions.Common.DateTimeExtensions.IsMidnight(System.DateTime,System.Int32)')
  - [IsSameDate(dt,otherDate)](#M-Raccoon-Ninja-Extensions-Common-DateTimeExtensions-IsSameDate-System-DateTime,System-DateTime- 'Raccoon.Ninja.Extensions.Common.DateTimeExtensions.IsSameDate(System.DateTime,System.DateTime)')
  - [IsToday(dt)](#M-Raccoon-Ninja-Extensions-Common-DateTimeExtensions-IsToday-System-DateTime- 'Raccoon.Ninja.Extensions.Common.DateTimeExtensions.IsToday(System.DateTime)')
  - [IsTodaySameHour(dt)](#M-Raccoon-Ninja-Extensions-Common-DateTimeExtensions-IsTodaySameHour-System-DateTime- 'Raccoon.Ninja.Extensions.Common.DateTimeExtensions.IsTodaySameHour(System.DateTime)')
- [DoubleExtensions](#T-Raccoon-Ninja-Extensions-Common-DoubleExtensions 'Raccoon.Ninja.Extensions.Common.DoubleExtensions')
  - [Round(value,digits)](#M-Raccoon-Ninja-Extensions-Common-DoubleExtensions-Round-System-Double,System-Int32- 'Raccoon.Ninja.Extensions.Common.DoubleExtensions.Round(System.Double,System.Int32)')
- [ErrorMessages](#T-Raccoon-Ninja-Extensions-Common-Internationalization-ErrorMessages 'Raccoon.Ninja.Extensions.Common.Internationalization.ErrorMessages')
  - [Culture](#P-Raccoon-Ninja-Extensions-Common-Internationalization-ErrorMessages-Culture 'Raccoon.Ninja.Extensions.Common.Internationalization.ErrorMessages.Culture')
  - [InvalidDateManipulation](#P-Raccoon-Ninja-Extensions-Common-Internationalization-ErrorMessages-InvalidDateManipulation 'Raccoon.Ninja.Extensions.Common.Internationalization.ErrorMessages.InvalidDateManipulation')
  - [NullStringToConvert](#P-Raccoon-Ninja-Extensions-Common-Internationalization-ErrorMessages-NullStringToConvert 'Raccoon.Ninja.Extensions.Common.Internationalization.ErrorMessages.NullStringToConvert')
  - [ResourceManager](#P-Raccoon-Ninja-Extensions-Common-Internationalization-ErrorMessages-ResourceManager 'Raccoon.Ninja.Extensions.Common.Internationalization.ErrorMessages.ResourceManager')
- [ListExtensions](#T-Raccoon-Ninja-Extensions-Common-ListExtensions 'Raccoon.Ninja.Extensions.Common.ListExtensions')
  - [ContainsCaseInsensitive(list,contains)](#M-Raccoon-Ninja-Extensions-Common-ListExtensions-ContainsCaseInsensitive-System-Collections-Generic-IList{System-String},System-String- 'Raccoon.Ninja.Extensions.Common.ListExtensions.ContainsCaseInsensitive(System.Collections.Generic.IList{System.String},System.String)')
  - [ForEachWithIndex\`\`1(source)](#M-Raccoon-Ninja-Extensions-Common-ListExtensions-ForEachWithIndex``1-System-Collections-Generic-IEnumerable{``0}- 'Raccoon.Ninja.Extensions.Common.ListExtensions.ForEachWithIndex``1(System.Collections.Generic.IEnumerable{``0})')
  - [Replace\`\`1(list,oldObj,newObj)](#M-Raccoon-Ninja-Extensions-Common-ListExtensions-Replace``1-System-Collections-Generic-IList{``0},``0,``0- 'Raccoon.Ninja.Extensions.Common.ListExtensions.Replace``1(System.Collections.Generic.IList{``0},``0,``0)')
- [MemoryStreamExtensions](#T-Raccoon-Ninja-Extensions-Common-MemoryStreamExtensions 'Raccoon.Ninja.Extensions.Common.MemoryStreamExtensions')
  - [ToUtf8String(stream)](#M-Raccoon-Ninja-Extensions-Common-MemoryStreamExtensions-ToUtf8String-System-IO-MemoryStream- 'Raccoon.Ninja.Extensions.Common.MemoryStreamExtensions.ToUtf8String(System.IO.MemoryStream)')
- [StreamExtensions](#T-Raccoon-Ninja-Extensions-Common-StreamExtensions 'Raccoon.Ninja.Extensions.Common.StreamExtensions')
  - [ToMemoryStream(stream)](#M-Raccoon-Ninja-Extensions-Common-StreamExtensions-ToMemoryStream-System-IO-Stream- 'Raccoon.Ninja.Extensions.Common.StreamExtensions.ToMemoryStream(System.IO.Stream)')
- [StringExtensions](#T-Raccoon-Ninja-Extensions-Common-StringExtensions 'Raccoon.Ninja.Extensions.Common.StringExtensions')
  - [BreakLinePattern](#F-Raccoon-Ninja-Extensions-Common-StringExtensions-BreakLinePattern 'Raccoon.Ninja.Extensions.Common.StringExtensions.BreakLinePattern')
  - [Minify(bigText)](#M-Raccoon-Ninja-Extensions-Common-StringExtensions-Minify-System-String- 'Raccoon.Ninja.Extensions.Common.StringExtensions.Minify(System.String)')
  - [OnlyDigits(text)](#M-Raccoon-Ninja-Extensions-Common-StringExtensions-OnlyDigits-System-String- 'Raccoon.Ninja.Extensions.Common.StringExtensions.OnlyDigits(System.String)')
  - [StripAccents(text)](#M-Raccoon-Ninja-Extensions-Common-StringExtensions-StripAccents-System-String- 'Raccoon.Ninja.Extensions.Common.StringExtensions.StripAccents(System.String)')
  - [ToMemoryStream(data)](#M-Raccoon-Ninja-Extensions-Common-StringExtensions-ToMemoryStream-System-String- 'Raccoon.Ninja.Extensions.Common.StringExtensions.ToMemoryStream(System.String)')
- [TimeSpanExtensions](#T-Raccoon-Ninja-Extensions-Common-TimeSpanExtensions 'Raccoon.Ninja.Extensions.Common.TimeSpanExtensions')
  - [RoundMs(ts)](#M-Raccoon-Ninja-Extensions-Common-TimeSpanExtensions-RoundMs-System-TimeSpan- 'Raccoon.Ninja.Extensions.Common.TimeSpanExtensions.RoundMs(System.TimeSpan)')

<a name='T-Raccoon-Ninja-Extensions-Common-DateTimeExtensions'></a>
## DateTimeExtensions `type`

##### Namespace

Raccoon.Ninja.Extensions.Common

##### Summary

Extension methods for DateTime instances

<a name='M-Raccoon-Ninja-Extensions-Common-DateTimeExtensions-AdjustDate-System-DateTime,System-Nullable{System-Int32},System-Nullable{System-Int32},System-Nullable{System-Int32}-'></a>
### AdjustDate(dt,year,month,day) `method`

##### Summary

Creates a new DateTime object, based on current, with date values adjusted.

##### Returns

New datetime object with adjusted date.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dt | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | Current DateTime object |
| year | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | If informed, will override YEAR |
| month | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | If informed, will override MONTH |
| day | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | If informed, will override DAY |

<a name='M-Raccoon-Ninja-Extensions-Common-DateTimeExtensions-AdjustTime-System-DateTime,System-Nullable{System-Int32},System-Nullable{System-Int32},System-Nullable{System-Int32},System-Nullable{System-Int32}-'></a>
### AdjustTime(dt,hour,minute,second,ms) `method`

##### Summary

Creates a new DateTime object, based on current, with time values adjusted.

##### Returns

New datetime object with adjusted time.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dt | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | Current DateTime object |
| hour | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | If informed, will override HOUR |
| minute | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | If informed, will override MINUTE |
| second | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | If informed, will override SECONDS |
| ms | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | If informed, will override MILLISECOND |

<a name='M-Raccoon-Ninja-Extensions-Common-DateTimeExtensions-AdjustToMinuteEnd-System-DateTime-'></a>
### AdjustToMinuteEnd(dt) `method`

##### Summary

Returns a new DateTime object pointing to the end of the minute.
    (59 seconds and 999 milliseconds passed)
    Ie: 2021-02-02 12:59:34.123 -> 2021-02-02 12:59:59.999

##### Returns

New datetime object with adjusted time.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dt | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | Current DateTime object |

<a name='M-Raccoon-Ninja-Extensions-Common-DateTimeExtensions-AdjustToMinuteStart-System-DateTime-'></a>
### AdjustToMinuteStart(dt) `method`

##### Summary

Returns a new DateTime object pointing to the start of the minute.
    (zero seconds and zero milliseconds passed)
    Ie: 2021-02-02 12:59:34.123 -> 2021-02-02 12:59:00.000

##### Returns

New datetime object with adjusted time.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dt | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | Current DateTime object |

<a name='M-Raccoon-Ninja-Extensions-Common-DateTimeExtensions-IsMidnight-System-DateTime,System-Int32-'></a>
### IsMidnight(dt,utcOffset) `method`

##### Summary

Checks if the hour in the datetime corresponds to Midnight (0 hour).
    This checks ignores anything after hours (minutes, seconds, ms, etc.)

##### Returns

true if it's midnight. false otherwise

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dt | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | Current DateTime |
| utcOffset | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | if current date is in utc, this offset will be used in the calculation. Default: 180 (BRT-3) |

<a name='M-Raccoon-Ninja-Extensions-Common-DateTimeExtensions-IsSameDate-System-DateTime,System-DateTime-'></a>
### IsSameDate(dt,otherDate) `method`

##### Summary

Checks if some other date object has the same values for the Date.

##### Returns

true if it's the same day/false otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dt | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | Current DateTime object |
| otherDate | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | object to be compared with. |

<a name='M-Raccoon-Ninja-Extensions-Common-DateTimeExtensions-IsToday-System-DateTime-'></a>
### IsToday(dt) `method`

##### Summary

Checks if date is today

##### Returns

true if is today

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dt | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | datetime to check |

<a name='M-Raccoon-Ninja-Extensions-Common-DateTimeExtensions-IsTodaySameHour-System-DateTime-'></a>
### IsTodaySameHour(dt) `method`

##### Summary

Checks if date is today and hour is equal to current hour

##### Returns

true if is today and hour equal to current hour

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dt | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | datetime to check |

<a name='T-Raccoon-Ninja-Extensions-Common-DoubleExtensions'></a>
## DoubleExtensions `type`

##### Namespace

Raccoon.Ninja.Extensions.Common

##### Summary

Extension methods for double instances

<a name='M-Raccoon-Ninja-Extensions-Common-DoubleExtensions-Round-System-Double,System-Int32-'></a>
### Round(value,digits) `method`

##### Summary

Convenience method to return a rounded version of a double.

##### Returns

value rounded

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double') | value to round |
| digits | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | lenght of decimal places |

<a name='T-Raccoon-Ninja-Extensions-Common-Internationalization-ErrorMessages'></a>
## ErrorMessages `type`

##### Namespace

Raccoon.Ninja.Extensions.Common.Internationalization

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-Raccoon-Ninja-Extensions-Common-Internationalization-ErrorMessages-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-Raccoon-Ninja-Extensions-Common-Internationalization-ErrorMessages-InvalidDateManipulation'></a>
### InvalidDateManipulation `property`

##### Summary

Looks up a localized string similar to An attempt to manipulate date resulted in a invalid datetime object..

<a name='P-Raccoon-Ninja-Extensions-Common-Internationalization-ErrorMessages-NullStringToConvert'></a>
### NullStringToConvert `property`

##### Summary

Looks up a localized string similar to Cannot convert a string that is null or empty to a memory stream..

<a name='P-Raccoon-Ninja-Extensions-Common-Internationalization-ErrorMessages-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='T-Raccoon-Ninja-Extensions-Common-ListExtensions'></a>
## ListExtensions `type`

##### Namespace

Raccoon.Ninja.Extensions.Common

##### Summary

Extension methods for list instances

<a name='M-Raccoon-Ninja-Extensions-Common-ListExtensions-ContainsCaseInsensitive-System-Collections-Generic-IList{System-String},System-String-'></a>
### ContainsCaseInsensitive(list,contains) `method`

##### Summary

Checks if a list of strings contains another string and does the search using
    culture invariant and case insensitive.

##### Returns

true if list contains target text. false otherwise

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| list | [System.Collections.Generic.IList{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IList 'System.Collections.Generic.IList{System.String}') | target list |
| contains | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | string that will be checked |

<a name='M-Raccoon-Ninja-Extensions-Common-ListExtensions-ForEachWithIndex``1-System-Collections-Generic-IEnumerable{``0}-'></a>
### ForEachWithIndex\`\`1(source) `method`

##### Summary

Returns an iterable list containing every item AND it's index.

##### Returns

IEnumerable containing tuples with index and title

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | target list |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | data type of the items in the lsit |

<a name='M-Raccoon-Ninja-Extensions-Common-ListExtensions-Replace``1-System-Collections-Generic-IList{``0},``0,``0-'></a>
### Replace\`\`1(list,oldObj,newObj) `method`

##### Summary

Replaces an item in the list

##### Returns

true if object is replaced, false if object is not found in list

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| list | [System.Collections.Generic.IList{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IList 'System.Collections.Generic.IList{``0}') | list of T |
| oldObj | [\`\`0](#T-``0 '``0') | old object. to be replaced by new |
| newObj | [\`\`0](#T-``0 '``0') | new/updated object that will replace the old |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | type of the objects in the list |

<a name='T-Raccoon-Ninja-Extensions-Common-MemoryStreamExtensions'></a>
## MemoryStreamExtensions `type`

##### Namespace

Raccoon.Ninja.Extensions.Common

##### Summary

Extension methods for MemoryStream instances

<a name='M-Raccoon-Ninja-Extensions-Common-MemoryStreamExtensions-ToUtf8String-System-IO-MemoryStream-'></a>
### ToUtf8String(stream) `method`

##### Summary

Converts a memory stream to an utf-8 encoded string.

##### Returns

converted string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| stream | [System.IO.MemoryStream](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.MemoryStream 'System.IO.MemoryStream') | stream to be converted |

<a name='T-Raccoon-Ninja-Extensions-Common-StreamExtensions'></a>
## StreamExtensions `type`

##### Namespace

Raccoon.Ninja.Extensions.Common

##### Summary

Extension methods for Stream instances

<a name='M-Raccoon-Ninja-Extensions-Common-StreamExtensions-ToMemoryStream-System-IO-Stream-'></a>
### ToMemoryStream(stream) `method`

##### Summary

Converts a Stream to MemoryStream

##### Returns

stream converted to memory strema

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| stream | [System.IO.Stream](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.Stream 'System.IO.Stream') | to be converted |

<a name='T-Raccoon-Ninja-Extensions-Common-StringExtensions'></a>
## StringExtensions `type`

##### Namespace

Raccoon.Ninja.Extensions.Common

##### Summary

Extension methods for string instances

<a name='F-Raccoon-Ninja-Extensions-Common-StringExtensions-BreakLinePattern'></a>
### BreakLinePattern `constants`

##### Summary

Regex pattern that will seek one or more spaces, tabs and line breaks.

<a name='M-Raccoon-Ninja-Extensions-Common-StringExtensions-Minify-System-String-'></a>
### Minify(bigText) `method`

##### Summary

Minifies a text.
    Replaces everything that is caught by the Pattern variable and replaces it with one space.
    If null or empty, will return null.

##### Returns

Minified text.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| bigText | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Text to be minified. |

<a name='M-Raccoon-Ninja-Extensions-Common-StringExtensions-OnlyDigits-System-String-'></a>
### OnlyDigits(text) `method`

##### Summary

Removes everything that's not a digit (0 through 9) from a string.

##### Returns

string containing only numbers

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| text | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | target string |

<a name='M-Raccoon-Ninja-Extensions-Common-StringExtensions-StripAccents-System-String-'></a>
### StripAccents(text) `method`

##### Summary

Remove accents... well, actually, remove all DIACRITICS from a string,
    but saying 'accents' is easier to remember.

##### Returns

Text without diacritics

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| text | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Text that will be used to remove diacritics |

<a name='M-Raccoon-Ninja-Extensions-Common-StringExtensions-ToMemoryStream-System-String-'></a>
### ToMemoryStream(data) `method`

##### Summary

Converts a string to a Memory stream, encoding the bytes using UTF-8.

##### Returns

memory stream representing the encoded string.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| data | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | string to be encoded. |

<a name='T-Raccoon-Ninja-Extensions-Common-TimeSpanExtensions'></a>
## TimeSpanExtensions `type`

##### Namespace

Raccoon.Ninja.Extensions.Common

##### Summary

Extension methods for TimeSpan instances

<a name='M-Raccoon-Ninja-Extensions-Common-TimeSpanExtensions-RoundMs-System-TimeSpan-'></a>
### RoundMs(ts) `method`

##### Summary

If the TimeSpan object has milliseconds equal to or greater than 5000000 (half second)
    it will be rounded up. Otherwise, will be rounded down.

##### Returns

rounded TimeSpan object

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| ts | [System.TimeSpan](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.TimeSpan 'System.TimeSpan') | TimeSpan object to be checked |
