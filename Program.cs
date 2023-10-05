namespace Datastructure_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                Console.WriteLine("*********************************************************************");
                Console.WriteLine("Choose any program.");
                Console.WriteLine("1. Create custom linked list.\n" +
                    "2. Create custom stack.\n" +
                    "3. Create custom queue.\n" +
                    "4. built-in LinkedList datasructure CRUD operations.\n" +
                    "5. built-in Stack datasructure CRUD operations.\n" +
                    "6. built-in queue datasructure CRUD operations.\n" +
                    "7. Exit.");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        CustomLinkedList<int> list = new CustomLinkedList<int>();
                        list.Add(1);
                        list.Add(2);
                        list.Add(3);
                        Console.WriteLine("Linked List:");
                        list.Display();
                        list.Remove(2);
                        Console.WriteLine("After removing 2:");
                        list.Display();
                        break;
                    case 2:
                        CustomStack<int> stack = new CustomStack<int>();

                        stack.Push(1);
                        stack.Push(2);
                        stack.Push(3);

                        Console.WriteLine("Stack Count: " + stack.Count());
                        Console.WriteLine("Top element: " + stack.Peek());
                        Console.WriteLine("Popped element: " + stack.Pop());
                        Console.WriteLine("Stack Count after pop: " + stack.Count());
                        stack.Clear();
                        Console.WriteLine("Stack Count after clear: " + stack.Count());
                        break;
                    case 3:
                        CustomQueue<int> queue = new CustomQueue<int>();
                        queue.Inqueue(1);
                        queue.Inqueue(2);
                        queue.Inqueue(3);
                        Console.WriteLine("Queue Count: " + queue.Count());
                        Console.WriteLine("First element: " + queue.Peek());
                        Console.WriteLine("Deleted element: " + queue.Delete());
                        Console.WriteLine("Queue Count after deleted: " + queue.Count());
                        queue.Clear();
                        Console.WriteLine("Queue Count after clear: " + queue.Count());
                        break;
                    case 4:
                        BuiltInLinkedList builtInLinkedList = new BuiltInLinkedList();
                        break;
                    case 5:
                        BuiltInStack builtInStack = new BuiltInStack();
                        break;
                    case 6:
                        BuiltInQueue builtInQueue = new BuiltInQueue();
                        break;
                        case 7:
                        return;
                }
            }
        }
    }
}