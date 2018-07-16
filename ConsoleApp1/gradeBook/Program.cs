using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace nonsenseTutorials.gradeBook
{
  class Program
  {
    static void Main(string[] args)
    {
      SpeechSynthesizer

      GradeBook book = new GradeBook();
      book.AddGrade(91);
      book.AddGrade(89.5f);
      book.AddGrade(75);

      GradeStatistics stats = book.ComputeStatistics();
      Console.WriteLine(stats.AverageGrade);
      Console.WriteLine(stats.HighestGrade);
      Console.WriteLine(stats.LowestGrade);
    }
  }
}