using System.Numerics;

namespace CSProblems
{
    class Problems
    {


        static BigInteger FactorialCalculator(BigInteger num)
        {
            
            if (num <= 1) return 1;

            return num * FactorialCalculator(num-1);

        }

        static bool IsPalindrome(string s)
        {
            s = s.Trim().ToLower();
            int counter = s.Length-1;

            for (int i = 0; i < s.Length/2; i++) 
            {
                if (counter == (s.Length / 2) )
                {
                    break;
                }
                if (s[i] != s[counter])
                {
                    return false;
                }

                counter--;

            }


            return true;
        }

        static void Main()
        {
            #region Program to swap two numbers without using a temporary variable

            //int a = 12;
            //int b = 13;

            //Console.WriteLine($"Before the swap a={a} and b={b}");
            //(a, b) = (b, a);
            //Console.WriteLine($"After the swap a={a} and b={b}");


            #endregion

            #region Program to calculate the factorial of a number


            //Console.WriteLine("Waht number do you want to calculate factorial for?");
            //BigInteger num = BigInteger.Parse(Console.ReadLine());
            //BigInteger fact = FactorialCalculator(num);
            //Console.WriteLine($"The factorial of {num} is {fact}");

            #endregion

            #region Program to check if a given string is a palindrome

            //Console.WriteLine("Insert a string and i'll tell you f it's a Palindrome or not");

            //bool ans = IsPalindrome(Console.ReadLine());

            //Console.WriteLine($"The string you typed in is {(ans ? "a" : "NOT a")} PALINDROME");


            #endregion

            #region Program to find the sum of digits of a number
            //Console.WriteLine("Insert a number");
            //int num = int.Parse(Console.ReadLine());

            //string convertedNumber = num.ToString();
            //num = 0;
            //string temp;

            //for (int i = 0; i < convertedNumber.Length; i++) 
            //{
            //    temp = convertedNumber[i].ToString();
            //    num += int.Parse(temp);
            //}
            //Console.WriteLine($"Thes sum of all the digits is {num} and the original number was {convertedNumber}");



            #endregion

            #region Program to calculate the area of different geometric shapes (circle, rectangle, triangle)
            // Code goes here
            #endregion

            #region Program to find the frequency of each character in a string
            // Code goes here
            #endregion

            #region Program that prints the first 10 numbers in the Fibonacci sequence
            // Code goes here
            #endregion

            #region Program that generates a random number between 1 and 100
            // Code goes here
            #endregion

            #region Program to take a score and output the corresponding grade
            // Code goes here
            #endregion

            #region Program to find the greatest common divisor (GCD) of two numbers
            // Code goes here
            #endregion

            #region Program to add, remove, and view items on a shopping list
            // Code goes here
            #endregion

            #region Program to ask the user for their birth year and calculate their age
            // Code goes here
            #endregion

            #region Program to ask the user 5 simple math questions and print their score
            // Code goes here
            #endregion

            #region Program that prints the ASCII values of all uppercase letters
            // Code goes here
            #endregion

            #region Program to generate a random password of a specified length
            // Code goes here
            #endregion

            #region Program to check and print all leap years between two given years
            // Code goes here
            #endregion

            #region Program to check if a number is a strong number
            // Code goes here
            #endregion

        }
    }
}
