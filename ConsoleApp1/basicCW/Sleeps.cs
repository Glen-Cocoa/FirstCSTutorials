using System;

namespace nonsenseTutorials.basicCW
{
  class Sleeps
  {
    public void sleeps()
    {
      Console.WriteLine("NAME:");
      string name = Console.ReadLine();

      Console.WriteLine("HOW MUCH SLEEP DID YOU TAKE YESTER NIGHT");
      int hoursOfSleep = int.Parse(Console.ReadLine());

      Console.WriteLine("GREETINGS {0}", name);
      if (hoursOfSleep < 4)
      {
        Console.WriteLine("NO WONDER YOU ARE SLEEPY");
      }
      else
      {
        Console.WriteLine("GOOD ON YOU");
      }
    }
    }
  }
