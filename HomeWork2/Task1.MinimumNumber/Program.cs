using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.MinimumNumber
{
	class Program
	{
		/*
		 
		 * Написать метод, возвращающий минимальное из трех чисел.
		 * 
		 * Выполнил: Касимовский Андрей
		 
		*/
		static void Main(string[] args)
		{
			Console.WriteLine("Enter first number: ");
			int firstNumber = int.Parse(Console.ReadLine());

			Console.WriteLine("Enter second number: ");
			int secondNumber = int.Parse(Console.ReadLine());

			Console.WriteLine("Enter third number: ");
			int thirdNumber = int.Parse(Console.ReadLine());

			Minimum(firstNumber, secondNumber, thirdNumber);

			Console.ReadKey();
		}

		static void Minimum(int first, int second, int third)
		{
			int minimum = 0;
			
			if(first < second)
			{
				if (first < third) minimum = first;
				else minimum = third;
			}
			else
			{
				if (second < third) minimum = second;
				else minimum = third;
			}

			Console.WriteLine($"Minimum number: {minimum}");
		}
	}
}
