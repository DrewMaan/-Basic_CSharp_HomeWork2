using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.NumberOfDigits
{
	class Program
	{
		/*
		 
		 * Написать метод подсчета количества цифр числа.
		 * 
		 * Выполнил: Касимовский Андрей
		 
		*/
		static void Main(string[] args)
		{
			Console.WriteLine("Enter long number: ");
			long number = long.Parse(Console.ReadLine());

			NumberOfDigits(number);

			Console.ReadKey();
		}

		static void NumberOfDigits(long num)
		{
			int count = 0;

			do
			{
				num /= 10;
				count++;
			} while (num != 0);

			Console.WriteLine($"Numbers of digits your number: {count}");
		}
	}
}
