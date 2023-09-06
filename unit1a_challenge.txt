using System;
					
public class Program
{
	public static void Main()
	{
		//a bunch of variables of different types
		int varOne = 2;
		int varTwo = 3;
		bool falseBestie = varOne >= varTwo;
		//including input variables
		Console.WriteLine("Choose 2 names");
		string nameOne = Console.ReadLine();
		string nameTwo = Console.ReadLine();
		
		//start using the math variables
		Console.WriteLine("what is " + varOne + " x " + varTwo + "?");
		int varProduct = (varOne*varTwo);
		Console.WriteLine(varProduct);
		Console.WriteLine("what is " + varProduct + " x " + varOne + "?");
		Console.WriteLine(varProduct*varOne);
		//using the boolean
		Console.WriteLine(varOne + " is bigger than " + varTwo);
		Console.WriteLine(falseBestie);
		
		//using the input variables
		Console.WriteLine(nameOne + " says hi.");
		Console.WriteLine(nameTwo + " says hi back.");
	}
}