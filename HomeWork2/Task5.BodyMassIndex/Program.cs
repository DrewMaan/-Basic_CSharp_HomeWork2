using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5.BodyMassIndex
{
	class Program
	{
		/*
		 
		 * а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, 
		 * нужно ли человеку похудеть, набрать вес или все в норме;
		 * б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
		 
		 * Выполнил: Касимовский Андрей
		 
		*/
		static void Main(string[] args)
		{
			Console.WriteLine("Hello! Let's calculate your body mass index.");

			//Enter height
			Console.Write("Enter your height (in metres): ");
			var userHeight = Convert.ToDouble(Console.ReadLine());

			//Enter weight
			Console.Write("Enter your weight: ");
			var userWeight = Convert.ToDouble(Console.ReadLine());

			BodyMassIndex(userHeight, userWeight);

			Console.ReadKey();
		}

		static void BodyMassIndex(double height, double weight)
		{ 
			var bmi = weight / (height * height);
			if (bmi < 18.5)
			{
				Console.WriteLine("A: Your base mass index: {0:F2}. You need to gain weight!", bmi);
				var normalyWeight = 18.5 * (height * height);
				Console.WriteLine("B: To have a normal weight you need to gain {0:F2} kg.", normalyWeight - weight);
			}
			else if (bmi > 25)
			{
				Console.WriteLine("A: Your base mass index: {0:F2}. You need to lose weight!", bmi);
				var normalyWeight = 25 * (height * height);
				Console.WriteLine("B: To have a normal weight you need to lose {0:F2} kg.", weight - normalyWeight);
			}
			else Console.WriteLine("A: Your base mass index: {0:F2}. You have normaly weight!", bmi);
		}
	}
}
