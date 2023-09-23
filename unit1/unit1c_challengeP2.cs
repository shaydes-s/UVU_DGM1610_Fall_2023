using System;
					
public class Program
{
	public void Main()
	{
		//ask for 3 favorite foods, put into array
		Console.WriteLine("what are your 3 favorite foods");
		string food1 = Console.ReadLine();
		string food2 = Console.ReadLine();
		string food3 = Console.ReadLine();
		string[] favoriteFoods = {food1, food2, food3};
		
		//loop and write all items in array
		foreach(var food in favoriteFoods){
			Console.WriteLine("you love to eat " + food + ", me too!");
		}
	}
}