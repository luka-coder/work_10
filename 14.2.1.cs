using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> strList = new List<string> { "item", "item1", "item2", "item3", "item4", "item5", "item6", "item7", "item8", "item9" };

            Console.WriteLine($"First item: {strList[0]}");
            Console.WriteLine($"List Size: {strList.Count}\nItems:\n");
            strList.ForEach(s => Console.WriteLine(s));

            strList.Clear();
            Console.WriteLine($"\nItem Quantity after deleting: {strList.Count}");
            Console.ReadKey();

        }
    }
}
