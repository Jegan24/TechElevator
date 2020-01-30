using Lecture.Farming;
using System;
using System.Collections.Generic;

namespace Lecture
{
    class Program
    {
        static void Main(string[] args)
        {
           //
            // OLD MACDONALD
            //
            Console.WriteLine("Old MacDonald had a farm ee ay ee ay oh");

                       // Let's try singing about a Farm Animal
            List<ISingable> farm = new List<ISingable>();

            Cat c = new Cat();
            c.sleep();
            c.eat();
            //Skeleton s = new Skeleton(); not allowed since it's abstract

            //c.Name = "garfield"; i caould only do this here if it was public
            farm.Add(c);
            farm.Add(new Palimino());
            farm.Add(new Horse());            
            farm.Add(new Goose());
            Goose gooseB = new Goose();   
            
            farm.Add(new Horse());
            farm.Add(new Palimino());
            farm.Add(new Horse("gary"));
            farm.Add(gooseB);
            farm.Add(new Goat());
            farm.Add(new Tractor());


            List<ISellable> forTheYardSale = new List<ISellable>();

            int i = 0;

            // Can we swap out any animal in place here?
            foreach (ISingable thingOnTheFarm in farm)
            {
                //put every other thingOnTheFarm to sleep if it's an animal
                if (i%2==0 && thingOnTheFarm is FarmAnimal)
                {
                    ((FarmAnimal)thingOnTheFarm).sleep();                     
                }
                i++; 

                if (thingOnTheFarm is Goose) //rename all the geese bernard
                {
                    ((Goose)thingOnTheFarm).reNameTheGoose("bernard");
                }
                if (thingOnTheFarm is ISellable)
                {
                    forTheYardSale.Add((ISellable) thingOnTheFarm);
                }


                Console.WriteLine("And on his farm there was a " + thingOnTheFarm.Name + " ee ay ee ay oh");
                Console.WriteLine("With a " + thingOnTheFarm.MakeSoundTwice() + " here and a " + thingOnTheFarm.MakeSoundTwice() + " there");
                Console.WriteLine("Here a " + thingOnTheFarm.MakeSoundOnce() + ", there a " + thingOnTheFarm.MakeSoundOnce() + " everywhere a " + thingOnTheFarm.MakeSoundTwice());
                Console.WriteLine("Old Macdonald had a farm, ee ay ee ay oh");
                Console.WriteLine();
            }

            forTheYardSale.Add(new Apple());
            Console.WriteLine("Sellable things: ");
            foreach( ISellable thingToSell in forTheYardSale)
            {
                Console.Write(thingToSell.Name + ", ");
            }

            Console.ReadLine();
        }
    }
}