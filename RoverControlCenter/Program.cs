using System;

namespace RoverControlCenter
{
  class Program
  {
    static void Main(string[] args)
    {
      MoonRover lunokhod = new MoonRover("Lunokhod 1", 1970);
      MoonRover apollo = new MoonRover("Apollo 15", 1971);
      MarsRover sojourner = new MarsRover("Sojourner", 1997);
      Satellite sputnik = new Satellite("Sputnik", 1957); 
  		
      Rover[] rovers = new Rover[]{lunokhod,apollo,sojourner};
      //DirectAll(rovers);

      Object[] probes = new Object[]{lunokhod,apollo,sojourner,sputnik};
      foreach(Object x in probes){
        Console.WriteLine($"Tracking a {x.GetType()}");
      }

      IDirectable[] directables = new IDirectable[]{lunokhod,apollo,sojourner,sputnik};
      DirectAll(directables);
    }

    static void DirectAll(IDirectable[] directable){
      foreach(IDirectable x in directable){
        Console.WriteLine(x.GetInfo());
        Console.WriteLine(x.Explore());
        Console.WriteLine(x.Collect());
      }
    }
  }
}
