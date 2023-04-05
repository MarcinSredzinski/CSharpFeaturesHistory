// See https://aka.ms/new-console-template for more information
using CSharp11Features;
using System.Text;

Console.WriteLine("Hello, World!");

IExample clasicAttributes = new ClassicAttributesExample();
clasicAttributes.Execute();
IExample genericAttributes = new GenericAttributesExample();
genericAttributes.Execute();

IExample rawStringLiterals = new RawStringLiteralsExample();
rawStringLiterals.Execute();

IExample listPatternsExample = new ListPatternsExample();
listPatternsExample.Execute();

IExample utf8StringLiteralsExample = new Utf8StringLiteralsExample();
utf8StringLiteralsExample.Execute();