using System;
using System.Collections.Generic;
using System.Text;

namespace IceCreamShop
{
    class CostComparer : IComparer<Cone>
    {
        public int Compare(Cone x, Cone y)
        
        {
            
            double result = x.Cost - y.Cost;
            if (result > 0)
            {
            return 1;
            } else if (result < 0)
            {
            return -1;
            } else
            {
            return 0;
            }
            
            
        }

        
    }
}
