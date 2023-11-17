// See https://aka.ms/new-console-template for more information

using DIExample;

Console.WriteLine("Transient vs Singleton vs Scope");

var scope1 = new Scope();
var scope2 = new Scope();

var sample1A = scope1.TransientProvider.GetSample();
var sample1B = scope1.TransientProvider.GetSample();
var sample2A = scope2.TransientProvider.GetSample();
var sample2B = scope2.TransientProvider.GetSample();


Console.WriteLine(sample1A.Id);
Console.WriteLine(sample1B.Id);
Console.WriteLine(sample2A.Id);
Console.WriteLine(sample2B.Id);