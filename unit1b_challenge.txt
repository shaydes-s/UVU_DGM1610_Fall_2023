using System;
					
public class Program
{
	public void Main()
	{
		//challenge 1, asking the user what the temperature is, and converting into a double
		Console.WriteLine("What is the current degree in celcius?");
		double temp = Convert.ToDouble(Console.ReadLine());
		
			//measuring where the temperature places and printing a corrosponding message
	if ( temp > 45 ){
		Console.WriteLine ("stay indoors! you may be living on the sun !");
	}
	else if (temp > 30 ){
		Console.WriteLine ("make sure to stay hydrated and avoid being in the sun too long");
	}
	else if ( temp == 23 ){
		Console.WriteLine ("that is room temperature! how pleasant");
	}
	else if ( temp == 0 ){
		Console.WriteLine ("it is freezing! maybe you will see snow!");
	}
	else if ( temp > 10 ){
		Console.WriteLine("the weather seems nice");
	}
	else if ( temp < 0 ){
		Console.WriteLine("it is cold outside! please wear a coat!");
	}
	else if ( temp < 10 ){
		Console.WriteLine ("it might be a bit chilly, probably bring a jacket");
	} 
	//This actually came in handy, I put in a number I accidentally didn't include before and got the "else" result. good for letting me know what more I needed
	else {
		Console.WriteLine("how did you even get this result?");
	}
	//challenge 2, getting input score and asking for a subject
		Console.WriteLine ("what is your selected subject?");
		string subject = Console.ReadLine();
		Console.WriteLine("input your test score");
		//converting to an int
		int score = Convert.ToInt32(Console.ReadLine());
		//switch statements deciding what message to print based on subject
		switch (subject){
			case "math":
				Console.WriteLine("Math is all about rules and formulas, if you can remember them, you're golden!");
				break;
			case "english":
				Console.WriteLine("English has a lot of elements that go into it, keep in mind your 5 paragraph essay structure");
				break;
			case "science":
				Console.WriteLine("Science is a tough subject, be sure to take very good notes!");
				break;
			case "art":
				Console.WriteLine("Art is a great class to let your creativity run wild");
				break;
			default:
				Console.WriteLine("I only wrote in math, english, science, and art. Please choose one of those");
				break;
		}
		//measuring the score to the boundaries for the grades
		if ( score >= 90 ){
			Console.WriteLine("You got an A. Great Job!");
		}
		else if (score >= 80){
			Console.WriteLine("You got a B. That is pretty good");
		}
		else if (score >= 70){
			Console.WriteLine("You got a C. Nice try, maybe study more next time");
		}
		else if (score < 69){
			Console.WriteLine("You got an F... Be sure to retry!");
		}
		//I dont think I can even get this result, but I think it is good to have a "just in case" option if they somehow find something that I couldn't
		else
			Console.WriteLine("Please enter a valid score");
	}
}