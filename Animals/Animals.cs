using System;

namespace Animals
{
    public class Animal
    {
        // public - most accessible - anywhere you have an instance of Animal
        public int NumberOfLegs { get; set; }

        // private - least accessible - only this class
        private TimeSpan Age { get; set; }

        // protected - accesible from this class and derived classes
        protected string Sound { get; set; }

        //internal - accessed by any code in the same assembly, but not from another assembly.
        internal int NumberOfEyes { get; set; }
    }

    public class Dog : Animal
    {
        public Dog()
        {
            NumberOfLegs = 4;
            // Age - not accessible
            Sound = "Bark";
            NumberOfEyes = 2;
        }
    }

}



