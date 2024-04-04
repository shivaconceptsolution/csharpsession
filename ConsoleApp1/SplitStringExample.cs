using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class SplitStringExample
    {
        public static void Main()
        {
            String fullname = "manish kumar ssssss ddddddd sharma";
            Console.WriteLine(fullname.LastIndexOf(" ") + " " + (fullname.Length - 1));
            
           Console.WriteLine(fullname.Substring(fullname.LastIndexOf(" ")+1));
           Console.WriteLine(fullname.Substring(0,fullname.Split(" ")[0].Length));
           Console.WriteLine(fullname.Replace('q','n'));
           Console.Write(fullname.Contains("q"));
           char [] arr = fullname.Reverse().ToArray();
            Console.WriteLine(arr);
            int a = 123;
            Console.WriteLine(a+1);
            /*String[] arr = fullname.Split(" ");
            
            if(arr.Length >2)
            {
                String middle = "";
                for (int i=1;i<arr.Length-1;i++)
                {
                    middle += arr[i] + " ";
                }
                Console.WriteLine("first name is {0} Middle {1} and Last {2} ", arr[0],middle, arr[arr.Length-1]);

            }
            else
            {
                Console.WriteLine("first name is {0} and Last {2} ", arr[0],arr[1]);
            }*/
            //Console.ReadKey();

        }
    }
}
