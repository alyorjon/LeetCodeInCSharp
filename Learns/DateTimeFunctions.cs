using System;
namespace LeetCodeInCSharp.Learns
{
	public class DateTimeFunctions
	{
		public static void Run()
		{
			Console.WriteLine("DatetimeFunctions is running");
			// Formats();
			// FormatsByOne();
			// FindOutDayOfWeek();
			// FormatCurrentTime(); 
			// Problem1_CurrentDateTime();
			// Problem2_AgeCalculator();
			// Problem3_DateDifference();
			Problem6_NextBusinessDay();
			
		}
		
		// Problem 6: Keyingi ish kunini topish
		static void Problem6_NextBusinessDay()
		{
			Console.WriteLine("\n--- Problem 6: Keyingi ish kuni ---");
			Console.WriteLine("Masala: Berilgan sanadan keyingi ish kunini toping (Dam olish kunlarini hisobga olmang)");
			
			DateTime startDate = DateTime.Today;
			
			Console.WriteLine("YECHIM:");
			Console.WriteLine($"Bugungi sana: {startDate.ToShortDateString()} ({startDate.DayOfWeek})");
			
			DateTime nextBusinessDay = GetNextBusinessDay(startDate);
			Console.WriteLine($"Keyingi ish kuni: {nextBusinessDay.ToShortDateString()} ({nextBusinessDay.DayOfWeek})");
			
			// Keyingi 5 ta ish kunini ko'rsatish
			Console.WriteLine("\nKeyingi 5 ta ish kuni:");
			DateTime current = startDate;
			for (int i = 0; i < 5; i++)
			{
				current = GetNextBusinessDay(current);
				Console.WriteLine($"{i + 1}. {current.ToShortDateString()} ({current.DayOfWeek})");
			}
		}
		
		static DateTime GetNextBusinessDay(DateTime date)
		{
			do
			{
				date = date.AddDays(1);
			} while (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday);
			
			return date;
		}
		// Problem 3: Ikki sana orasidagi farqni topish
		static void Problem3_DateDifference()
		{
			Console.WriteLine("\n--- Problem 3: Sana farqi ---");
			Console.WriteLine("Masala: Ikki sana orasidagi farqni yil, oy, kun ko'rinishida hisoblang");

			DateTime startDate = new DateTime(2020, 3, 15);
			DateTime endDate = new DateTime(2024, 7, 23);

			Console.WriteLine("YECHIM:");
			Console.WriteLine($"Boshlang'ich sana: {startDate.ToShortDateString()}");
			Console.WriteLine($"Tugash sanasi: {endDate.ToShortDateString()}");

			// Aniq farqni hisoblash
			var difference = endDate - startDate;
			Console.WriteLine($"Umumiy farq: {difference.TotalDays:F0} kun");

			// Yil, oy, kun ko'rinishida
			int years = endDate.Year - startDate.Year;
			int months = endDate.Month - startDate.Month;
			int days = endDate.Day - startDate.Day;

			if (days < 0)
			{
				months--;
				days += DateTime.DaysInMonth(startDate.Year, startDate.Month);
			}

			if (months < 0)
			{
				years--;
				months += 12;
			}

			Console.WriteLine($"Aniq farq: {years} yil, {months} oy, {days} kun");
		}
		// // Problem 2: Tug'ilgan kun va yoshni hisoblash
		static void Problem2_AgeCalculator()
		{
			Console.WriteLine("\n--- Problem 2: Yosh hisoblagich ---");
			Console.WriteLine("Masala: Tug'ilgan sanaga ko'ra aniq yoshni hisoblang");

			// Test ma'lumoti
			DateTime birthDate = new DateTime(1995, 10, 15);
			DateTime today = DateTime.Today;
			Console.WriteLine(today);
			int age = today.Year - birthDate.Year;
			Console.WriteLine(birthDate.AddYears(age));
			if (today < birthDate.AddYears(age))
			{
				age--;
			}
			Console.WriteLine(age);

		}
		// Problem 1: Bugungi sana va vaqtni turli formatlarda ko'rsatish
			static void Problem1_CurrentDateTime()
			{
				Console.WriteLine("\n--- Problem 1: Bugungi sana va vaqt ---");
				Console.WriteLine("Masala: Bugungi sana va vaqtni 5 xil formatda chiqaring");

				DateTime now = DateTime.Now;
				Console.WriteLine($"Standart formatda: {now}");
				Console.WriteLine($"Qisqa format : {now.ToShortDateString()}");
				Console.WriteLine($"Uzun formati: {now.ToLongDateString()}");
				Console.WriteLine($"Uzun formati: {now.ToLongTimeString()}");
			}
		// 8. Write a C# Sharp program to retrieve the current date.

		// Expected Output :

		// General format 8/20/2016 12:00:00 AM                                    
		// Display the date in a variety of formats:                               
		// 8/20/2016                                                               
		// Saturday, August 20, 2016                                               
		// 8/20/2016 12:00 AM 
		public static void FormatCurrentTime()
		{
			DateTime dt1 = new DateTime(2025, 7, 23, 12, 12, 44);
			Console.WriteLine($"General format {dt1.ToString("MM/dd/yyyy HH:mm:ss")}");
			Console.WriteLine(dt1.ToString("d")); // Short date format
			Console.WriteLine(dt1.ToString("D")); // Long date format
			Console.WriteLine(dt1.ToString("g")); // General date and time format
		}			
		// 3. Write a C# Sharp program to get the day of the week for a specified date.

		// Expected Output :

		// The day of the week for 7/11/2016 is Monday. 
		public static void FindOutDayOfWeek()
		{
			DateTime dt1=new DateTime(2025,7,23);
			Console.WriteLine($"The day of the week for {dt1.ToString("yyyy/MM/dd")} is {dt1.DayOfWeek}");
		}
		// 2. Write a C# Sharp program to display the Day properties (year, month, day, hour, minute, second, millisecond etc.).
		// Expected Output :
		// year = 2016                                                                      
		// month = 8                                                                        
		// day = 16                                                                         
		// hour = 3                                                                         
		// minute = 57                                                                      
		// second = 32                                                                      
		// millisecond = 11
		public static void FormatsByOne()
		{
			DateTime dt1=new DateTime(2025,7,22,12,45,45);
			Console.WriteLine($"Year = {dt1.ToString("yyyy")}");
			Console.WriteLine($"month = {dt1.ToString("MM")}");
			Console.WriteLine($"day = {dt1.ToString("dd")}");
			Console.WriteLine($"hour = {dt1.ToString("HH")}");
			Console.WriteLine($"minute = {dt1.ToString("mm")}");
			Console.WriteLine($"second = {dt1.ToString("ss")}");
			Console.WriteLine($"millisecond = {dt1.Millisecond}");
		}   
		// 1. Write a C# Sharp program to extract the Date property and display the DateTime value in the formatted output.
		// Expected Output:
		// Complete date: 6/8/2016 11:49:00 AM                                              
		// Short Date: 6/8/2016                                                             
		// Display date using 24-hour clock format:                                         
		// 6/8/2016 12:00 AM                                                                
		// 06/08/2016 00:00 
		public static void Formats()
		{
			// Creating a DateTime object with specific date and time values
	        DateTime dt1 = new DateTime(2016, 6, 8, 11, 49, 0);
	        Console.WriteLine("Complete date: " + dt1.ToString()); // Display complete date and time

	        // Get the date portion (without time) from the DateTime object
	        DateTime dateOnly = dt1.Date;

	        // Displaying the date-only portion using "d" format specifier
	        Console.WriteLine("Short Date: " + dateOnly.ToString("d"));

	        // Displaying the date using 24-hour clock format
	        Console.WriteLine("Display date using 24-hour clock format:");

	        // Displaying the date and time in short format using "g" format specifier
	        Console.WriteLine(dateOnly.ToString("g"));

	        // Displaying the date and time in a custom format with 24-hour clock
	        Console.WriteLine(dateOnly.ToString("MM/dd/yyyy HH:mm"));
	        Console.WriteLine(dateOnly.ToString("yyyy-mm-dd HH:mm"));
		}

	}
}