using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4.CheckLoginAndPassword
{
	class Program
	{
		/*
		 
		 * Реализовать метод проверки логина и пароля. 
		 * На вход подается логин и пароль. 
		 * На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). 
		 * Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль,
		 * программа пропускает его дальше или не пропускает. 
		 * С помощью цикла do while ограничить ввод пароля тремя попытками.
		 
		 * Выполнил: Касимовский Андрей
		 
		*/
		static void Main(string[] args)
		{
			int tryCount = 0;
			bool check = false;

			do
			{
				check = CheckLoginAndPassword();

				if (check)
				{
					Console.WriteLine("Correctly");
					break;
				}
				else
					Console.WriteLine("Wrong login or password");
				tryCount++;
			} while (tryCount < 3);

			Console.WriteLine(check ? "Welcome! You Entered!" : "You've used every attempt");

			Console.ReadKey();
		}

		static bool CheckLoginAndPassword()
		{
			string l = "root";
			string p = "GeekBrains";

			Console.WriteLine("Enter login: ");
			string login = Console.ReadLine();

			Console.WriteLine("Enter password: ");
			string password = Console.ReadLine();

			if (login.Equals(l) && password.Equals(p)) return true;
			else return false;
		}
	}
}
