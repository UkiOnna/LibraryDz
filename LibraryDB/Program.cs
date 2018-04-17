using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDB
{
    class Program
    {
        static void Main(string[] args)
        {
            using (LibraryContext context = new LibraryContext())
            {
               // 1 zadanie
                var zapros1 = from visitors in context.Visitors
                              where (visitors.IsDeptor) == true
                              select new { visitors.Name };
                var debtors = zapros1.ToList();
                ////////////////

                //2 zadanie
                var zapros2 = from books in context.Books
                              where books.Id==3
                              select new { books.Authors };
                var booksThirdAuthors = zapros2.ToList();
                /////////////

                //3 adanie
                var zapros3 = from visitors in context.Visitors
                              where visitors.Books!=context.Books
                              select new { context.Books };
                var booksFree = zapros3.ToList();
                /////////////////

                //4 zadanie
                var zapros4 = from visitors in context.Visitors
                              where visitors.Id==2
                              select new { visitors.Books };
                var booksUserSecond = zapros4.ToList();
                //////////////

                //5 zadanie
                var zapros5 = from visitors in context.Visitors
                              where visitors.IsDeptor==true
                              select visitors;
                var deptorVisitors = zapros5.ToList();
                deptorVisitors.ForEach(deptor => { deptor.IsDeptor = false; });
                //////////


                context.SaveChanges();


            }
        }
    }
}
