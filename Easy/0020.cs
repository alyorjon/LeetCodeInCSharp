namespace LeetCodeInCSharp.Easy
{
    public class _0020
    {
        public bool isValidParantheses(string s)
        {
            // Stack yaratamiz - ochiq qavslarni saqlash uchun
            Stack<char> stack = new Stack<char>();

            // Har bir belgi uchun tekshiramiz
            foreach (char c in s)
            {
                // Agar ochiq qavs bo'lsa - stackga qo'yamiz
                if (c == '(' || c == '{' || c == '[')
                {
                    stack.Push(c);
                }
                // Agar yopiq qavs bo'lsa
                else if (c == ')' || c == '}' || c == ']')
                {
                    // Stack bo'sh bo'lsa - xato (yopiq qavs uchun ochiq qavs yo'q)
                    if (stack.Count == 0)
                        return false;

                    // Stack tepasidagi ochiq qavsni olamiz
                    char top = stack.Pop();

                    // Qavslar mos kelishini tekshiramiz
                    if ((c == ')' && top != '(') ||
                        (c == '}' && top != '{') ||
                        (c == ']' && top != '['))
                    {
                        return false;
                    }

                }
                System.Console.WriteLine(stack.Count);
            }
            Console.WriteLine(stack);
            // Oxirida stack bo'sh bo'lishi kerak (barcha qavslar yopilgan)
            return stack.Count == 0;
        }
    }
}
