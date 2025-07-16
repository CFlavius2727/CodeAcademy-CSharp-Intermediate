using System;

namespace BiblioInheritance
{
  class Video : Resource
  {
    public string Director
    {get;set;}

    public int Runtime
    {get;set;}

    public string MediaType
    {get;set;}

    public Video(string director, int runtime, string mediaType, string title, string category) : base(title,category){
      this.Director = director;
      this.Runtime = runtime;
      this.MediaType = mediaType;
    }

    public override void GetInfo(){
      Console.WriteLine($"Title:{this.Title}\nCategory:{this.Category}\nDirector:{this.Director}\nRuntime:{this.Runtime}\nMediaType:{this.MediaType}\nStatus:{this.Status}");
    }

    public override void UpdateStatus(){
      this.Status = "Ongoing";
    }
  }
}
