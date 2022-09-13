// See https://aka.ms/new-console-template for more information
using ConceptsPOO;

Console.WriteLine("POO CONCEPTS");
Console.WriteLine("============");
try
{
	Console.WriteLine(new Date(2024, 2, 29));
	Console.WriteLine(new Date(1974, 9, 23));
	Console.WriteLine(new Date(1985, 11, 5));
}
catch (Exception ex)
{

	Console.WriteLine(ex.Message);
}