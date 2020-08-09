using System;

namespace PalindromeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            bool bl = IsPalindrome(int.Parse(Console.ReadLine()));
        }

        public static bool IsPalindrome(int x)
        {
            int reversed = 0;
            int temp = x;

            if (x < 0)
            {
                return false;
            }

            while (temp != 0)
            {
                reversed = reversed * 10 + temp % 10;
                temp /= 10;
            }

            return reversed == x;
        }
    }
}
