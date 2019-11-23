using Animals;
using System;

namespace People
{
    public class Person : Animal
    {
        public Person()
        {
            NumberOfLegs = 2;
            //not accessible - internal- NumberOfEyes = 2;
            Sound = "Language";
            NumberOfEars = 2;

        }
    }
}
