using System;
using System.Collections.Generic;


namespace CollectionsLectureNotes
{
    class Program
    {
        static void Main(string[] args)
        {
            //some review
            string name = "c";
            char c = 'c';
      
           // Console.WriteLine(name.Equals(c.ToString()));

            // LIST<T>
            //
            // Lists allow us to hold collections of data. They are declared with a type of data that they hold
            // only allowing items of that type to go inside of them.
            //
            // The syntax used for declaring a new list of type T is
            //      List<T> list = new List<T>();
            //
            //

            // Creating lists of integers
            List<int> myList = new List<int>();
            List<int> theSecondListOfInts = new List<int>();

            // Creating lists of strings
            List<string> myListOStrings = new List<string>();

            Console.WriteLine(myList);

            /////////////////


            //////////////////
            // OBJECT EQUALITY
            //////////////////
            if (myList == theSecondListOfInts) //== to compare two empty lists of integers
            {
                Console.WriteLine("The two lists are the same");
            }
            else
            {
                Console.WriteLine("== compares addresses");
            }

            theSecondListOfInts = myList;

            if (myList == theSecondListOfInts) //== to compare two empty lists of integers
            {
                Console.WriteLine("2 The two lists are the same");
            }
            else
            {
                Console.WriteLine("2 == compares addresses");
            }

            /////////////////
            // ADDING ITEMS
            /////////////////

            // Adding items one at a time to each list
            myList.Add(4);
            myList.Add(200);
            //myList.Add("four"); 

            myListOStrings.Add("c# is great");

            /////////////////
            // ADDING MULTIPLE ITEMS
            /////////////////
            int[] numsToAdd = { 4, 5, 6 };
            myList.AddRange(numsToAdd);
            //myList.AddRange(theSecondListOfInts); 


            //////////////////
            // ACCESSING BY INDEX
            //////////////////

            for (int i=0; i < myList.Count; i++)
            {
                Console.Write("At index "+i+" the value is "+myList[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < myList.Count; i++)
            {
                Console.Write($"At index {i} the value is {myList[i]} ");
            }


            ///////////////////
            // ACCESSING WITH FOR-EACH
            ///////////////////

            foreach(int intItem in myList)
            {
                Console.WriteLine(intItem); 
            }

            //exactly the same as saying
            /* for (int i=0; i<myList.Length; i++)
             * {
             *     int item = myList[i]; 
             */
            ////////////////////
            // ADDITIONAL LIST<T> METHODS
            ////////////////////
            bool contains2 = myList.Contains(2);
            Console.WriteLine($"Is 2 in teh list? {contains2}");

            //where is the number 2?
            int searchFor = 55; 
            myList.Add(searchFor);
            myList.Add(searchFor); 
            int first = myList.IndexOf(searchFor);
            int last = myList.LastIndexOf(searchFor);
            Console.WriteLine($"{searchFor} first occurs at {first} and last occurs at {last}");

            Console.WriteLine("list before insert 500 at 4");
            foreach (int intItem in myList)
            {
                Console.WriteLine(intItem);
            }
            myList.Insert(4, 500);

            Console.WriteLine("list after insert 500 at 4");
            foreach (int intItem in myList)
            {
                Console.WriteLine(intItem);
            }

            ////////////////////////
            // SORT and PRINT A LIST
            ////////////////////////
            myList.Sort();
            Console.WriteLine("after the list sorted");
            foreach (int intItem in myList)
            {
                Console.WriteLine(intItem);
            }

            myList.Reverse(); //now this should be sorted in reverse order
            Console.WriteLine("after the list reversed");
            foreach (int intItem in myList)
            {
                Console.WriteLine(intItem);
            }

            //let's write a little easier
            Console.WriteLine(String.Join(", ", myList));

            List<int> firstHalf = myList.GetRange(0, myList.Count / 2);
            List<int> secondHalf = myList.GetRange(myList.Count / 2, myList.Count / 2);

            Console.WriteLine("First half" + String.Join(", ", firstHalf));
            Console.WriteLine("Second half" + String.Join(", ", secondHalf));

            firstHalf.RemoveAt(0);
            Console.WriteLine("after remove from first half");
            Console.WriteLine("First half" + String.Join(", ", firstHalf));
            Console.WriteLine("My list"+String.Join(", ", myList));

            // QUEUE <T>
            //
            // Queues are a special type of data structure that follow First-In First-Out (FIFO).
            // With Queues, we Enqueue (add) and Dequeue (remove) items.

            Queue<string> priorities = new Queue<string>();
            priorities.Enqueue("clean the dishes");
            priorities.Enqueue("wash the counters");
            priorities.Enqueue("sweep the floor");
            priorities.Enqueue("walk the dog");

            /////////////////////
            // PROCESSING ITEMS IN A QUEUE
            /////////////////////

            //can i look at the next one without removing
            //while (priorities.Count > 0) don't do this, peek does not remove so looping through by count will be infinite
            {
                string nextPriority = priorities.Peek();
                Console.WriteLine("Next priority: " + nextPriority);
            }

            priorities.Contains("walk the dog"); 

            while (priorities.Count > 0)
            {
                string nextPriority = priorities.Dequeue();
                Console.WriteLine("Next priority: " + nextPriority); 
            }



            // STACK <T>
            //
            // Stacks are another type of data structure that follow Last-In First-Out (LIFO).
            // With Stacks, we Push (add) and Pop (remove) items. 

            Stack<string> browserStack = new Stack<string>();


            ////////////////////
            // PUSHING ITEMS TO THE STACK
            //////////////////// 
            browserStack.Push("www.google.com");
            browserStack.Push("www.cnn.com");
            browserStack.Push("www.facebook.com");
            browserStack.Push("twitch.tv");


            ////////////////////
            // POPPING THE STACK
            ////////////////////

            Console.WriteLine("peek:"+browserStack.Peek());

            while(browserStack.Count>0)
            {
                string previousPage = browserStack.Pop();
                Console.WriteLine("previous page: " + previousPage);
            }


        }
    }
}
