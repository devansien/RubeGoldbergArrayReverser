using System;
using System.Text;

namespace RubeGoldbergArrayReverser
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            object[] array = new object[] { 1, "A", 3, "B", 5, "C", 7, "D" };
            Console.WriteLine("Original array: ");
            foreach (object obj in array)
                sb.Append($"{obj.ToString()} ");
            Console.WriteLine(sb.ToString());

            sb.Clear();

            array = ReverseHelper.Reverse(array);
            Console.WriteLine("Reversed array: ");
            foreach (object obj in array)
                sb.Append($"{obj.ToString()} ");
            Console.WriteLine(sb.ToString());

            Console.WriteLine("\nPress any key to stop");
            Console.ReadKey();
        }
    }
}
