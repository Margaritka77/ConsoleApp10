using System;

namespace ConsoleApp10
{
    class Program
    {
        static int NPrime(int n)
        {
            int count = 0;
            int prime = 2;
            while (count < n)
            {
                bool flag = true; //true - число простое, false - число не простое 
                for (int i = 2; i < prime; i++)
                {
                    if (prime % i == 0)
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag)
                    count++;
                prime++;
            }
            return prime - 1;
        }
        //Написать алгоритм поиска Nго простого числа 
        //(к примеру 2, 3, 5, 7 где 2 это 1ое число 3 - второе и т.д., 
        //т.е. если N = 4 то на выходе должно быть 7) 
        static void Main(string[] args)
        {
            Console.WriteLine("Какое по счёту простое число вы хотите найти? ");
            Console.Write("N = ");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine($"{N}ое простое число = {NPrime(N)}");
        }
    }
}