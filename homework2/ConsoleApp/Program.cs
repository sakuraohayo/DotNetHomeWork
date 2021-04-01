using System;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(String[] args)
        {
            int  i;
            i = 2;
            Console.WriteLine("请输入数字");
            int n = int.Parse(Console.ReadLine());
             Console.WriteLine(n+"=");
            while (n != 1)
            {
                if (n % i == 0)
                {
                    if (n == i)
                        Console.WriteLine(i);
                    else
                        Console.WriteLine(i+"*");
                    n /= i;
                }
                if (n % i != 0)
                    i++;
            }
            return ;
        }
    }
    }
