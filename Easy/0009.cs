namespace LeetCodeInCSharp.Easy
{
    public class _0009
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0) return false;
            int reversed = 0, original = x;
            while (x > 0)
            {
                reversed = reversed * 10 + x % 10;
                // System.Console.WriteLine($"x: {x}, reversed: {reversed}");
                x /= 10;
                // System.Console.WriteLine($"x: {x}, reversed: {reversed}");
            }
            return original == reversed;
        }
    }
}