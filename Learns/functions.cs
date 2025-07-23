using System;
namespace LeetCodeInCSharp.Learns
{
	public class Functions
	{
		public static void Run()
		{
			Console.WriteLine("Function file is running.");
			// Console.WriteLine("Please input a name: ");
			// string name=Console.ReadLine();
			// WelcomeFunction(name);
			// Console.WriteLine("Enter a number: ");
			// string number1=Console.ReadLine();
			// Console.WriteLine("Enter another number: ");
			// string number2=Console.ReadLine();
			// if (int.TryParse(number1, out int num1) && int.TryParse(number2, out int num2))
		    //       {
		    //           SumOfTwoNumbers(num1, num2);
		    //       }
		    //       else
		    //       {
		    //           Console.WriteLine("Format is wrong");
		    //       }
			// CalculateSumOfArrays();
			CalculateFactarialOfNumbers();
	    }
	    // 11. Write a program in C# Sharp to create a recursive function to find the factorial of a given number.
		// Test Data :
		// Enter a number: 5
		// Expected Output :
		// The factorial of 5! is 120
	    public static void CalculateFactarialOfNumbers()
	    {
	    	Console.WriteLine("Input a number: ");
	    	string num=Console.ReadLine();
	    	int factorial=1;
	    	if (int.TryParse(num,out int num1))
	    	{	
	    		
	    		for (int i=1;i<num1+1;i++)
	    		{
	    			factorial *=i;
	    		
	    		}
	    		Console.WriteLine($"The factorial of {num1}! is {factorial}.");
	    	}
	    	

	    }


	    // 5. Write a program in C# Sharp to calculate the sum of elements in an array.
		// Test Data :
		// Input 5 elements in the array :
		// element - 0 : 5
		// element - 1 : 7
		// element - 2 : 3
		// element - 3 : 2
		// element - 4 : 9
		// Expected Output :
		// The sum of the elements of the array is 26

	    public static void CalculateSumOfArrays()
	    {
	    	int[] arr={2,4,5,2,5,6};
	    	int sum=0;
	    	for(int i=0;i<arr.Length;i++)
	    	{
	    		sum+=arr[i];
	    		Console.WriteLine($"element-{i}={arr[i]}");
	    	}
	    	Console.WriteLine($"The sum of the elements of the array is {sum}");
	    }

		// 3. Write a program in C# Sharp to create a function for the sum of two numbers.
		// Test Data :
		// Enter a number: 15
		// Enter another number: 16
		// Expected Output :
		// The sum of two numbers is : 31
		public static void SumOfTwoNumbers(int num1,int num2)
		{
			Console.WriteLine($"The sum of two numbers is {num1+num2}");
		}
		// 2. Write a program in C# Sharp to create a user defined function with parameters.
		// Test Data :
		// Please input a name : John
		// Expected Output :
		// Welcome friend John !
		// Have a nice day!
		public static void WelcomeFunction(String name)
		{
			Console.WriteLine($"Welcome friend {name}");
			Console.WriteLine("Have a nice day!");
		}
	}
}