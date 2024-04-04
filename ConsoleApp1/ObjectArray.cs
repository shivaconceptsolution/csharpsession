using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ObjectArray
    {
        static void Main(String[] args) { 
           object[] arr = {"C","C++","DS","JAVA",12,34.56,true};
           for(int i=0; i<arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

        }
    }
}
