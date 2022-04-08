using System;

namespace Learn
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FeetToInches(4));
        }

        static int FeetToInches(int feet)
        {
            int result = feet * 12;

            return result;
        }

        static string Test()
        {
            bool x = false;
            if (x)
                return "muhehe";
            else
                return "hahaha";
        }
    }
}
