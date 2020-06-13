using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Lstr = new List<string> { "Armada", "Majesty", "Salomon", "Rossignol", "Fischer", "Spyder", "Line", "NISSAN", "Icelantic", "K2" };
            Lstr.Add("AddSkiBrands");
            Lstr.Add("AddSkiBrands");

            Console.WriteLine($"Array Size: {Lstr.Count}\n");
            Console.WriteLine($"Array Complementaryi: \n");
            Lstr.ForEach(a => Console.WriteLine(a));
            Console.ReadKey();

        }
    }
}
