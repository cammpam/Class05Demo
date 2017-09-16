using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class05Demo
{
    abstract class AmusementPark : Park
    {
        //add properties
        public string food { get; set; }

        public bool AcceptsPets()
        {
            return true;
        }   

        public sealed override int CollectFees()
        {
            return base.CollectFees() + 30;
        }
    }
}
