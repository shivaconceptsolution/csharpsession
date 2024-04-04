using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class StringCaseConversion
    {
        public static void Main()
        {
            string s = "HeLlO";
            string s1 = "";
            Console.WriteLine(s.ToLower());
            Console.WriteLine(s.ToUpper());
            char [] arr = s.ToCharArray();
            for(int i=0; i<arr.Length; i++)
            {

                int asc = arr[i];
                if(asc>=65 && asc<=90)
                {
                    s1 += (char)(asc + 32);
                }
                else
                {
                    s1 += (char)(asc - 32);
                }
                
                
            }
            Console.WriteLine(s1);



        }
    }
}
