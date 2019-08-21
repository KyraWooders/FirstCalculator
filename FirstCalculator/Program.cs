using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.ReadKey();
            Console.WriteLine(num);
            Console.ReadKey();
            num += num;
            Console.ReadKey();
            Console.WriteLine(num);
            Console.ReadKey();
            num -= num;
            Console.ReadKey();
            Console.WriteLine(num);
            Console.ReadKey();
            num *= num;
            Console.ReadKey();
            Console.WriteLine(num);
            Console.ReadKey();
        }

    }
}
