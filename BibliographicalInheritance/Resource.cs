using System;

namespace BiblioInheritance
{
  class Resource
  {
    public string Title
    {get; private set;}

    public string Category
    {get; private set;}

    public string Status
    {get; protected set;}

    public Resource(){
      this.Status = "Available";
    }

    public Resource(string title, string category){
      this.Title = title;
      this.Category = category;
    }

    public virtual void UpdateStatus(){
      if(this.Status == "Out"){
        this.Status = "Available";
      }
    }

    public virtual void GetInfo(){
      Console.WriteLine($"Title:{this.Title}\nCategory:{this.Category}\nStatus:{this.Status}");
    }
  }

}
