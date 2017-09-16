using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class05Demo
{
    class Program : Park
    {
        static void Main(string[] args)
        {
            SixFlags california = new SixFlags();

            Console.WriteLine(california.CollectFees());

            Console.Read();
        }
    }
}
