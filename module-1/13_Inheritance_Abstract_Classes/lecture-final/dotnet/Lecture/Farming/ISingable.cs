using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture.Farming
{
    interface ISingable
    {
        string Name { get; }
        string MakeSoundOnce();
        string MakeSoundTwice();
        //void reNameTheThing(string newName); //i am allowed to have parameters for my method


    }
}
