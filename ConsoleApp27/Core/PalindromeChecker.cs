namespace ConsoleApp27.Core
{
    public class PalindromeChecker
    {
        public static bool IsPalindrome(int number)
        {
            string numberStr = number.ToString();
            string reversedStr = new string(numberStr.ToCharArray().Reverse().ToArray());
            return numberStr == reversedStr;
        }
    }
}
