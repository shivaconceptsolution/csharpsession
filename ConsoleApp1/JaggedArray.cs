using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class JaggedArray
    {
       public static void Main(String[] args)
        {
            int row, column;
            Console.WriteLine("Enter size of row");
            row = Convert.ToInt32(Console.ReadLine());
            int [][] arr = new int[row][];
            for(int i=0; i<row; i++)
            {
                Console.WriteLine("Enter size of column for {0} row",i);
                column = Convert.ToInt32(Console.ReadLine());
                arr[i]=new int[column];
                for(int j=0; j<column; j++)
                {
                    Console.WriteLine("Enter element for {0}{1} index",i,j);
                    arr[i][j]=Convert.ToInt32(Console.ReadLine());
                }

            }
            Console.WriteLine("Array Elements are");
            for (int i = 0; i < row; i++)
            {
                
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j] + " ");
                    
                }
                Console.WriteLine();

            }
        }
    }
}
