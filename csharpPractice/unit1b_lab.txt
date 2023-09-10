using System;
					
public class Program
{
	public void Main()
	{
		//challenge 1, asking the user what the temperature is, and converting into a double
		Console.WriteLine("What is the current degree in celcius?");
		double temp = Convert.ToDouble(Console.ReadLine());
		
			//measuring whether the temperature is above or below 30 and printing a message based on the result
	if ( temp > 30 ){
		Console.WriteLine ("make sure to stay hydrated and avoid being in the sun too long");
	}
	else {
		Console.WriteLine("enjoy the pleasant weather");
	}
	//challenge 2, getting input score
		Console.WriteLine("input your test score");
		int score = Convert.ToInt32(Console.ReadLine());
		//measuring the score to the boundaries for the grades
		if ( score >= 90 ){
			Console.WriteLine("You got an A. Good Job");
		}
		else if (score >= 80){
			Console.WriteLine("You got a B. That is pretty good");
		}
		else if (score >= 70){
			Console.WriteLine("You got a C. Nice try, maybe study more next time");
		}
		else if (score < 69){
			Console.WriteLine("You got an F. Be sure to retry");
		}
		//I dont think I can even get this result, but I think it is good to have a "just in case" option if they somehow find something that I couldn't
		else
			Console.WriteLine("Please enter a valid score");
	}
}