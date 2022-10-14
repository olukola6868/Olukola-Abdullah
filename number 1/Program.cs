using System;
namespace Number1
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Console.WriteLine("Hello, World!");
            Console.WriteLine("Enter your first number:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your second number:");
            int num2 = int.Parse(Console.ReadLine());
            CheckNumber(num1, num2);


        }
        public static int CheckNumber(int num1, int num2)
        {
            int Length = 0;
            if (num1 == 0 || num2 == 0)
            {
                return 0;
            }
            int count = 0;
            while (num1 != 0 && num2 != 0)
            {
                for (int i = 0; i < Length; i++)
                {
                    if (num1 > num2)
                    {
                        num1 -= num2;
                    }
                    else
                    {
                        num2 -= num1;
                    }
                    count++;
                }

            }
            return count;
        }

    }
}