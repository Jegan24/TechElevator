using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture.Farming
{
    public sealed class Cat : FarmAnimal
    {
        public Cat(): base("cat")
        { }

        public override string eat()
        {
            return "mmmm";
        }

        public override string MakeAwakeSoundOnce()
        {
            //isSleeping = false; isSleeping is declared in FarmAnimal as private so we can't get or set it here
            return "Meow";
        }

        public override string MakeAwakeSoundTwice()
        {
            return "meow meow";
        }
    }
}
