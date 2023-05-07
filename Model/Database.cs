using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_26._04._2023.Model
{
    internal class Database {
        public List<Book> books = new List<Book>();

        public Database() { 
            books.Add(new Book("Rich dad - Poor dad", "Robert Kowasaki"));
            books.Add(new Book("Chuma", "Albert Kamy"));
            books.Add(new Book("We", "Igor Zamyatin"));
            books.Add(new Book("4", "K.D."));
            books.Add(new Book("5", "K.O."));
        }

        public Book Find(string bookName) {
            foreach(Book book in books) { 
                if(book.name == bookName) { 
                    return book;
                }
            }
            return null;
        }

    }

}
