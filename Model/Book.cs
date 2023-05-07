using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_26._04._2023.Model
{
    internal class Book {
        public string name { get; set; }
        public string author { get; set; }

        public Book() { }
        public Book(string name, string author) { 
            this.name = name;
            this.author = author;
        }

        public override string ToString() {
            return $"Name: {name}\t Author: {author}";
        }
    }

}
