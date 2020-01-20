using System;

namespace StringsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Ada Lovelace";

            // Strings are actually arrays of characters (char). 
            // Those characters can be accessed using [] notation.

            // 1. Write code that prints out the first and last characters
            //      of name.
            // Output: A
            // Output: e

            Console.WriteLine("First and Last Character. ");
            Console.WriteLine(name[0] + " " + name[name.Length-1]);
           

            // 2. How do we write code that prints out the first three characters
            // Output: Ada

            Console.WriteLine("First 3 characters: ");
            Console.WriteLine(name.Substring(0,3));
            Console.WriteLine("original " + name);

            // 3. Now print out the first three and the last three characters
            // Output: Adaace

             Console.WriteLine("Last 3 characters: ");
            Console.WriteLine(name.Substring(name.Length - 3));

            // 4. What about the last word?
            // Output: Lovelace

            int space = name.IndexOf(" ");
            string lastName = name.Substring(space + 1);
            Console.WriteLine("Last Word: " + lastName );

            // 5. Does the string contain inside of it "Love"?
            // Output: true

             Console.WriteLine("Contains \"Love\"");
            Console.WriteLine( (name.Contains("Love") || name.Contains("love")));

            // 6. Where does the string "lace" show up in name?
            // Output: 8

            int indexOfLace= name.IndexOf("lace");
             Console.WriteLine("Index of \"lace\": " + indexOfLace);

            int indexOfSecondLace =  name.IndexOf("lace",name.IndexOf("lace")+1);

            // 7. How many 'a's OR 'A's are in name?
            // Output: 3

            //options
            //go through it like an array of characters and increment the count if it's a or A
            int count = 0;
            string lowerName = name.ToLower(); 
            for (int i = 0; i < lowerName.Length; i++)
            {
                if (lowerName[i]=='a')
                {
                    count++;
                }
            }

            //find the index of A or a, increment count and then look through a substring to the right of that
            int indexOfA = lowerName.IndexOf('a');
            int countStr = 0; 
            while(indexOfA >=0)
            {
                countStr++;
                //if (indexOfA < lowerName.Length - 1)
                {
                    lowerName = lowerName.Substring(++indexOfA);
                    indexOfA = lowerName.IndexOf('a');
                }
 
            }
            Console.WriteLine("Number of \"a's\": " + count + " or using index/substring: "+countStr);

            // 8. Replace "Ada" with "Ada, Countess of Lovelace"

            
            name= name.Replace("Ada", "Ada, Countess of Loevelace");
            Console.WriteLine(name);

            // 9. Set name equal to null.
            name = null;
            // int test = name.IndexOf('a');  this is an error

            name = "";
            int testb = name.IndexOf('a');

            // 10. If name is equal to null or "", print out "All Done".
            // if (name==null || name.Equals("")) 
            if (name == null || name=="")
            {
                
                Console.WriteLine("all done");
            }
            Console.ReadLine();
        }
    }
}