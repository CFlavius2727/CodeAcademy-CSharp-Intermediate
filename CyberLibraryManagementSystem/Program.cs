using System;
using System.Collections.Generic;

namespace LibraryManagementSystem{
  class Program {
    static void Main() {
      // Initialize library
      Library library = new Library();

      // Add some sample books
      Book b1 = new Book();
      b1.Title = "Who do you vodoo";
      b1.Author = "Sam B";
      Book b2 = new Book();
      b2.Title = "1984";
      b2.Author = "Jerry";
      Book b3 = new Book();
      b3.Title = "1984";
      b3.Author = "Billy";

      library.AddBook(b1);
      library.AddBook(b2);
      library.AddBook(b3);
      // Search for a book
      library.SearchBooksByTitle("1984");
     // Console.WriteLine(library.booksFound[0]);

      // Display all books
      library.DisplayAllBooks();
    }
  }
}
