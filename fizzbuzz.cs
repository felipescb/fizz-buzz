using System;
using System.Collections.Generic;
using System.Linq;


namespace FizzBuzz
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var numbers = Enumerable.Range (1, 100).ToList ();

			foreach (var num in numbers) {
				if (!string.IsNullOrEmpty(fizzBuzz(num))) {
					Console.WriteLine (fizzBuzz (num));
				}
			}
		}

		private static string fizzBuzz(int num)
		{
			if (num % 3 == 0 && num % 5 == 0) {
				return "FizzBuzz";
			} else if (num % 3 == 0) {
				return "Fizz";
			} else if (num % 5 == 0) {
				return "Buzz";
			} else {
				return string.Empty;
			}
		}
	}
}

