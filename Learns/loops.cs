using System;
namespace LeetCodeInCSharp.Learns
{
	public class LOOPS
	{
		public static void RUN()
		{
			// Console.WriteLine(1);
			// DisplayTeenNumbers();
			int sumOfTeenNumbers = SumOfTeenNumbers();
			// Console.WriteLine(sumOfTeenNumbers);
			int sumOfNumbers = SumOfNumbers(new int[] { 1, 3, 5, 3, 2, 6 });
			Console.WriteLine(sumOfNumbers);
			int[] findOuttennumbersandAverage = findOuttenNumbersSumandAverage();
			Console.WriteLine($"Average:{findOuttennumbersandAverage[1]}\nSum of them:{findOuttennumbersandAverage[0]}");
			int findOutCubeOfN = findOutCubeOfNumber(11);
			Console.WriteLine(findOutCubeOfN);
			// CreateMultiplicationTable(15);
			// CreateMultiplicationTableBy1(8);
			CreateSumOfOddNumberWithinNumbers(10);
			PyramidSpaced(4);
			CreateNumberPyramidInRigthSide(5);
			CreatePyramidInRepeateTimes(4);
			// CreatePyramidInIncreaseOne();
			PyramidSpacedInRealNumbers(4);
			FindOutFoctarial(6);
			FindOutEvenNumbersSum(3);
			Console.WriteLine();
		}
		// 16. Write a program in C# Sharp to display the n terms of even natural number and their sum.
		public static void FindOutEvenNumbersSum(int number)
		{
			int sum=0;
			int num=1;
			while (number >0)
			{
				if (num%2==0)
				{
					sum+=num;
					number--;
					Console.Write($"{num} ");
				}
				num++;
			}
			Console.WriteLine();
			Console.WriteLine(sum);
		}

		// 15. Write a C# Sharp program to calculate the factorial of a given number.
		public static void FindOutFoctarial(int number)
		{
			int count=1;
			for (int i =1;i<=number;i++)
			{
				count*=i;
			}
			Console.WriteLine($"Factarial : {count}");
		}

		// 13. Write a program in C# Sharp to make such a pattern like a pyramid with numbers increasing by 1.

		//    1 
		//   2 3 
		//  4 5 6 
		// 7 8 9 10
		public static void PyramidSpacedInRealNumbers(int rows )
	    {
	    	int l=1;
	        for (int i = 1; i <= rows; i++)
	        {
	            // Markazga joylashtirish uchun bo'sh joy
	            for (int k = 1; k <= rows - i; k++)
	            {
	                Console.Write(" ");
	            }
	            
	            // Symbollar
	            for (int j = 1; j <= i; j++)
	            {
	                Console.Write(l + " ");
	                l++;
	            }
	            Console.WriteLine();
	        }
	    }
		// 14. Write a program in C# Sharp to make such a pattern like a pyramid with an asterisk.

		//    *
		//   * * 
		//  * * *
		// * * * *
		// 12. Write a C# Sharp program to make such a pattern like a right angle triangle with the number increased by 1.
		// The pattern like :

		// 1
		// 2 3
		// 4 5 6
		// 7 8 9 10 
		public static void CreatePyramidInIncreaseOne()
		{	
			int i, j, rows, k = 1;  // Declaration of variables 'i', 'j' for iteration, 'rows' to store the number of rows, 'k' to store and increase the number
			Console.Write("\n\n");  // Displaying new lines
	        Console.Write("Display the pattern like a right-angle triangle with numbers increased by 1:\n");  // Displaying the purpose of the program
	        Console.Write("---------------------------------------------------------------------------");  // Displaying a separator
	        Console.Write("\n\n");

	        Console.Write("Input number of rows : ");  // Prompting the user to input the number of rows
	        rows = Convert.ToInt32(Console.ReadLine());  // Reading the number entered by the user    

	        for (i = 1; i <= rows; i++)  // Loop to iterate through each row
	        {
	            for (j = 1; j <= i; j++)  // Loop to print the incremented value of 'k' in each row 'i' times
	            {
	                Console.Write("{0} ", k++);  // Displaying 'k' and incrementing 'k' by 1 for each iteration
	            }
	            Console.Write("\n");  // Moving to the next line to form the right-angled pattern
	        }

		}
		// 11. Write a program in C# Sharp to make such a pattern like a right angle triangle with a number which repeats a number in a row.
		// The pattern like :

		// 1
		// 22
		// 333
		// 4444
		public static void CreatePyramidInRepeateTimes(int num)
		{
			for (int k =1;k<=num;k++)
			{
				Console.WriteLine(string.Concat(Enumerable.Repeat(k,k)));
			}
		}
		// 10. Write a program in C# Sharp to display a pattern like a right angle triangle with a number.
		// The pattern like :

		// 1
		// 12
		// 123
		// 1234
		public static void CreateNumberPyramidInRigthSide(int rows)
		{	string res="";
			for (int i=1;i<rows+1;i++)
			{
				Console.WriteLine($"{res}{i}");
				res+=$"{i}";
			}
		}
		// 9. Write a program in C# Sharp to display a right angle triangle with an asterisk.
		// The pattern like :

		//    *
		//   * *
		//  * * *
		// * * * *
		public static void PyramidSpaced(int rows, char symbol = '*')
	    {
	        for (int i = 1; i <= rows; i++)
	        {
	            // Markazga joylashtirish uchun bo'sh joy
	            for (int k = 1; k <= rows - i; k++)
	            {
	                Console.Write(" ");
	            }
	            
	            // Symbollar
	            for (int j = 1; j <= i; j++)
	            {
	                Console.Write(symbol + " ");
	            }
	            Console.WriteLine();
	        }
	    }

		// 8. Write a C# Sharp program to display the n terms of odd natural numbers and their sums.
		public static void CreateSumOfOddNumberWithinNumbers(int number)
		{
			int sum=0;
			int first=1;
			while (number > 0)
			{
				if (first % 2 == 1)
				{
					sum += first;
					Console.Write($"{first} ");
					number--;
				}
				first++;
				// Console.WriteLine(sum);
			}
			Console.WriteLine($"Sum of odd numbers:{sum}");
		}

		// 7. Write a program in C# Sharp to display the multiplication table vertically from 1 to n.
		public static void CreateMultiplicationTableBy1(int number)
		{
			for (int i=1;i<number+1;i++)
			{
				Console.Write($"{i}*1={i*1},");
			}
		}
		// 6. Write a program in C# Sharp to display the multiplication table of a given integer
		public static void CreateMultiplicationTable(int number)
		{
			for (int i=1;i<11;i++)
			{
				Console.WriteLine($"{number}*{i}={number*i}");
			}
		}
		// 5. Write a C# Sharp program to display the cube of an integer up to given number
		public static int findOutCubeOfNumber(int number)
		{
			return number*number*number;
		}
		// 4. Write a C# Sharp program to read 10 numbers and find their average and sum
		public static int[] findOuttenNumbersSumandAverage()
		{
			int sum=0;
			int count=0;
			for (int i =1;i<11;i++)
			{
				sum+=i;
				count++;
			}
			return new int[] { sum, sum / count };
		}

		// 3. Write a C# Sharp program that displays the sum of n natural numbers.
		public static int SumOfNumbers(int[] numbers)
		{
			int sum=0;
			foreach(int num in numbers)
			{
				sum+=num;
			}
			return sum;
		}
		// 2. Write a C# Sharp program to find the sum of the first 10 natural numbers.
		public static int SumOfTeenNumbers()
		{
			int sum=0;
			for (int i=1;i<11;i++)
			{
				sum+=i;
			}
			return sum;
		}
		// 1. Write a program in C# Sharp to display the first 10 natural numbers.
		public static void DisplayTeenNumbers()
		{
			for (int i=1;i<11;i++)
			{
				Console.Write(i);
			}
		}
	}
}