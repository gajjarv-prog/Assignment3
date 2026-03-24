using System;
class Program
{
	static void Main(string[] args)
	{
		// Create a person with no name
		Person bob = new Person();
		Console.WriteLine(bob.IsValidated()); // Output: false

		// Create a person with valid names
		Person kim = new Person("kim", "smith");
		Console.WriteLine(kim.IsValidated()); // Output: true
	}
}