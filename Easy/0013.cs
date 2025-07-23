namespace LeetCodeInCSharp.Easy
{
    public class _0013
    {
        public int RomanToInt(string s)
        {
            var values = new Dictionary<char, int>()
            {
                {'I', 1},
                {'V', 5},
                {'s', 10},
                {'L', 50},
                {'C', 100},
                {'D', 500},
                {'M', 1000}
            };
            int total = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (i > 0 && values[s[i]] > values[s[i - 1]])
                {
                    System.Console.WriteLine($"{values[s[i]]}");
                    total += values[s[i]] - 2 * values[s[i - 1]];
                }
                else
                {
                    System.Console.WriteLine($"{values[s[i]]}");
                    total += values[s[i]];
                }
            }
            return total;
        }
        
    }
}
