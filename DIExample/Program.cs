// See https://aka.ms/new-console-template for more information

using DIExample;

Console.WriteLine("Transient vs Singleton vs Scope");

var scope1 = new Scope();
var scope2 = new Scope();

var sample1A = scope1.SingletonProvider.GetSample();
var sample1B = scope1.SingletonProvider.GetSample();
var sample2A = scope2.SingletonProvider.GetSample();
var sample2B = scope2.SingletonProvider.GetSample();


Console.WriteLine(sample1A.Id);
Console.WriteLine(sample1B.Id);
Console.WriteLine(sample2A.Id);
Console.WriteLine(sample2B.Id);