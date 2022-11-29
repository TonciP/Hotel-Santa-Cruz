// See https://aka.ms/new-console-template for more information
using ShareKernel.ValueObjects;

DniValue value1 = new DniValue("123");
DniValue value2 = new DniValue("123");
Console.WriteLine(value1 == value2);
Console.ReadLine();