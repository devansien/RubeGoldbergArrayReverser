using System;
using System.Text;

namespace RubeGoldbergArrayReverser
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            object[] array = new object[] { 1, "B", 3, "D", 5 };
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

            Console.ReadKey();
        }
    }
}
