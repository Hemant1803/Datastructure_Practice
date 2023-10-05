namespace Datastructure_Practice
{
    internal class BuiltInQueue
    {
        public BuiltInQueue() 
        {
            // Create a new Queue of integers
            Queue<int> queue = new Queue<int>();

            // Create (Enqueue) elements
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

           
            int firstElement = queue.Peek();
            Console.WriteLine($"First Element (Peek): {firstElement}");

            int deleteElement = queue.Dequeue();
            Console.WriteLine($"Deleted Element: {deleteElement}");
            queue.Enqueue(4);

            Console.WriteLine("Updated Queue:");

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

          
        }
    }
    
}