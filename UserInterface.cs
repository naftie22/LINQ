using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LinqDemo
{
    public class UserInterface
    {
        static void Main()
        {
            var books = BookDatabase.GetBooksData();
            
            //var data = from b in books select b.Author; query based syntax
            //var data = books.Select(b => b.Author);   //method based syntax
            //extracting bookname and price
            var data = books.Select(b => new{
                BookName = b.Name,
                BookPrice = b.Price
            
            });
            foreach(var item in data)
            {
                Console.WriteLine($"{item.BookName} - {item.BookPrice}");
            }

        }
    }
}