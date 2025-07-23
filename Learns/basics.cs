using System;
namespace LeetCodeInCSharp.Learns
{
	public class Basics
	{
		public static void Run()
		{
			Console.WriteLine(1);
			int[] arr1={1,2,3,4};
			double[] arr2={1.0,2.0,3.0,4.0};
			String[] arr3={"1","2","3","4"};
			// IterateArray(arr1);
			// IterateArray(arr2);
			// IterateArray(arr3);
			// ListMethods();
			Console.WriteLine($"{Planets.Pluto} is a planet\nNumber is {(int)Planets.Pluto}");
			String name=Planets.Earth.ToString();
			int orderby=(int)Planets.Earth;
			Console.WriteLine(name+$"  {orderby}");
		}

		enum Planets
		{
			Mercury=1,
			Venus=2,
			Earth=3,
			Mars=4,
			Jupiter=5,
			Saturn=6,
			Uranus=7,
			Neptune=8,
			Pluto=9
		}
		public static void IterateArray<T>(T[] arr)
		{
			foreach (T i in arr)
			{
				Console.Write(i+" ");
			}
			Console.WriteLine();
			
		}
		public static void ListMethods()
		{
			List<String> places=new List<String>();
			places.Add("Tashkent");
			places.Add("Farghana");
			places.Add("Buxoro");
			places.Add("Andijan");
			// Console.WriteLine(places.Remove("Andijan"));
			places.Insert(0,"City");
			Console.WriteLine(places.Count);
			places.Insert(1,"Tashkent");
			Console.WriteLine(places.IndexOf("Tashkent"));
			Console.WriteLine(places.LastIndexOf("Tashkent"));
			places.Sort();
			Console.WriteLine(places.Contains("Buxoro"));
			places.Reverse();
			String[] newPlaces=places.ToArray();
			foreach(string item in places)
			{
				Console.WriteLine(item);
			}
			foreach(string item in newPlaces)
			{
				Console.WriteLine(item);
			}
		}

	}

}