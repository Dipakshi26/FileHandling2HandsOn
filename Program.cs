using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOn2FileHandling
{
    public class Program
    {
        static void Main(string[] args)
        {
            Class1 obj1 = new Class1();
            obj1.Readfile();
            Console.WriteLine();
            Console.WriteLine("read operation completed");
        }
    }
}
