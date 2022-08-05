namespace LinqDemo
{
    public class Book
    {
        public int Id  { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Author { get; set; }

        public Book(int id, string name, double price, string author){
            Id = id;
            Name = name;
            Price = price;
            Author = author;

        }
    }
}
