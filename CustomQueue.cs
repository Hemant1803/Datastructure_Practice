namespace Datastructure_Practice
{
    internal class CustomQueue<T>
    {
        private LinkedList<T> items;

        public CustomQueue()
        {
            items = new LinkedList<T>();
        }

        public void Inqueue(T item)
        {
            items.AddLast(item);
        }

        public T Delete()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Queue is empty.");
            }

            T deletedItem = items.First.Value;
            items.RemoveFirst();
            return deletedItem;
        }

        public T Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Queue is empty.");
            }

            return items.First.Value;
        }

        public bool IsEmpty()
        {
            return items.Count == 0;
        }

        public int Count()
        {
            return items.Count;
        }

        public void Clear()
        {
            items.Clear();
        }

    }
}