using System;

namespace BiblioInheritance
{
  class Periodical : Resource
  {
    public string Period
    {get;set;}

    public Periodical(string period, string title, string category) : base(title, category){
      this.Period = period;
    }
    public override void UpdateStatus(){
        this.Status = "In-use";
      }
    }
  }
