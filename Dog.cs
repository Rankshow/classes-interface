using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Classes
{
    public class Dog : IDogWalker
    {
        public void DogBarking()
        {
           Console.WriteLine("Dog barking in the building");
        }
        public void WalkerToTheCity()
        {
           Console.WriteLine("Walk to the city");
        }

        public void WalkerToTheFoodBowl()
        {
            Console.WriteLine("Walk to the foodbowl");
        }

        public void WalkerToThePark()
        {
           Console.WriteLine("Walk to the park");
        }
    }
}