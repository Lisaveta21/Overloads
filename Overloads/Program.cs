using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;



namespace Indeksators
{
    class List
    {
        public string Name { get; set; }
        public double Author { get; set; }

        public override string ToString()
        {
            return $"{Name} {Author} $\n";
        }
    }

    class Books
    {
        List[] bookArr;

        public Books(int size)
        {
            bookArr = new List[size];
        }

        public int Length
        {
            get { return bookArr.Length; }
        }

        public List this[int index]
        {
            get
            {
                if (index >= 0 && index < bookArr.Length)
                {
                    return bookArr[index];
                }
                throw new IndexOutOfRangeException();
            }
            set
            {
                bookArr[index] = value;
            }
        }

    }

    class Indeksators
    {
        private static List GetBooks()
        {
            return books;
        }

        static void Main(string[] args, List books)
        {
            List books = new List(3);
            books[0] = new Book
            {
               Name = "Collection",
                Author = "John Fauls"
            };
            books[1] = new book
            {
                Name = "1984",
                Author = "George Oruel"
            };
            books[2] = new book
            {
                Name = "Sherlock Holmes",
                Author = "Conon-Doel"
            };

            try
            {
                for (int i = 0; i < List.Length; i++)
                {
                    WriteLine(books[i]);
                }
            }
            catch (Exception e)
            {
                WriteLine(e.Message);
            }
        }
    }

    internal class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
    }
}
