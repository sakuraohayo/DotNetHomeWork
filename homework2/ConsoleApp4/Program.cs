using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
           bool IsToeplitzMatrix(int[][] matrix)
            {
                //每个元素都与左上角的数字比较
                for (var i = 0; i < matrix.Length; i++)
                {
                    for (var j = 0; j < matrix[i].Length; j++)
                    {
                        if (i != 0 && j != 0 && matrix[i][j] != matrix[i - 1][j - 1])
                        {
                            return false;
                        }
                    }
                }
                return true;
            }
        }

    }
}
  