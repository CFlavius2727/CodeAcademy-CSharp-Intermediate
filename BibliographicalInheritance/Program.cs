using System;

namespace BiblioInheritance
{
  class Program
  {
    static void Main(string[] args)
    {
      Resource test = new Resource();
      test.UpdateStatus();
      test.GetInfo();
      Console.WriteLine(test.Status);

      Console.WriteLine();
      Book book = new Book("Charles Petzold",396,"Code: The Hidden Language of Computer Hardware and Software","Non-Fiction");
      book.UpdateStatus();
      book.GetInfo();

      Console.WriteLine();
      Periodical p = new Periodical("Monthly","Wired","Technology");
      p.UpdateStatus();
      p.GetInfo();

      Console.WriteLine();
      Video v = new Video("Alexa Garland",108,"On-Demand","Ex Machina","Sci-Fi");
      v.UpdateStatus();
      v.GetInfo();
    }
  }
}
