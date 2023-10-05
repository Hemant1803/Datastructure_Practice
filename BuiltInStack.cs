using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructure_Practice
{
    internal class BuiltInStack
    {
        public BuiltInStack()
        {
            Stack<int> stack = new Stack<int>();            
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);            
            int topElement = stack.Peek();
            Console.WriteLine($"Top Element (Peek): {topElement}");            
            int poppedElement = stack.Pop();
            Console.WriteLine($"Popped Element: {poppedElement}");
            stack.Push(4);
            Console.WriteLine("Updated Stack:");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }           
        }
    }
}

