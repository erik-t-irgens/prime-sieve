using System;
using System.Collections.Generic;
using System.Threading;
using Prime.UserNumber;
// frontend logic
namespace Prime
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Hello again, user. Let's do something interesting...");
            Thread.Sleep(1000);
            Console.WriteLine("Give me a number. Any positive integer. I'll do something with it.");
            Thread.Sleep(1000);
            Console.WriteLine("If you're ready, let's begin.");
            Thread.Sleep(1000);
            Console.WriteLine("Enter your NUMBER, user....");
            Number userNumber = new Number(0);
            int userInput = int.Parse(Console.ReadLine());
            userNumber.SetNumber(userInput);
            Thread.Sleep(1000);
            Console.WriteLine("Good. Goooood... Now watch this.");
            List<int> PrimesFromNumber = new List<int>(0);
            for (int i = 2; i < userNumber.GetUserNumber(); i++)
            {
                for (int j = 2; j < i; j++)
                {
                    Thread.Sleep(500);
                    if (i % j == 0)
                    {
                        Console.WriteLine(".");
                    }
                    else
                    {
                        PrimesFromNumber.Add(i);
                        return;
                    }
                }
            }
            Console.WriteLine("Here we go...");
            Thread.Sleep(1000);
            for (int m = 0; m < PrimesFromNumber.Count; m++)
            {
                Console.WriteLine(PrimesFromNumber[m]);
                Thread.Sleep(500);
            }
            Thread.Sleep(1000);
            Console.WriteLine("These are all prime numbers beneath the number you gave me. Cool, huh?");

        }
    }
}
