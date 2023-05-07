using homework_26._04._2023.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_26._04._2023
{
    internal class Controller {
        public string GetBook(string bookName) { 
            Database db = new Database();
            Book bk = db.Find(bookName);

            if(bk != null) { 
                return bk.ToString();
            }
            return "Книга не найдена!";
        } 
    }

}
