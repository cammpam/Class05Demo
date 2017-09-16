using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class05Demo
{
    class SixFlags : AmusementPark
    {
        public int NumberOfBathrooms { get; set; }

        public void WalkThisPath()
        {
            Console.WriteLine("Stay on Path");
        }

        //public override int CollectFees()
        //{
        //    Console.WriteLine("I require $20");
        //}
    }

}
