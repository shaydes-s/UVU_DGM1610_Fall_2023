using System;
					
public class Program
{
	public void Main()
	{
		//asking for a number and converting to an int
		Console.WriteLine("pick a number");
		string numString = Console.ReadLine();
		int num = Convert.ToInt32(numString);
/*
	the code I got on my own, which only sorta worked
		int i = 1;
		while (i <= num){
			Console.WriteLine(i);
			i++;
		}
		
		for (int p = 0; p < num; p++) {
   			Console.Write(num);
		}*/
		//actual code with nested loop that works
		for (int i = 1; i <= num; i++){
			for (int j = 1; j <= i; j++){
			Console.Write(i);
			}
		Console.WriteLine();
		}
	}
}