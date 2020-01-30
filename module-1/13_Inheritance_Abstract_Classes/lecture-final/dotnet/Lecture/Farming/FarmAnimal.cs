using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture.Farming
{
    /// <summary>
    /// A base farm animal class.
    /// </summary>
    public abstract class FarmAnimal : ISingable
    {
        private bool isSleeping;
        public void sleep()
        {
            isSleeping = true;
        }
        public void wakeUp()
        {
            isSleeping = false;
        }

        /// <summary>
        /// The farm animal's name.
        /// </summary>
        public string Name { get; protected set; }

        /// <summary>
        /// Creates a new farm animal.
        /// </summary>
        /// <param name="name">The name which the animal goes by.</param>
        public FarmAnimal(string name)
        {
            Name = name;
        }

        public void reNameIt(string newName)
        {
            Name = newName; 
        }

        public string MakeSoundOnce()
        {
            if (isSleeping)
            {
                return "zzzz";
            }
            else
            {
                return this.MakeAwakeSoundOnce(); 
            }
        }

        public string MakeSoundTwice()
        {
            if (isSleeping)
            {
                return "zzzz zzzz";
            }
            else
            {
                return this.MakeAwakeSoundTwice();
            }
        }


        /// <summary>
        /// The noise made when the farm animal makes a sound.
        /// </summary>
        /// <returns></returns>
        public abstract string MakeAwakeSoundOnce();


        /// <summary>
        /// The noise made when the farm animal makes its sound twice.
        /// </summary>
        /// <returns></returns>
        public abstract string MakeAwakeSoundTwice();

        //force all of our subclasses to have an eat method
        public abstract string eat(); 


    }
}
