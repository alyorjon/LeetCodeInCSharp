using System;
namespace LeetCodeInCSharp.Learns
{

	public class Conditions
	{
		public static void Run()
		{
			Console.WriteLine(1);
			// Excerice1();	
			// Excerice2();	
			// Excerice3();			
			// Excerice4();
		}
		// 4. Write a C# Sharp program to find out whether a given year is a leap year or not.
		// Test Data : 2016
		// Expected Output :
		// 2016 is a leap year.
		public static void Excerice4()
		{
			Console.WriteLine("Input number:");
			// string? str=Console.ReadLine();
			// int num=int.Parse(str);
			// if (num%4==0)
			// {
			// 	Console.WriteLine($"{num} is leap year.");
			// }
			// else
			// {
			// 	Console.WriteLine($"{num} is not leap year.");
			// }
		}
		// 3. Write a C# Sharp program to check whether a given number is positive or negative.
		// Test Data : 14
		// Expected Output :
		// 14 is a positive number
		public static void Excerice3()
		{
			Console.WriteLine("Input Number:");
			// string? str=Console.ReadLine();
			// int num=int.Parse(str);
			// if (num>0)
			// {
			// 	Console.WriteLine($"{num} is positive number.");

			// }
			// else
			// {
			// 	Console.WriteLine($"{num} is negative number.");
			// }
		}
		// 2. Write a C# Sharp program to check whether a given number is even or odd.
		// Test Data : 15
		// Expected Output :
		// 15 is an odd integer
		public static void Excerice2()
		{
			Console.WriteLine("Input number:");
			// string? str=Console.ReadLine();
			// int num=int.Parse(str);
			// if (num%2==0)
			// {
			// 	Console.WriteLine($"{num} is even");
			// }
			// else 
			// {
			// 	Console.WriteLine($"{num} is odd");
			// }
		}
		// 1. Write a C# Sharp program to accept two integers and check whether they are equal or not.
		// Test Data :
		// Input 1st number: 5
		// Input 2nd number: 5
		public static void Excerice1()
		{
			Console.Write("Input 1st number:");
			string? str1 = Console.ReadLine();
			if (string.IsNullOrEmpty(str1))
			{
				Console.WriteLine("Invalid input for 1st number.");
				return;
			}
			int num1 = int.Parse(str1);

			Console.Write("Input 2nd number:");
			string? str2 = Console.ReadLine();
			if (string.IsNullOrEmpty(str2))
			{
				Console.WriteLine("Invalid input for 2nd number.");
				return;
			}
			int num2 = int.Parse(str2);

			Console.WriteLine($"{num1} {num2}");
			if (num1==num2)
			{
				Console.WriteLine("They are equal.");
			}
			else 
			{
				Console.WriteLine("They are not equal.");
			}
		}
	}

}