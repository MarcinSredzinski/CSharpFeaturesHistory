// See https://aka.ms/new-console-template for more information
using CSharp11Features;

Console.WriteLine("Hello, World!");

IExample clasicAttributes = new ClassicAttributesExample();
clasicAttributes.Execute();
IExample genericAttributes = new GenericAttributesExample();
genericAttributes.Execute();

