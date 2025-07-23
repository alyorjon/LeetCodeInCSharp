namespace LeetCodeInCSharp.Easy
{
    public class _0014
    {
        public string LongestCommonPrefix(string[] strs)
        {
            if (strs == null || strs.Length == 0) return "";

            // Start with the first string as the prefix
            string prefix = strs[0];
            System.Console.WriteLine($"prefix: {prefix}");
            // Compare the prefix with each string
            for (int i = 1; i < strs.Length; i++)
            {
                // While the current string does not start with the prefix
                while (strs[i].IndexOf(prefix) != 0)
                {
                    // Reduce the prefix by one character from the end
                    prefix = prefix.Substring(0, prefix.Length - 1);
                    // If there's no common prefix
                    if (prefix == "") return "";
                }
            }
            return prefix;
        }
    }
}