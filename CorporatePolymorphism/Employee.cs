using System;

namespace CorporatePolymorphism
{
  // Placeholder for Employee class implementation
  public abstract class Employee
  {
    public abstract void SubmitDailyReport();

    public virtual void Work(){
      Console.WriteLine("Employee is working.");
    }

    public void ClockIn(){
      Console.WriteLine("Employee clocks in.");
    }

  }
}
