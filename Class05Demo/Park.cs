using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class05Demo
{
    abstract class Park
    {
        protected int Hours { get; set; }
        protected string Location { get; set; }

        protected int AddToLot()
        {
            int parkingLot = 0;
            return parkingLot;
        }

        public virtual int CollectFees()
        {
            return 20; 
        }


 
 
        
     }
}
