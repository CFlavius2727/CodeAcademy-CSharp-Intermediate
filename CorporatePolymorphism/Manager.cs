using System;

namespace CorporatePolymorphism
{
  // Placeholder for Manager class implementation
  class Manager : Employee
  {
    public override void SubmitDailyReport(){
      Console.WriteLine("Manager submits daily report.");
    }
    public override void Work(){
      Console.WriteLine("Manager oversees the project.");
    }
  }
}
