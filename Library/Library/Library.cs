using System.Collections.Generic;

namespace Library
{
    internal class Library
    {
        public string Name { get; set; }
        public int Capacity { get; set; }
        public List<Book> Items { get; }

        public Library(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.Items = new List<Book>();
        }

        public int ItemCount()
        {
            return this.Items.Count;
            //int count = 0;
            //foreach (var item in Items)
            //{
            //    if (item != null)
            //    { count++; }
            //}
            //return count;
        }

        public void AddItem(Book book)
        {
            this.Items.Add(book);
            //if (this.ShelvesFull())
            //{
            //    return;
            //}
            //int itemCount = this.ItemCount();
            //this.Items[itemCount] = book;
        }
        
        //public bool ShelvesFull()
        //{
        //    return this.ItemCount() == this.Items.Length;
        //}

        public void ClearShelves()
        {
            this.Items.Clear();
            //for(int i = 0; i < Items.Length; i++)
            //{
            //    Items[i] = null;
            //}
        }
    }
}