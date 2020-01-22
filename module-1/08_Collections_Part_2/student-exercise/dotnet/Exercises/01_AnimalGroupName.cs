using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         * Given the name of an animal, return the name of a group of that animal
         * (e.g. "Elephant" -> "Herd", "Rhino" - "Crash").
         *
         * The animal name should be case insensitive so "elephant", "Elephant", and
         * "ELEPHANT" should all return "herd".
         *
         * If the name of the animal is not found, null, or empty, return "unknown".
         *
         * Rhino -> Crash
         * Giraffe -> Tower
         * Elephant -> Herd
         * Lion -> Pride
         * Crow -> Murder
         * Pigeon -> Kit
         * Flamingo -> Pat
         * Deer -> Herd
         * Dog -> Pack
         * Crocodile -> Float
         *
         * AnimalGroupName("giraffe") → "Tower"
         * AnimalGroupName("") -> "unknown"
         * AnimalGroupName("walrus") -> "unknown"
         * AnimalGroupName("Rhino") -> "Crash"
         * AnimalGroupName("rhino") -> "Crash"
         * AnimalGroupName("elephants") -> "unknown"
         *
         */
        public string AnimalGroupName(string animalName)
        {
            Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();
            TextInfo myTI = new CultureInfo("en-US", false).TextInfo;
            string s = myTI.ToTitleCase(animalName);
            keyValuePairs.Add("Rhino", "Crash");
            keyValuePairs.Add("Giraffe", "Tower");
            keyValuePairs.Add("Elephant", "Herd");
            keyValuePairs.Add("Lion", "Pride");
            keyValuePairs.Add("Crow", "Murder");
            keyValuePairs.Add("Pigeon", "Kit");
            keyValuePairs.Add("Flamingo", "Pat");
            keyValuePairs.Add("Deer", "Herd");
            keyValuePairs.Add("Dog", "Pack");
            keyValuePairs.Add("Crocodile", "Float");

            return keyValuePairs.ContainsKey(s) ? keyValuePairs[s] : "unknown";            
        }
    }
}
