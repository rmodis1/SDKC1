using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Calculator
{
	public class Numbers
	{
		public static void ErrorMessage()
		{
         Console.WriteLine("One or more of the numbers is not an integer. Please try again.");
		}

		public static string[] PickNumbers()
		{
			string[] chosenNumbers = new string[2];
			chosenNumbers[0] = Console.ReadLine();
			chosenNumbers[1] = Console.ReadLine();
			return chosenNumbers;
		}
	}
}

