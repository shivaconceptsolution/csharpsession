using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class CollectionExample
    {
        public static void Main(String[] args)
        {
            List<Student> students = new List<Student>();
            students.Add(new Student(1, "stu1", 34, 24000));
            students.Add(new Student(2, "stu2", 34, 24000));
            students.Add(new Student(3, "stu3", 54, 24000));
            students.Add(new Student(4, "stu4", 34, 84000));
            foreach (var student in students)
            {
                student.Display();
            }

            /*HashSet<string> st = new HashSet<string>();
            st.Add("a");
            st.Add("b");
            st.Add("c");
            st.Add("b");
            st.Add("b");
            st.Add("d");
            st.Add("e");
            st.Remove("a");
            foreach (var item in st)
            {
                Console.WriteLine(item);
            }
            /* Stack<int> stack = new Stack<int>();
           stack.Push(1);
           stack.Push(2);
           stack.Push(3);
           stack.Push(4);
           stack.Push(5);
           while(stack.Count > 0)
           {
               Console.WriteLine(stack.Pop());
           }
           Console.WriteLine("Queue Operation");
           Queue<int> q = new Queue<int>();
           q.Enqueue(1);
           q.Enqueue(2);
           q.Enqueue(3);
           q.Enqueue(4);
           q.Enqueue(5);
           while (q.Count > 0)
           {
               Console.WriteLine(q.Dequeue());
           }
          //SortedList obj = new SortedList();
            Hashtable obj = new Hashtable();
            obj.Add("D", 101);
            obj.Add("B","CPP");
            obj.Add("A",1);
            obj.Add("C",true);
            foreach (DictionaryEntry o in obj)
            {
                Console.WriteLine(o.Key+ " " + o.Value);
            }
            //  SortedList<String,Int32> obj1 = new SortedList<String,Int32>();
            Dictionary<String, Int32> obj1 = new Dictionary<String,Int32>();
            obj1.Add("A", 101);
            obj1.Add("D", 455);
            obj1.Add("B", 201);
            obj1.Add("C", 301);
            foreach (KeyValuePair<String,Int32> o in obj1)
            {
                Console.WriteLine(o.Key + " " + o.Value);
            }
            /* ArrayList obj = new ArrayList();
             obj.Add("C");
             obj.Add("CPP");
             obj.Add(1);
             foreach(object o in obj)
             {
                 Console.WriteLine(o);
             }
             List<Int32> list = new List<Int32>();
             list.Add(1);
             list.Add(2);
             list.Add(3);
             list.Add(4);
             list.Add(5);
             list.Remove(3);
             foreach (int o in list)
             {
                 Console.WriteLine(o);
             }*/

        }
    }
}
