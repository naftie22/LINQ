namespace LinqDemo
{
    public class BookDatabase
    {
        public static IEnumerable<Book> GetBooksData()
        {
            return new List<Book>
            {
                new Book(121, "Harry Potter", 800, "J.K.Rowling"),
                new Book(186, "Tell me your Dreams", 600, "Sydney Sheldon"),
                new Book(112, "The Monk Who Sold His Ferrari", 350, "Robin Sharma")


            };
        }
    }
}