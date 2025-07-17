using System;
using System.Collections.Generic;

public class Library
{
  private List<Book> books = new List<Book>();
  public List<Book> booksFound = new List<Book>();
  
  public void AddBook(Book book){
    books.Add(book);
  }

  public void SearchBooksByTitle(string search){
    foreach(Book book in books){
      if(book.Title.Contains(search)){
        booksFound.Add(book);
      }
    }
  }

  public void DisplayAllBooks(){
    foreach(Book b in booksFound){
      Console.WriteLine($"Title:{b.Title} Author:{b.Author}");
    }
  }
}
