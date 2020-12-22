using System;
using System.Collections.Generic;

namespace IceCreamShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Case menu = new Case();
            List<Flavor> availableFlavors = menu.Flavors;
            List<Cone> availableCones = menu.Cones;
            List<Flavor> b4SortFlavors = menu.Flavors;
            // TODO: Use a Comparer class to sort the 'flavors' array alphabetically by the 'name'
            //  field.
            Console.WriteLine("Flavors Before Sort:");
            for (int i = 0; i < availableFlavors.Count; i++)
            {
                Console.WriteLine(availableFlavors[i].Name);
               
            }
            FlavorComparer comparer = new FlavorComparer();
            availableFlavors.Sort(comparer);
            // TODO: Use a Comparator class to sort the 'cones' array in increasing order by the 'cost'
            //  field.
            Console.WriteLine("\nCones Before Sort:");
            for (int i = 0; i < availableCones.Count; i++)
            {
                Console.WriteLine(availableCones[i].Name + ": $" + availableCones[i].Cost);

            }
            CostComparer coneComparer = new CostComparer();
            availableCones.Sort(coneComparer);
            // TODO: Print the 'flavors' and 'cones' lists (in a clear manner) to verify the sorting.
            //foreach (object item in availableFlavors)
            //Console.WriteLine("\nFlavors After Sort:");
            //for (int i = 0; i < availableFlavors.Count; i++)
            //{
                //Console.WriteLine(availableFlavors[i].Name);
                
            //}
            //FlavorComparer was changed to sort by number of Allergens
            
            Console.WriteLine("\nFlavors by Allergen Count");
            for (int i = 0; i < availableFlavors.Count; i++)
            {
               Console.WriteLine(availableFlavors[i].Name + " " + availableFlavors[i].Allergens.Count);
            }
            
            Console.WriteLine("\nCones After Sort:");
            for (int i = 0; i < availableCones.Count; i++)
            {
                Console.WriteLine(availableCones[i].Name + ": $" + availableCones[i].Cost);

            }
        }
    }
}
