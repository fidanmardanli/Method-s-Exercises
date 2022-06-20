using System;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1(13);
            Task2(12, 10);
            Task3(30, 50);
            Task4(new int[] { 1, 3, 5, 7, 9 });
            Task5(new int[] { 1, 4, 5, 12, 9 });
            Task6(43);

        }


        //Checking if N is divisible by 3 and 7
        static void Task1(int n)
        {
            if (n % 3 == 0 && n % 7 == 0)
                Console.WriteLine("N is divisible by 3 and 7");
            else
                Console.WriteLine("N is not divisible by 3 and 7");

        }



        //If n and m are even numbers, sum them
        static void Task2(int n, int m)
        {
            var sum = n + m;
            if (n % 2 == 0 && m % 2 == 0)
                Console.WriteLine("Sum of the n and m are: " + sum);
            else
                Console.WriteLine("One of them is not even number");

        }



        //Find the sum of the even numbers from n to m
        static void Task3(int n, int m)
        {
            int sum = 0;
            if (n < m)
            {
                for (int i = n; i <= m; i++)
                {
                    if (i % 2 == 1)
                        sum += i;
                }
                Console.WriteLine($"Sum of Odd numbers from {n} to {m} is : {sum}");
            }
            else

                Console.Write("Invalid");

        }



        //sum of odd numbers in the given array
        static void Task4(int[] arr)
        {

            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 != 0)
                    sum += arr[i];
            }

            Console.WriteLine("Sum of odd numbers in the given array="
                                   + sum);
        }



        //Count of the even numbers in the array
        static void Task5(int[] arr)
        {

            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 == 0)
                    count += arr[i];
            }

            Console.WriteLine("Count of even numbers in the given array="
                                   + count);

        }



        //Checking if n is composite or prime number
        static void Task6(int n)
        {
            int count = 0;
            {
                for (int i = 1; i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        count++;
                    }
                }
                if (count > 2)
                {
                    Console.WriteLine($"{n} is a composite Number");
                }
                else
                {
                    Console.WriteLine($"{n} is a prime number");
                }

            }
        }

    }

}


