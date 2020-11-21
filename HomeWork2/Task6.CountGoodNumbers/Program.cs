using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6.CountGoodNumbers
{
	class Program
	{
		/*
		 
		 * *Написать программу подсчета количества «Хороших» чисел в диапазоне от 1 до 1 000 000 000. 
		 * Хорошим называется число, которое делится на сумму своих цифр. 
		 * Реализовать подсчет времени выполнения программы, используя структуру DateTime.
		 * 
		 * Выполнил: Касимовский Андрей
		 
		*/
		static void Main(string[] args)
		{
			int startTime = DateTime.Now.Hour * 3600 + DateTime.Now.Minute * 60 + DateTime.Now.Second;

			var countsGoodNumbers = CalculateCountGoodNumbers(1, 1000000000);
			int endTime = DateTime.Now.Hour * 3600 + DateTime.Now.Minute * 60 + DateTime.Now.Second;
			int time = endTime - startTime;

			Console.WriteLine("Count good numbers from {0} to {1}: {2}.", 1, 1000000000, countsGoodNumbers);
			Console.WriteLine($"Time execute program: {time / 3600} hours, " +
				$"{(time % 3600)/60} minute, {(time % 3600) % 60} second.");

			Console.ReadKey();
		}

		static long CalculateCountGoodNumbers(long startNumber, long endNumber)
		{
			var count = 0;
			for(long i = startNumber; i <= endNumber; i++)
			{
				var sumDigits = 0;
				var number = i;
				while (number != 0)
				{
					sumDigits += (int)(number % 10);
					number /= 10;
				}
				count += (i % sumDigits) == 0 ? 1 : 0;
			}

			return count;
		}
	}
}
