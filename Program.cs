// See https://aka.ms/new-console-template for more information
using ConsoleApp1;
using ExampleNameSpace;

Console.WriteLine("Hello, World!");
var docReader = new DocumentReader();

//Exmaple of Document reader awiat function
await docReader.RetrieveDocsHomePage();

//Exmaple of Delegate
DelegateExample.MethodCall();
