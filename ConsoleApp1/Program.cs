namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size;
            Console.WriteLine("Enter size of array");
            size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            for(int i = 0; i < size; i++)
            {
                Console.WriteLine("Enter element for {0} index", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Array Elements are");
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(arr[i]);
                 
            }


        }
    }
}