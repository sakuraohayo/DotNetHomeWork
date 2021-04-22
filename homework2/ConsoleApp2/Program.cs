using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp2
{

    namespace text
    {
        public class Score
        {
            public int GetMin(int[] list)
            {
                int min = int.MaxValue;
                foreach (int i in list)
                {
                    if (i < min)
                        min = i;
                }
                return min;
            }
            public int GetMax(int[] list)
            {
                int max = 0;
                foreach (int i in list)
                {
                    if (i > max)
                        max = i;
                }
                return max;
            }
            public float GetAve(int[] list)
            {
                int sum = 0;
                float Ave;
                foreach (int i in list)
                {
                    sum += i;

                }
                Ave = sum / 10.0f;
                return Ave;
            }
            public int Sum(int[] list)
            {
                int sum = 0;
                int Sum;
                foreach (int i in list)
                {
                    sum += i;

                }
                Sum = sum;
                return Sum;
            }
        }
        namespace text
        {
            public class Score
            {
                public int GetMin(int[] list)
                {
                    int min = int.MaxValue;
                    foreach (int i in list)
                    {
                        if (i < min)
                            min = i;
                    }
                    return min;
                }
                public int GetMax(int[] list)
                {
                    int max = 0;
                    foreach (int i in list)
                    {
                        if (i > max)
                            max = i;
                    }
                    return max;
                }
                public float GetAve(int[] list)
                {
                    int sum = 0;
                    float Ave;
                    foreach (int i in list)
                    {
                        sum += i;

                    }
                    Ave = sum / 10.0f;
                    return Ave;
                }
                public int Sum(int[] list)
                {
                    int sum = 0;
                    int Sum;
                    foreach (int i in list)
                    {
                        sum += i;

                    }
                    Sum = sum;
                    return Sum;
                }
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Score s = new Score();
                int[] score = new int[10];
                Console.WriteLine("请输入10个数，并求最大值、最小值,平均值和总和：\n");
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("请输入第{0}个数: ", i + 1);
                    score[i] = Int32.Parse(Console.ReadLine());
                }
                Console.WriteLine("您输入10个数中最小值为： " + s.GetMin(score));
                Console.WriteLine("您输入10个数中最大值为： " + s.GetMax(score));
                Console.WriteLine("您输入10个数中平均值为： " + s.GetAve(score));
                Console.WriteLine("您输入10个数的总和为： " + s.Sum(score));
            }
        }
    }
}