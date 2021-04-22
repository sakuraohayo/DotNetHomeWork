using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" 请输入数字A：");
            string A = Console.ReadLine();

            Console.Write(" 请选择运算符号B(+、-、*、/)：");
            string B = Console.ReadLine();

            Console.Write(" 请输入数字C：");
            string C = Console.ReadLine();

            string D = "";
            if (B == "+")
                D = Convert.ToString(Convert.ToDouble(A) + Convert.ToDouble(C));
            if (B == "-")
                D = Convert.ToString(Convert.ToDouble(A) - Convert.ToDouble(C));
            if (B == "*")
                D = Convert.ToString(Convert.ToDouble(A) * Convert.ToDouble(C));
            if (B == "/")
                D = Convert.ToString(Convert.ToDouble(A) / Convert.ToDouble(C));
            Console.WriteLine(" 结果是：" + D);
            Console.ReadLine();
        }
    }
}
