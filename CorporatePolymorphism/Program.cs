using System;
using System.Collections.Generic;

namespace CorporatePolymorphism
{
  class Program
  {
    static void Main(string[] args)
    { 
      //*********************************
      //******* Task3 Test Code *********
      //*********************************
      Employee hrRep = new HR();

      hrRep.ClockIn();
      hrRep.Work();
      hrRep.SubmitDailyReport();
      Console.WriteLine(); //Line break
      //*********************************
      //******* Task3 Test Code *********
      //*********************************

      // Placeholder for list of employees
      Employee employee1 = new Engineer();
      employee1.SubmitDailyReport();
      // Placeholder for adding employees to the list
      Employee employee2 = new Manager();
      Employee employee3 = new Intern();
      employee2.ClockIn();
      employee2.Work();
      employee2.SubmitDailyReport();
      employee3.ClockIn();
      employee3.Work();
      employee3.SubmitDailyReport();

      Engineer engineer1 = employee1 as Engineer;
      if(engineer1!=null){
        engineer1.SubmitDailyReport();
      }else{
        Console.WriteLine("Downcast failed.");
      }

      List<Employee> employees = new List<Employee>();
      employees.Add(employee1);
      employees.Add(employee2);
      employees.Add(employee3);

      Console.WriteLine();
      foreach(Employee i in employees){
        if(i is Engineer){
          Console.WriteLine("This is an Engineer!");
        }else if(i is Intern){
          Console.WriteLine("This is an Intern!");
        }else if(i is Manager){
          Console.WriteLine("This is a Manager! ");
        }
        i.ClockIn();
        i.Work();
        i.SubmitDailyReport();
        Console.WriteLine();
      }
    }
  }
}
