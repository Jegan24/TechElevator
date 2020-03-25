using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.Models
{
    class LinkedListNode_int
    {
        public int Data { get; set; }
        public LinkedListNode_int next { get; set; }
        public LinkedListNode_int before { get; set; }

        public LinkedListNode_int(int data)
        {
            this.Data = data;
        }
    }
}
