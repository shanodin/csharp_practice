namespace Library
{
    internal class Library
    {
        public string Name { get; set; }
        public int Capacity { get; set; }
        public Book[] items { get; }

        public Library(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.items = new Book[capacity];
        }

        public int ItemCount()
        {
            int count = 0;
            foreach (var item in items)
            {
                if (item != null)
                { count++; }
                
            }
            return count;
        }
    }
}