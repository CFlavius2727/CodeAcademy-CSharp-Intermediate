using System;

namespace BiblioInheritance
{
 class Book : Resource
 {
  public string Author
  {get; set;}

  public int PageCount
  {get;set;}

  public Book(string author, int pageCount, string title, string category) : base(title,category){
    this.Author = author;
    this.PageCount = pageCount;
  }
  public override void UpdateStatus(){
    this.Status = "Available";
  }
 }
}
