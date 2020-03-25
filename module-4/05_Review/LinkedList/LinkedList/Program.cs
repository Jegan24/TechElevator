using LinkedList.Models;
using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            LinkedList_int myList = new LinkedList_int();
            myList.AddToBeginning(5);
            myList.AddToBeginning(15);
            myList.AddToBeginning(-1);
            myList.AddToBeginning(7);

            myList.printAll();

            //Vehicle a = new Vehicle(); Vehicle is abstract

            Vehicle v = new Car();
            v.Move();

            Vehicle h = null;
            bool shouldBeBoat = true;
            if (shouldBeBoat)
            {
                h = new Boat();
            }
            else
            {
                h = new Car();
            }
            h.Move();
        }
    }
}
