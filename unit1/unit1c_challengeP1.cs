using System;
					
public class Program {
	public void Main() {
		//have user input number
		Console.WriteLine("guess the random number!");
		int guessNum = Convert.ToInt32(Console.ReadLine());
		
		// Select random number between 1-10
		Random random = new Random();
		int num = random.Next(1, 10);
		//different attempt in getting a random number to try and fix the random number switching between guesses, didn't work
		/*int[] numList = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
		var num = random.Next(0, 9);*/
		
		Console.WriteLine(num);// first guess. comparing the input number to the chosen random number and printing a related message

		if (guessNum > num){
			Console.WriteLine("too high, try again");
			Console.WriteLine(num);
		}
		else if (guessNum == num){
			Console.WriteLine("you did it! First try too");
		}
		else{
			Console.WriteLine("too low, try again");
			Console.WriteLine(num);
		}
		//if they fail the first guess then this loop starts, same code as before
		for (int i = 2; guessNum!= num; i++){
			int newGuess = Convert.ToInt32(Console.ReadLine());
			if (newGuess > num){
				Console.WriteLine("too high, try again");
				Console.WriteLine(num);
			}
			else if (newGuess == num){
				Console.WriteLine("you did it! good job");
				Console.WriteLine("it took you " + (i) + " tries");
			}
			else{
				Console.WriteLine("too low, try again");
				Console.WriteLine(num);
			}
		}
	}
}