using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.Models
{
    abstract class Vehicle
    {
        public virtual void Move() //virtual means the subclass is allowed to override
        {
            //pretend this has something in it
            //this is why we'd use an abstract class
        }

        public abstract void Stop(); //subclass MUST override
    }
}
