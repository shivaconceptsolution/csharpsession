using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class MultiDimensionalArray
    {
        static void Main(string[] args)
        {
            int row,column;
            Console.WriteLine("Enter size of row");
            row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter size of column");
            column = Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int[row,column];
            for (int i = 0; i <row; i++)
            {
                for(int j=0; j <column; j++)
                {
                    Console.WriteLine("Enter element for {0}{1} index", i,j);
                    arr[i,j] = Convert.ToInt32(Console.ReadLine());
                }
                
            }
            Console.WriteLine("Array Elements are");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write(arr[i,j] + " ");
                    
                }
                Console.WriteLine();

            }


        }
    }
}
