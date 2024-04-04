using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class StringExample
    {
        public static void Main(String[] args)
        {
            String data = "hello world";
            char[] chars = data.ToCharArray();
            int v = 0, c = 0;
            for(int i=0; i<chars.Length; i++)
            {
                switch(chars[i])
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                        v++;
                        break;
                    default:
                        c++;
                        break;

                }
            }
            Console.WriteLine("Total vowel is {0} and consonent is {1}", v, c);
        }
    }
}
