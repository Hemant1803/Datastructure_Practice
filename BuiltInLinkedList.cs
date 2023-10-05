using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructure_Practice
{
    internal class BuiltInLinkedList
    {
        public BuiltInLinkedList() 
        {
            
            LinkedList<int> linkedList = new LinkedList<int>();            
            linkedList.AddLast(1);
            linkedList.AddLast(2);
            linkedList.AddLast(3);            
            int firstElement = linkedList.First.Value;
            int lastElement = linkedList.Last.Value;
            Console.WriteLine($"First Element: {firstElement}");
            Console.WriteLine($"Last Element: {lastElement}");           
            LinkedListNode<int> node = linkedList.Find(2);
            if (node != null)
            {
                node.Value = 4;
            }
            Console.WriteLine("Updated Linked List:");
            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }           
            LinkedListNode<int> nodeToRemove = linkedList.Find(3);
            if (nodeToRemove != null)
            {
                linkedList.Remove(nodeToRemove);
            }
            Console.WriteLine("Linked List After Removing 3:");
            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }
        }
    }
}

    
