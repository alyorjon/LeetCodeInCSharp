namespace LeetCodeInCSharp.Learns
{
    public class DivideTwoNumbers
    {
        public static void Run()
        {
            Console.WriteLine("Divide Two Numbers");
            int dividend = 10;
            int divisor = 3;
            // int result = Divide(dividend, divisor);
            // int result2 = Add(5, 3);
            // int result3 = Subtract(10, 4);
            // int result4 = Multiply(6, 7);
            // int result5 = Modulus(10, 3);
            // int result6 = Power(2, 3);
            // Console.WriteLine($"Result of adding 5 and 3 is: {result2}");
            // Console.WriteLine($"Result of subtracting 10 and 4 is: {result3}");
            // Console.WriteLine($"Result of multiplying 6 and 7 is: {result4}");
            // Console.WriteLine($"Result of modulus 10 and 3 is: {result5}");
            // Console.WriteLine($"Result of 2 raised to the power of 3 is: {result6}");
            // Console.WriteLine($"Result of dividing {dividend} by {divisor} is: {result}");
            List<int> swappedNumbers = SwapTwoNumbers(dividend, divisor);
            System.Console.WriteLine($"Swapped numbers: {swappedNumbers[0]}, {swappedNumbers[1]}");
            int multipliedNumbers = MultiplyNumbers(2, 3, 4);
            System.Console.WriteLine($"Result of multiplying 2, 3, and 4 is: {multipliedNumbers}");
            int result = ArithmeticOperations(dividend, divisor, "multiply");
            System.Console.WriteLine($"Result of arithmetic operation (add) on {dividend} and {divisor} is: {result}");
            MultiplicationTable(5);
            int average = AverageOfNumbers(new List<int> { 10, 21, 32, 42, 52 });
            System.Console.WriteLine($"Average of numbers is: {average}");
            List<int> results = SpecifiedFormulawithNumbers(2, 3, 4);
            System.Console.WriteLine("Results from specified formula with numbers 2, 3, and 4: {0}", string.Join(", ", results));
            string ageMessage = PrintAgeMessage(20);
            System.Console.WriteLine($"Age message: {ageMessage}");
            List<int> kelvinAndFahrenheit = CelsiusToKelvinAndFahrenheit(25);
            System.Console.WriteLine($"Kelvin: {kelvinAndFahrenheit[0]}, Fahrenheit: {kelvinAndFahrenheit[1]}");
            string inputString = "Hello, World!";
            int indexToRemove = 3;
            string modifiedString = RemoveCharacterByIndex(inputString, indexToRemove);
            System.Console.WriteLine($"Original string: {inputString}");
            System.Console.WriteLine($"Modified string after removing character at index {indexToRemove}: {modifiedString}");
            string reversedString = ReverseString(inputString);
            System.Console.WriteLine($"Reversed string: {reversedString}");
            string addedCharactersString = addFirstCharacterToStartandEnd(inputString);
            System.Console.WriteLine($"String after adding first character to start and end: {addedCharactersString}");
            bool isPositiveOrNegative = isPositivOrNegative(5, -3);
            System.Console.WriteLine($"Are the numbers 5 and -3 positive or negative? {isPositiveOrNegative}");
            int tripleSumofIntegers = tripleSumOfIntegers(5, 3);
            System.Console.WriteLine($"Triple sum of integers 5 and 3: {tripleSumofIntegers}");
            bool checkFor20orSumEquals20 = CheckFor20orSumEquals20(10, 10);
            System.Console.WriteLine($"Is either number 20 or their sum equals 20? {checkFor20orSumEquals20}");
            bool checkWithIn20Of100or200 = CheckWithIn20Of100or200(85);
            System.Console.WriteLine($"Is the number 85 within 20 of 100 or 200? {checkWithIn20Of100or200}");

            string isLowerCase = ConvertToLowercase("HELLO WORLD");
            System.Console.WriteLine($"Converted to lowercase: {isLowerCase}");
            string longestWord = LongestWordInString("The quick brown fox jumps over the lazy dog");
            System.Console.WriteLine($"Longest word in the string: {longestWord}");

            PrintOddNumbers();
            int sumOf500PrimeNumbers = SumOf500PrimeNumbers();
            System.Console.WriteLine($"Sum of the first 500 prime numbers is: {sumOf500PrimeNumbers}");
            int sumOfDigits = SumOfDigitsInInteger(12345);
            System.Console.WriteLine($"Sum of digits in 12345 is: {sumOfDigits}");
            int[] arr1 = { 1, 2, 3 };
            int[] arr2 = { 4, 5, 6 };
            int[] multipliedArrays = MuliplyTwoArrays(arr1, arr2);
            System.Console.WriteLine($"Multiplied arrays: {string.Join(", ", multipliedArrays)}");
            string fourCopies = FourCopiesOfLastFourCharacters("abcdefg");
            System.Console.WriteLine($"Four copies of the last four characters: {fourCopies}");
            bool isMultiple = isMultipleOf3or7(21);
            System.Console.WriteLine($"Is 21 a multiple of 3 or 7? {isMultiple}");
            bool checkstringfromsentence=CheckStringStartwithWord("the quick brown fox jumps over the lazy dog","the");
            Console.WriteLine(checkstringfromsentence);
            bool checknumbersless100greater200 =checkNumbersLess100greater200(120);
            Console.WriteLine(checknumbersless100greater200);
            bool checkNumbersBetween10to10 = ChecksTwoNumbersBetween10to10(-5,5);
            Console.WriteLine(checkNumbersBetween10to10);
            string removeph=RemovePH("PHP is the best");
            Console.WriteLine(removeph);
            // string extractphword=ExtractPHfromWord("PHP is forever","PH");
            List<int> minormax=findOutLargestorSmallestNumers(4,2,7);
            Console.WriteLine($"Maximum number is: {minormax[0]}\nMinimum number is: {minormax[1]}");
            int findOutnearest20=findOutNearest20orZero(13,17);
            Console.WriteLine($"Nearest number to 20 is {findOutnearest20}");
            bool checkcharacterinstring=checkCharecterinString("www3wc",'w');
            Console.WriteLine(checkcharacterinstring);
            string stringLowerOrUpper=toStringUppercaseOrLowerCase("Ais");
            Console.WriteLine(stringLowerOrUpper);
        }

        // 43. Write a C# program to check if a given string starts with "w" and is immediately followed by two "ww".
        public static bool CheckWordsStartingWithW(string word)
        {
            return word.StartsWith("w") && word.Substring(1, 2) == "ww";
        }
        // 42. First 4 Chars Lowercase, Rest Uppercase

        // Write a C# program to create a string where the first 4 characters are in lower case. If the string is less than 4 letters, 
        // make the whole string in upper case.
        public static string toStringUppercaseOrLowerCase(string s)
        {
            if (s.Length<4)
            {
                return s.ToUpper();
            }
            return s.Substring(0,4).ToLower();
        }
        // 41. Check 'w' Appears 1-3 Times
        

        // Write a C# program to check if a given string contains the 'w' character between 1 and 3 times.
        public static bool checkCharecterinString(string s, char c)
        {
            int count=0;
            for (int i=0;i<s.Length;i++)
            {
                if (s[i]==c)
                {
                    count++;
                }
            }
            if (count>1 && count<3)
            {
                return true;
            }
            return false;
        }

        // 40. nearest to 20 or return 0
        // Write a C# program that checks the nearest value of 20 of two given integers and return 0 if two numbers are same.
        public static int findOutNearest20orZero(int a, int b)
        {
            if (a==b)
            {
                return 0;
            }
            else if (20 -a >20 -b)
            {
                return b;
            }
            else {return a;}
        }
        // 39. find out largest or lowest numbers from three numbers
        public static List<int> findOutLargestorSmallestNumers(int a, int b,int c)
        {
            int first=Math.Max(a,Math.Max(b,c));
            int second=Math.Min(a,Math.Min(b,c));
            return new List<int> { first, second };

        }
        // 38. Extract 'PH' from String
        // Write a C# program to get a string of two characters from a given string. The first and second characters of the given string must be "P" and "H", so PHP will be "PH".
        // public static string  ExtractPHfromWord(string word,string chars)
        // {
        //     string[] arr= word.Split($"{chars}");
        //     if (arr.Length >0){return arr[0];}
        //     return "";

        // }

        // 37. Remove 'HP' from String

        // Write a C# program to check if "HP" appears at the second position in a string and return the string without "HP".
        public static string RemovePH(string words)
        {
            // words=words.toLower()
            string[] arr=words.ToLower().Split("ph");
            return string.Join(' ',arr);
        }

        // 36. check integer in range -10 to 10
        // Write a C# program to check if an integer (from the two given integers) is in the range -10 to 10.
        public static bool ChecksTwoNumbersBetween10to10(int a,int b)
        {
            if ((a >-10 || a <10) && ( b>-10 || b<10 ))
            {
                return true;
            }
            return false;
        }
        // 35. Check Numbers Less than 100 & Greater than 200
        // Write a C# program to check two given numbers where one is less than 100 and the other is greater than 200.
        public static bool checkNumbersLess100greater200(int a)
        {
            if (a <100 || a> 200){return true;}
            return false;
        }

        // 34. Check String Starts with Word
        //  Write a C# program to check if a string starts with a specified word.
        public static bool CheckStringStartwithWord(string sentence,string words)
        {
            // Console.WriteLine(words);
            string[] sozlar=sentence.Split(" ");
            if (sozlar[0]==words){
                return true;
            }
            return false;
        }
        // 33. Check Multiple of 3 or 7
        // Write a C# program to check if a given integer is a multiple of 3 or 7.
        public static bool isMultipleOf3or7(int number)
        {
            if (number % 3 == 0 || number % 7 == 0)
            {
                return true;
            }
            return false;
        }
        // 32. Four Copies of Last Four Characters
        // Write a C# program to print four copies of the last four characters of a given string.
        public static string FourCopiesOfLastFourCharacters(string input)
        {
            if (input == null || input.Length < 4)
            {
                throw new ArgumentException("Input must be at least 4 characters long.");
            }
            string lastFourCharacter = input.Substring(input.Length - 4);
            return string.Concat(Enumerable.Repeat(lastFourCharacter, 4));
        }
        // 28. Multiply Two Arrays
        // Write a C# program to multiply two arrays of integers and return the result as a new array.
        public static int[] MuliplyTwoArrays(int[] arr1, int[] arr2)
        {
            if (arr1.Length != arr2.Length)
            {
                throw new ArgumentException("Both arrays must have the same length.");
            }
            int[] result = new int[arr1.Length];
            for (int i = 0; i < arr1.Length; i++)
            {
                result[i] = arr1[i] * arr2[i];
            }
            return result;
        }


        // 27. Sum of Digits in Integer
        // Write a C# program to calculate the sum of digits in a given integer.
        public static int SumOfDigitsInInteger(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException("Number cannot be negative.");
            }
            int sum = 0;
            while (number > 0)
            {
                System.Console.WriteLine($"Current integer:{number % 10}");
                sum += number % 10; // Add the last digit to the sum
                number /= 10; // Remove the last digit
            }
            return sum;
        }

        // 26.  Sum of First 500 Primes
        // Write a C# program to calculate the sum of the first 500 prime numbers.
        public static int SumOf500PrimeNumbers()
        {
            int count = 0;
            int num = 2;
            int sum = 0;
            while (count < 500)
            {
                bool isPrime = true;
                for (int i = 2; i <= Math.Sqrt(num); i++)
                {
                    if (num % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    sum += num;
                    count++;
                }
                num++;
            }
            return sum;
        }


        // 25. print odd numbers from 1 to 100
        // Write a C# program to print all odd numbers from 1 to 100.
        public static void PrintOddNumbers()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        // 24 Longest word in a string
        // Write a C# program to find the longest word in a given string.
        public static string LongestWordInString(string input)
        {
            string[] words = input.Split(' ');
            string longestWord = string.Empty;
            foreach (string word in words)
            {
                if (word.Length > longestWord.Length)
                {
                    longestWord = word;
                }

            }
            return longestWord;
        }
        // 23. Convert string to lowercase
        // Write a C# program to convert a given string to lowercase.
        public static string ConvertToLowercase(string input)
        {
            // This method converts the input string to lowercase
            if (input == null)
            {
                throw new ArgumentNullException(nameof(input), "Input cannot be null.");
            }

            return input.ToLower();
        }
        // 22. Check Within 20 of 100 or 200
        // Write a C# program to check if the given integer is within 20 of 100 or 200.
        public static bool CheckWithIn20Of100or200(int number)
        {
            // This method checks if the number is within 20 of 100 or 200
            if ((number >= 80 && number <= 120) || (number >= 180 && number <= 220))
            {
                return true;
            }
            return false;
        }

        //21. Check for 20 or Sum Equals 20
        // Write a C# program to check the sum of the two given integers. Return true if one of the integers is 20 or if their sum is 20.
        public static bool CheckFor20orSumEquals20(int a, int b)
        {
            if (a == 20 || b == 20 || (a + b) == 20) { return true; }
            return false;
        }

        public static int tripleSumOfIntegers(int a, int b)
        {
            if (a == b)
            {
                return (a + b) * 3;
            }
            // This method returns the sum of three integers multiplied by 3
            return (a + b);
        }
        public static bool isPositivOrNegative(int a, int b)
        {
            if ((a > 0 && b < 0) || (a < 0 && b > 0))
            {
                return true;
            }
            return false;
        }

        public static string addFirstCharacterToStartandEnd(string input)
        {
            // This method adds the first character of the input string to both the start and end of the string
            if (string.IsNullOrEmpty(input))
            {
                throw new ArgumentException("Input cannot be null or empty.");
            }
            char firstChar = input[0];
            return $"{firstChar}{input}{firstChar}";
        }
        public static string ReverseString(string input)
        {
            // This method reverses the input string
            if (input == null)
            {
                throw new ArgumentNullException(nameof(input), "Input cannot be null.");
            }
            char[] charArray = input.ToCharArray();
            System.Console.WriteLine(charArray);
            Array.Reverse(charArray);
            System.Console.WriteLine(charArray);
            return new string(charArray);
        }
        public static string RemoveCharacterByIndex(string input, int index)
        {
            string result = input.Remove(index, 1);
            return result;
        }
        public static List<int> CelsiusToKelvinAndFahrenheit(int celsius)
        {
            // This method converts Celsius to Kelvin and Fahrenheit
            if (celsius < -273)
            {
                throw new ArgumentException("Celsius cannot be below absolute zero (-273.15).");
            }
            List<int> results = new List<int>
            {
                celsius + 273,  // Kelvin
                (int)(celsius * 9.0 / 5.0 + 32)  // Fahrenheit
            };
            return results;
        }

        public static string PrintAgeMessage(int age)
        {
            // This method returns a message based on the age provided
            if (age < 0)
            {
                throw new ArgumentException("Age cannot be negative.");
            }
            else if (age < 18)
            {
                return "You are a minor.";
            }
            else if (age < 65)
            {
                return "You are an adult.";
            }
            else
            {
                return "You are a senior citizen.";
            }
        }

        public static List<int> SpecifiedFormulawithNumbers(int a, int b, int c)
        {
            // This method returns a list of integers based on a specified formula
            // Here, we will return the sum, product, and difference of the three numbers
            List<int> results = new List<int>
            {
                (a + b) * c,  // Sum
                a * b + b * c,  // Product
                a - b - c   // Difference
            };
            return results;
        }
        public static int AverageOfNumbers(List<int> numbers)
        {
            if (numbers == null || numbers.Count == 0)
            {
                throw new ArgumentException("The list of numbers cannot be null or empty.");
            }
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            return sum / numbers.Count;
        }
        public static void MultiplicationTable(int number)
        {
            Console.WriteLine($"Multiplication Table for {number}:");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{number} x {i} = {number * i}");
            }
        }
        public static int ArithmeticOperations(int a, int b, string operation)
        {
            switch (operation.ToLower())
            {
                case "add":
                    return Add(a, b);
                case "subtract":
                    return Subtract(a, b);
                case "multiply":
                    return Multiply(a, b);
                case "divide":
                    return Divide(a, b);
                case "modulus":
                    return Modulus(a, b);
                default:
                    throw new ArgumentException("Invalid operation specified.");
            }
        }

        public static int Divide(int dividend, int divisor)
        {
            if (divisor == 0)
            {
                throw new DivideByZeroException("Divisor cannot be zero.");
            }
            return dividend / divisor;
        }
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int Subtract(int a, int b)
        {
            return a - b;
        }
        public static int Multiply(int a, int b)
        {
            return a * b;
        }
        public static int Modulus(int a, int b)
        {
            return a % b;
        }
        public static int Power(int baseNum, int exponent)
        {
            if (exponent < 0)
            {
                throw new ArgumentException("Exponent must be non-negative.");
            }
            int result = 1;
            for (int i = 0; i < exponent; i++)
            {
                result *= baseNum;
            }
            return result;
        }
        public static List<int> SwapTwoNumbers(int a, int b)
        {
            // Swapping two numbers using tuple deconstruction
            (a, b) = (b, a);
            return new List<int> { a, b };
        }
        public static int MultiplyNumbers(int a, int b, int c)
        {
            // Multiplying three numbers
            return a * b * c;
        }

    }
}
