using System;
using System.Collections.Generic;
using System.Text;

namespace IceCreamShop
{
    class FlavorComparer : IComparer<Flavor>
    {
        //Sorts by Name
        //public int Compare(Flavor x, Flavor y)
        //{
        //return string.Compare(x.Name, y.Name);
        //}

        //Sorts by Allergen count
        public int Compare(Flavor x, Flavor y)
        {
            int result = x.Allergens.Count - y.Allergens.Count;
            if (result > 0)
            {
                return 1;
            }
            else if (result < 0)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
