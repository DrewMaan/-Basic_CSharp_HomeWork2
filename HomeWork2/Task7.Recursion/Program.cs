using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7.Recursion
{
	class Program
	{
		/*
		 
		 * a) Разработать рекурсивный метод, который выводит на экран числа от a до b (a<b)
		 * б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.
		 * 
		 * Выполнил: Касимовский Андрей
		 
		*/
		static void Main(string[] args)
		{
			Console.Write("Enter first number: ");
			var number1 = Convert.ToInt32(Console.ReadLine());
			Console.Write("Enter second number: ");
			var number2 = Convert.ToInt32(Console.ReadLine());
			Print(number1, number2);
			Console.WriteLine(Sum(number1, number2));
			Console.ReadKey();
		}

		static void Print(int a, int b)
		{
			Console.Write(a + " ");
			if (a < b) Print(a + 1, b);
			else Console.WriteLine();
		}

		static int Sum(int a, int b)
		{
			if (a != b) return a + Sum(a + 1, b);
			else return b;
		}
	}
}
