using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.SumOfOddPositiveNumbers
{
	class Program
	{
		/*
		 
		 * С клавиатуры вводятся числа, пока не будет введен 0. 
		 * Подсчитать сумму всех нечетных положительных чисел.
		 * 
		 * Выполнил: Касимовский Андрей
		 
		*/
		static void Main(string[] args)
		{
			int number;
			int sum = 0;

			Console.WriteLine("Enter number (enter 0 for quit): ");
			number = int.Parse(Console.ReadLine());

			while(number != 0)
			{
				if(number % 2 != 0 && number > 0) sum += number;

				Console.WriteLine("Enter number (enter 0 for quit): ");
				number = int.Parse(Console.ReadLine());
			}

			Console.WriteLine($"Sum of odd positive numbers: {sum}");

			Console.ReadKey();
		}
	}
}
