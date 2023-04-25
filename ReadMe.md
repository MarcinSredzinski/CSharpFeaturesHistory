# What 's new in C#

## [C# 11](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-11)
- [Raw string literals](/CSharp11Features/RawStringLiteralsExample.cs)
- [Generic math support](/CSharp11Features/GenericMathSupportExample.cs)
- [Static virtual memebers in interfaces](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/tutorials/static-virtual-interface-members)
- [Generic attributes](/CSharp11Features/GenericAttributesExample.cs) 
- [UTF-8 string literals](/CSharp11Features/Utf8StringLiteralsExample.cs)
- [Newlines in string interpolation expressions](/CSharp11Features/NewLinesInStringInterpolationExample.cs)
- [List patterns](/CSharp11Features/ListPatternsExample.cs) 
- [File-local types](/CSharp11Features/FileScopedTypes/FileScopedTypesExample.cs) - potentially faster source generation - source generator doesn't need to search for unused names, can just use "file" keyword
- [Required members](/CSharp11Features/RequiredMembersExample.cs)
- [Auto-default structs](/CSharp11Features/AutoDefaultStructExample.cs)
- [Pattern match Span<char> on a constant string](/CSharp11Features/PatternMatchSpanExample.cs)
- [Extended nameof scope](/CSharp11Features/ExtendedNameOfExample.cs)
- [Numeric IntPtr](/CSharp11Features/NumericIntPointerExample.cs)
- [ref fields and scoped ref](/CSharp11Features/RefFieldsAndScopedRefExample.cs)
- [Improved method group conversion to delegate](/CSharp11Features/ImprovedMethodGroupConversionToDelegate.cs)


## [C# 10](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-10)
- [Global usings](/CSharp10Features/GlobalUsings.cs)
- [File Scoped Namespaces](/CSharp10Features/FileScopedNamespaces.cs)
- [Constant Interpolated strings](/CSharp10Features/ConstantInterpolatedStrings.cs)
- [Lambda improvements](/CSharp10Features/LambdaImprovements.cs)
- [Extended property patterns](/CSharp10Features/ExtendedPropertyPatterns.cs)
- [Record structs](/CSharp10Features/RecordStructsExample.cs)
- [Records seal ToString()](/CSharp10Features/RecordTypeSealToString.cs)  
- [Improvements of structure types](/CSharp10Features/ImprovementsOfStructureTypes.cs)  
- [Allow both assignment and declaration in the same deconstruction](/CSharp10Features/AssignmentAndDeclarationInTheSameDeconstruction.cs)  
- [Interpolated string handlers](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/tokens/interpolated#compilation-of-interpolated-strings)
- [Improved definite assignment](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-10#improved-definite-assignment) - more accurate warnings for definite assignment, e.g.: 
> string representation = "N/A";  
if ((c != null && c.GetDependentValue(out object obj)) == true)  
{  
   representation = obj.ToString(); // undesired error  
}  
- [Allow AsyncMethodBuilder attribute on methods](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-10#allow-asyncmethodbuilder-attribute-on-methods) - Read about it more later on, [code example](https://gist.github.com/Horusiath/401ed16563dd442980de681d384f25b9)

  
## [C# 9.0](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-9)  
- [Top-level statements](/CSharp9Features/Program.cs) - remove all the unnecessary clutter from the applications, see [Top level statements](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-9#top-level-statements), 
- [Init setters](/CSharp9Features/InitSettersExample.cs)
- [Known Object Type Shorthand Instantation](/CSharp9Features/KnownObjectTypeShorthandInstantation.cs)
