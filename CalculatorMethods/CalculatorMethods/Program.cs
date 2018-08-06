using System;

namespace CalculatorMethods
{
    class Program
    {
	   static void Main(string[] args)
        {
			bool playAgain = true;

			while (playAgain)
			{
				Console.Clear();
				Console.WriteLine("A Simple Calculator");
				Console.WriteLine("Please input two numbers: ");

				double num1 = Convert.ToDouble(Console.ReadLine()); //the user's first number will be converted to double and stored in num1
				double num2 = Convert.ToDouble(Console.ReadLine()); //the user's second number will be converted to double and stored in num2

				Console.Write("Do want to add, subtract, multiply, or divide these numbers?");
				string response = Console.ReadLine(); //the user's math selection will be stored in response

				double total = 0;

				if (response == "add" || response == "+")
				{
					total = Add(num1, num2); //two numbers are passed into the Add method and then the result is stored in total
				}
				else if (response == "subtract" || response == "-")
				{
					total = Subtract(num1, num2); //two numbers are passed into Subtract method and then the result is stored in total
				}
				else if (response == "multiply" || response == "*")
				{
					total = Multiply(num1, num2); //two numbers passed into Multiply method, the returned result is stored in total
				}
				else if (response == "divide" || response == "/")
				{
					total = Divide(num1, num2); //two numbers are passed into Divide method, returned result is stored in total
				}
				else
				{ //any other responses will output below

					Console.WriteLine("Please try again. We don't understand your response.");
					Console.ReadLine();
					Environment.Exit(0); //closes the application
				}

				Console.WriteLine($"The answer is {total}.");
				Console.WriteLine("\nDo you want to play again?");
				string answer = Console.ReadLine();
				if (answer == "yes")
				{
					playAgain = true;
				}
				else
					playAgain = false;
			}
			

		}



		/// <summary>
		/// A method that adds two parameters and returns a total
		/// </summary>
		/// <param name="num1"></param>
		/// <param name="num2"></param>
		/// <returns>total</returns>
		private static double Add(double num1, double num2){ 
			double total = num1 + num2;
			return total;
		}

		/// <summary>
		/// A method that subtracts two parameters and returns the remainder
		/// </summary>
		/// <param name="num1"></param>
		/// <param name="num2"></param>
		/// <returns>total</returns>
		private static double Subtract(double num1, double num2){
			double total = num1 - num2;
			return total;
		}

		/// <summary>
		/// A method that divides two parameters and returns the quotient
		/// </summary>
		/// <param name="num1"></param>
		/// <param name="num2"></param>
		/// <returns>total</returns>
		private static double Divide(double num1, double num2){
			double total = num1 / num2;
			return total;
		}

		/// <summary>
		/// A method that multiplies two parameters and returns the product
		/// </summary>
		/// <param name="num1"></param>
		/// <param name="num2"></param>
		/// <returns>total</returns>
		private static double Multiply(double num1, double num2){
			double total = num1 * num2;
			return total;
		}
    }
}
