using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.Models
{
    class LinkedList_int
    {
        private LinkedListNode_int start = null;
        private LinkedListNode_int end = null;

        private void AddToBeginning(LinkedListNode_int lln)
        {
            if (start == null)
            {
                start = lln;
                end = lln;
            }
            else
            {
                lln.next = start;
                start = lln;
            }
        }
        public void AddToBeginning(int newInt)
        {
            LinkedListNode_int newNode = new LinkedListNode_int(newInt);
            AddToBeginning(newNode);

        }
        /// <summary>
        /// this method traverses our entire linked list and prints all the data
        /// </summary>
        public void printAll()
        {
            LinkedListNode_int thisNode = start;
            while (thisNode != null)
            {
                Console.WriteLine(thisNode.Data);
                thisNode = thisNode.next; 
            }
        }

    }
}
